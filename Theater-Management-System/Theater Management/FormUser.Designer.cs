namespace Theater_Management
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbRatings = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbAllGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtEnterMovieName = new System.Windows.Forms.TextBox();
            this.lblSearchMovieByTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAvailableMovies = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fSummerDbDataSet = new Theater_Management.FSummerDbDataSet();
            this.lblAvailableMovies = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbllblReleaseDateDetails = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblRatingDetails = new System.Windows.Forms.Label();
            this.lblSMDRating = new System.Windows.Forms.Label();
            this.lblGenreDetails = new System.Windows.Forms.Label();
            this.lblSMDGenre = new System.Windows.Forms.Label();
            this.lblMovieTitleDetails = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblMovieIdDetails = new System.Windows.Forms.Label();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.lblSelectedMovieDetails = new System.Windows.Forms.Label();
            this.picSMDPoster = new System.Windows.Forms.PictureBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.nudNumberOfTickets = new System.Windows.Forms.NumericUpDown();
            this.cmbShowTime = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblBookYourTicket = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblSeatsInfo = new System.Windows.Forms.Label();
            this.movieTableAdapter = new Theater_Management.FSummerDbDataSetTableAdapters.MovieTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblEnjoyYourFvtMovie = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.lblUserDb = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSummerDbDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSMDPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTickets)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cmbRatings);
            this.panel1.Controls.Add(this.lblRating);
            this.panel1.Controls.Add(this.cmbAllGenre);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.txtEnterMovieName);
            this.panel1.Controls.Add(this.lblSearchMovieByTitle);
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 101);
            this.panel1.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(1332, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 42);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbRatings
            // 
            this.cmbRatings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRatings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRatings.FormattingEnabled = true;
            this.cmbRatings.Location = new System.Drawing.Point(805, 53);
            this.cmbRatings.Name = "cmbRatings";
            this.cmbRatings.Size = new System.Drawing.Size(150, 33);
            this.cmbRatings.TabIndex = 5;
            this.cmbRatings.Text = "All Ratings";
            this.cmbRatings.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
            // 
            // lblRating
            // 
            this.lblRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(829, 5);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(73, 27);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating";
            // 
            // cmbAllGenre
            // 
            this.cmbAllGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbAllGenre.FormattingEnabled = true;
            this.cmbAllGenre.Location = new System.Drawing.Point(339, 55);
            this.cmbAllGenre.Name = "cmbAllGenre";
            this.cmbAllGenre.Size = new System.Drawing.Size(172, 33);
            this.cmbAllGenre.TabIndex = 3;
            this.cmbAllGenre.Text = "All Genres";
            this.cmbAllGenre.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(378, 5);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 27);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            // 
            // txtEnterMovieName
            // 
            this.txtEnterMovieName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEnterMovieName.Location = new System.Drawing.Point(34, 55);
            this.txtEnterMovieName.Multiline = true;
            this.txtEnterMovieName.Name = "txtEnterMovieName";
            this.txtEnterMovieName.Size = new System.Drawing.Size(199, 31);
            this.txtEnterMovieName.TabIndex = 1;
            this.txtEnterMovieName.Text = "Enter Movie Name";
            this.txtEnterMovieName.TextChanged += new System.EventHandler(this.filter_Changed);
            this.txtEnterMovieName.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtEnterMovieName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblSearchMovieByTitle
            // 
            this.lblSearchMovieByTitle.AutoSize = true;
            this.lblSearchMovieByTitle.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMovieByTitle.Location = new System.Drawing.Point(29, 5);
            this.lblSearchMovieByTitle.Name = "lblSearchMovieByTitle";
            this.lblSearchMovieByTitle.Size = new System.Drawing.Size(233, 27);
            this.lblSearchMovieByTitle.TabIndex = 0;
            this.lblSearchMovieByTitle.Text = "Search Movie By Title";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvAvailableMovies);
            this.panel2.Controls.Add(this.lblAvailableMovies);
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1455, 265);
            this.panel2.TabIndex = 7;
            // 
            // dgvAvailableMovies
            // 
            this.dgvAvailableMovies.AllowUserToAddRows = false;
            this.dgvAvailableMovies.AllowUserToDeleteRows = false;
            this.dgvAvailableMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvailableMovies.AutoGenerateColumns = false;
            this.dgvAvailableMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableMovies.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAvailableMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.iMDBDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.dgvAvailableMovies.DataSource = this.movieBindingSource;
            this.dgvAvailableMovies.Location = new System.Drawing.Point(6, 26);
            this.dgvAvailableMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAvailableMovies.Name = "dgvAvailableMovies";
            this.dgvAvailableMovies.ReadOnly = true;
            this.dgvAvailableMovies.RowHeadersWidth = 51;
            this.dgvAvailableMovies.RowTemplate.Height = 24;
            this.dgvAvailableMovies.Size = new System.Drawing.Size(1459, 223);
            this.dgvAvailableMovies.TabIndex = 1;
            this.dgvAvailableMovies.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMDBDataGridViewTextBoxColumn
            // 
            this.iMDBDataGridViewTextBoxColumn.DataPropertyName = "IMDB";
            this.iMDBDataGridViewTextBoxColumn.HeaderText = "IMDB";
            this.iMDBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iMDBDataGridViewTextBoxColumn.Name = "iMDBDataGridViewTextBoxColumn";
            this.iMDBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.fSummerDbDataSet;
            // 
            // fSummerDbDataSet
            // 
            this.fSummerDbDataSet.DataSetName = "FSummerDbDataSet";
            this.fSummerDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAvailableMovies
            // 
            this.lblAvailableMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableMovies.Location = new System.Drawing.Point(567, -4);
            this.lblAvailableMovies.Name = "lblAvailableMovies";
            this.lblAvailableMovies.Size = new System.Drawing.Size(214, 25);
            this.lblAvailableMovies.TabIndex = 0;
            this.lblAvailableMovies.Text = "Available Movies";
            this.lblAvailableMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.lbllblReleaseDateDetails);
            this.panel4.Controls.Add(this.lblReleaseDate);
            this.panel4.Controls.Add(this.lblRatingDetails);
            this.panel4.Controls.Add(this.lblSMDRating);
            this.panel4.Controls.Add(this.lblGenreDetails);
            this.panel4.Controls.Add(this.lblSMDGenre);
            this.panel4.Controls.Add(this.lblMovieTitleDetails);
            this.panel4.Controls.Add(this.lblMovieTitle);
            this.panel4.Controls.Add(this.lblMovieIdDetails);
            this.panel4.Controls.Add(this.lblMovieId);
            this.panel4.Controls.Add(this.lblSelectedMovieDetails);
            this.panel4.Controls.Add(this.picSMDPoster);
            this.panel4.Controls.Add(this.btnBookTicket);
            this.panel4.Controls.Add(this.txtTotalPrice);
            this.panel4.Controls.Add(this.nudNumberOfTickets);
            this.panel4.Controls.Add(this.cmbShowTime);
            this.panel4.Controls.Add(this.lblTotalPrice);
            this.panel4.Controls.Add(this.lblBookYourTicket);
            this.panel4.Controls.Add(this.lblNumberOfTickets);
            this.panel4.Controls.Add(this.lblShowTime);
            this.panel4.Controls.Add(this.lblSeatsInfo);
            this.panel4.Location = new System.Drawing.Point(0, 623);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1455, 343);
            this.panel4.TabIndex = 9;
            // 
            // lbllblReleaseDateDetails
            // 
            this.lbllblReleaseDateDetails.AutoSize = true;
            this.lbllblReleaseDateDetails.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblReleaseDateDetails.Location = new System.Drawing.Point(199, 283);
            this.lbllblReleaseDateDetails.Name = "lbllblReleaseDateDetails";
            this.lbllblReleaseDateDetails.Size = new System.Drawing.Size(120, 27);
            this.lbllblReleaseDateDetails.TabIndex = 29;
            this.lbllblReleaseDateDetails.Text = "18 Jul 2026";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(27, 283);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(146, 27);
            this.lblReleaseDate.TabIndex = 28;
            this.lblReleaseDate.Text = "Release Date :";
            // 
            // lblRatingDetails
            // 
            this.lblRatingDetails.AutoSize = true;
            this.lblRatingDetails.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingDetails.Location = new System.Drawing.Point(179, 236);
            this.lblRatingDetails.Name = "lblRatingDetails";
            this.lblRatingDetails.Size = new System.Drawing.Size(39, 27);
            this.lblRatingDetails.TabIndex = 27;
            this.lblRatingDetails.Text = "8.8";
            // 
            // lblSMDRating
            // 
            this.lblSMDRating.AutoSize = true;
            this.lblSMDRating.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMDRating.Location = new System.Drawing.Point(27, 236);
            this.lblSMDRating.Name = "lblSMDRating";
            this.lblSMDRating.Size = new System.Drawing.Size(89, 27);
            this.lblSMDRating.TabIndex = 26;
            this.lblSMDRating.Text = "Rating : ";
            // 
            // lblGenreDetails
            // 
            this.lblGenreDetails.AutoSize = true;
            this.lblGenreDetails.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreDetails.Location = new System.Drawing.Point(179, 187);
            this.lblGenreDetails.Name = "lblGenreDetails";
            this.lblGenreDetails.Size = new System.Drawing.Size(69, 27);
            this.lblGenreDetails.TabIndex = 25;
            this.lblGenreDetails.Text = "Sci-Fri";
            // 
            // lblSMDGenre
            // 
            this.lblSMDGenre.AutoSize = true;
            this.lblSMDGenre.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMDGenre.Location = new System.Drawing.Point(27, 187);
            this.lblSMDGenre.Name = "lblSMDGenre";
            this.lblSMDGenre.Size = new System.Drawing.Size(80, 27);
            this.lblSMDGenre.TabIndex = 24;
            this.lblSMDGenre.Text = "Genre :";
            // 
            // lblMovieTitleDetails
            // 
            this.lblMovieTitleDetails.AutoSize = true;
            this.lblMovieTitleDetails.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitleDetails.Location = new System.Drawing.Point(179, 145);
            this.lblMovieTitleDetails.Name = "lblMovieTitleDetails";
            this.lblMovieTitleDetails.Size = new System.Drawing.Size(91, 27);
            this.lblMovieTitleDetails.TabIndex = 23;
            this.lblMovieTitleDetails.Text = "Inception";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(27, 145);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(124, 27);
            this.lblMovieTitle.TabIndex = 22;
            this.lblMovieTitle.Text = "Movie Title :";
            // 
            // lblMovieIdDetails
            // 
            this.lblMovieIdDetails.AutoSize = true;
            this.lblMovieIdDetails.Location = new System.Drawing.Point(179, 97);
            this.lblMovieIdDetails.Name = "lblMovieIdDetails";
            this.lblMovieIdDetails.Size = new System.Drawing.Size(66, 25);
            this.lblMovieIdDetails.TabIndex = 21;
            this.lblMovieIdDetails.Text = "M001";
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieId.Location = new System.Drawing.Point(27, 90);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(103, 27);
            this.lblMovieId.TabIndex = 20;
            this.lblMovieId.Text = "Movie Id :";
            // 
            // lblSelectedMovieDetails
            // 
            this.lblSelectedMovieDetails.AutoSize = true;
            this.lblSelectedMovieDetails.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedMovieDetails.Location = new System.Drawing.Point(12, 36);
            this.lblSelectedMovieDetails.Name = "lblSelectedMovieDetails";
            this.lblSelectedMovieDetails.Size = new System.Drawing.Size(255, 27);
            this.lblSelectedMovieDetails.TabIndex = 19;
            this.lblSelectedMovieDetails.Text = "Selected Movie Details :";
            // 
            // picSMDPoster
            // 
            this.picSMDPoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picSMDPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSMDPoster.Location = new System.Drawing.Point(406, 67);
            this.picSMDPoster.Name = "picSMDPoster";
            this.picSMDPoster.Size = new System.Drawing.Size(184, 241);
            this.picSMDPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSMDPoster.TabIndex = 30;
            this.picSMDPoster.TabStop = false;
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBookTicket.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTicket.Location = new System.Drawing.Point(1114, 225);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(172, 54);
            this.btnBookTicket.TabIndex = 17;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(1213, 169);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(176, 31);
            this.txtTotalPrice.TabIndex = 16;
            this.txtTotalPrice.Text = "1000 Bdt";
            // 
            // nudNumberOfTickets
            // 
            this.nudNumberOfTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumberOfTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudNumberOfTickets.Location = new System.Drawing.Point(1213, 117);
            this.nudNumberOfTickets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfTickets.Name = "nudNumberOfTickets";
            this.nudNumberOfTickets.Size = new System.Drawing.Size(176, 31);
            this.nudNumberOfTickets.TabIndex = 15;
            this.nudNumberOfTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfTickets.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cmbShowTime
            // 
            this.cmbShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShowTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowTime.FormattingEnabled = true;
            this.cmbShowTime.Location = new System.Drawing.Point(1213, 58);
            this.cmbShowTime.Name = "cmbShowTime";
            this.cmbShowTime.Size = new System.Drawing.Size(176, 33);
            this.cmbShowTime.TabIndex = 14;
            this.cmbShowTime.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(954, 169);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(122, 27);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // lblBookYourTicket
            // 
            this.lblBookYourTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookYourTicket.AutoSize = true;
            this.lblBookYourTicket.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookYourTicket.Location = new System.Drawing.Point(913, 11);
            this.lblBookYourTicket.Name = "lblBookYourTicket";
            this.lblBookYourTicket.Size = new System.Drawing.Size(183, 27);
            this.lblBookYourTicket.TabIndex = 1;
            this.lblBookYourTicket.Text = "Book Your Ticket";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTickets.Location = new System.Drawing.Point(954, 117);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(190, 27);
            this.lblNumberOfTickets.TabIndex = 12;
            this.lblNumberOfTickets.Text = "Number of tickets  :";
            // 
            // lblShowTime
            // 
            this.lblShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.Location = new System.Drawing.Point(954, 66);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(128, 27);
            this.lblShowTime.TabIndex = 11;
            this.lblShowTime.Text = "Show Time :";
            // 
            // lblSeatsInfo
            // 
            this.lblSeatsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeatsInfo.AutoSize = true;
            this.lblSeatsInfo.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatsInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblSeatsInfo.Location = new System.Drawing.Point(954, 297);
            this.lblSeatsInfo.Name = "lblSeatsInfo";
            this.lblSeatsInfo.Size = new System.Drawing.Size(180, 27);
            this.lblSeatsInfo.TabIndex = 18;
            this.lblSeatsInfo.Text = "Available Seats : -";
            this.lblSeatsInfo.Click += new System.EventHandler(this.lblSeatsInfo_Click);
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Controls.Add(this.lblEnjoyYourFvtMovie);
            this.panel5.Controls.Add(this.lblWelcomeUser);
            this.panel5.Controls.Add(this.lblUserDb);
            this.panel5.Controls.Add(this.lblTitle);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1455, 135);
            this.panel5.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1314, 37);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 71);
            this.btnLogout.TabIndex = 205;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblEnjoyYourFvtMovie
            // 
            this.lblEnjoyYourFvtMovie.AutoSize = true;
            this.lblEnjoyYourFvtMovie.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnjoyYourFvtMovie.Location = new System.Drawing.Point(11, 60);
            this.lblEnjoyYourFvtMovie.Name = "lblEnjoyYourFvtMovie";
            this.lblEnjoyYourFvtMovie.Size = new System.Drawing.Size(257, 27);
            this.lblEnjoyYourFvtMovie.TabIndex = 204;
            this.lblEnjoyYourFvtMovie.Text = "Enjoy your favourite movie ";
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(11, 31);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(181, 29);
            this.lblWelcomeUser.TabIndex = 203;
            this.lblWelcomeUser.Text = "Welcome,User !";
            // 
            // lblUserDb
            // 
            this.lblUserDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDb.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDb.Location = new System.Drawing.Point(731, 73);
            this.lblUserDb.Name = "lblUserDb";
            this.lblUserDb.Size = new System.Drawing.Size(170, 49);
            this.lblUserDb.TabIndex = 202;
            this.lblUserDb.Text = "User DashBoard";
            this.lblUserDb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(503, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(615, 59);
            this.lblTitle.TabIndex = 201;
            this.lblTitle.Text = "Theater Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1498, 994);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormUser";
            this.Text = "User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSummerDbDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSMDPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTickets)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbRatings;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cmbAllGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtEnterMovieName;
        private System.Windows.Forms.Label lblSearchMovieByTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAvailableMovies;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbShowTime;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblBookYourTicket;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblSeatsInfo;
        private System.Windows.Forms.NumericUpDown nudNumberOfTickets;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DataGridView dgvAvailableMovies;
        private FSummerDbDataSet fSummerDbDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private FSummerDbDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblEnjoyYourFvtMovie;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Label lblUserDb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbllblReleaseDateDetails;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRatingDetails;
        private System.Windows.Forms.Label lblSMDRating;
        private System.Windows.Forms.Label lblGenreDetails;
        private System.Windows.Forms.Label lblSMDGenre;
        private System.Windows.Forms.Label lblMovieTitleDetails;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblMovieIdDetails;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.Label lblSelectedMovieDetails;
        private System.Windows.Forms.PictureBox picSMDPoster;
    }
}