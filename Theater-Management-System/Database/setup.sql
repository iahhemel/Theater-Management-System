

IF DB_ID('FSummerDb') IS NULL
BEGIN
    CREATE DATABASE FSummerDb;
END
GO

USE FSummerDb;
GO

IF OBJECT_ID('dbo.Movie', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Movie
    (
        Id          VARCHAR(20)   NOT NULL PRIMARY KEY,
        Title       VARCHAR(200)  NOT NULL,
        IMDB        DECIMAL(4,1)  NOT NULL,
        Income      DECIMAL(18,2) NOT NULL,
        ReleaseDate VARCHAR(20)   NOT NULL,
        Genre       VARCHAR(50)   NOT NULL,
        PosterPath  VARCHAR(260)  NULL
    );
END
GO

IF COL_LENGTH('dbo.Movie', 'PosterPath') IS NULL
BEGIN
    ALTER TABLE dbo.Movie ADD PosterPath VARCHAR(260) NULL;
END
GO


IF OBJECT_ID('dbo.Users', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users
    (
        Id       VARCHAR(50)  NOT NULL PRIMARY KEY,
        Name     VARCHAR(100) NOT NULL,
        Password VARCHAR(100) NOT NULL,
        Role     VARCHAR(20)  NOT NULL DEFAULT ('User')
    );
END
GO


IF OBJECT_ID('dbo.Show', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Show
    (
        ShowId      INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        MovieId     VARCHAR(20)   NOT NULL,
        ShowTime    VARCHAR(20)   NOT NULL,
        TotalSeats  INT           NOT NULL DEFAULT (100),
        BookedSeats INT           NOT NULL DEFAULT (0),
        CONSTRAINT FK_Show_Movie FOREIGN KEY (MovieId) REFERENCES dbo.Movie(Id),
        CONSTRAINT UQ_Show_Movie_Time UNIQUE (MovieId, ShowTime),
        CONSTRAINT CK_Show_Seats CHECK (BookedSeats >= 0 AND BookedSeats <= TotalSeats)
    );
END
GO

IF OBJECT_ID('dbo.Booking', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Booking
    (
        BookingId   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        UserId      VARCHAR(50)   NOT NULL,
        MovieId     VARCHAR(20)   NOT NULL,
        ShowId      INT           NULL,
        ShowTime    VARCHAR(20)   NOT NULL,
        Quantity    INT           NOT NULL,
        TotalPrice  DECIMAL(18,2) NOT NULL,
        BookingDate DATETIME      NOT NULL DEFAULT (GETDATE()),
        CONSTRAINT FK_Booking_Users  FOREIGN KEY (UserId)  REFERENCES dbo.Users(Id),
        CONSTRAINT FK_Booking_Movie  FOREIGN KEY (MovieId) REFERENCES dbo.Movie(Id),
        CONSTRAINT FK_Booking_Show   FOREIGN KEY (ShowId)  REFERENCES dbo.Show(ShowId) ON DELETE CASCADE
    );
END
ELSE
BEGIN

    IF COL_LENGTH('dbo.Booking', 'ShowId') IS NULL
    BEGIN
        ALTER TABLE dbo.Booking ADD ShowId INT NULL;
        ALTER TABLE dbo.Booking ADD CONSTRAINT FK_Booking_Show FOREIGN KEY (ShowId) REFERENCES dbo.Show(ShowId) ON DELETE CASCADE;
    END
END
GO


IF EXISTS (
    SELECT 1 FROM sys.foreign_keys
    WHERE name = 'FK_Booking_Show' AND delete_referential_action = 0
)
BEGIN
    ALTER TABLE dbo.Booking DROP CONSTRAINT FK_Booking_Show;
    ALTER TABLE dbo.Booking ADD CONSTRAINT FK_Booking_Show
        FOREIGN KEY (ShowId) REFERENCES dbo.Show(ShowId) ON DELETE CASCADE;
END
GO


IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Id = 'admin')
BEGIN
    INSERT INTO dbo.Users (Id, Name, Password, Role)
    VALUES ('admin', 'Administrator', 'admin123', 'Admin');
END
GO


IF NOT EXISTS (SELECT 1 FROM dbo.Movie)
BEGIN
    INSERT INTO dbo.Movie (Id, Title, IMDB, Income, ReleaseDate, Genre) VALUES
    ('M001', 'Inception',        8.8, 829895144.00, '2010-07-16', 'action'),
    ('M002', 'The Grand Budapest Hotel', 8.1, 173000000.00, '2014-03-28', 'comedy'),
    ('M003', 'The Conjuring',    7.5, 319494638.00, '2013-07-19', 'horror'),
    ('M004', 'Parasite',         8.6, 258000000.00, '2019-05-30', 'drama'),
    ('M005', 'Indiana Jones and the Last Crusade', 8.2, 474171806.00, '1989-05-24', 'adventure'),
    ('M006', 'Se7en',            8.6, 327000000.00, '1995-09-22', 'thriller');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Show)
BEGIN
    INSERT INTO dbo.Show (MovieId, ShowTime, TotalSeats, BookedSeats)
    SELECT m.Id, st.ShowTime, 50, 0
    FROM dbo.Movie m
    CROSS JOIN (VALUES ('10:00 AM'), ('1:00 PM'), ('4:00 PM'), ('7:00 PM'), ('10:00 PM')) AS st(ShowTime);
END
GO
