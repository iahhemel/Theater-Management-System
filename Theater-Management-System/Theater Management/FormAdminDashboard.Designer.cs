namespace Theater_Management
{
    partial class FormAdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosterPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtBoxOffice = new System.Windows.Forms.TextBox();
            this.lblBoxOffice = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMId = new System.Windows.Forms.TextBox();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.lblPosterCaption = new System.Windows.Forms.Label();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.btnUploadPoster = new System.Windows.Forms.Button();
            this.lblPosterHint = new System.Windows.Forms.Label();
            this.openFileDialogPoster = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.tabShows = new System.Windows.Forms.TabPage();
            this.pnlShowGrid = new System.Windows.Forms.Panel();
            this.dgvShows = new System.Windows.Forms.DataGridView();
            this.colShowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowMovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowMovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowTotalSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShowForm = new System.Windows.Forms.Panel();
            this.lblShowStatus = new System.Windows.Forms.Label();
            this.btnRefreshShow = new System.Windows.Forms.Button();
            this.btnClearShow = new System.Windows.Forms.Button();
            this.btnDeleteShow = new System.Windows.Forms.Button();
            this.btnUpdateShow = new System.Windows.Forms.Button();
            this.numShowSeats = new System.Windows.Forms.NumericUpDown();
            this.lblShowSeats = new System.Windows.Forms.Label();
            this.cmbShowTime = new System.Windows.Forms.ComboBox();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.cmbShowMovie = new System.Windows.Forms.ComboBox();
            this.lblShowMovie = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.pnlUserGrid = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUserForm = new System.Windows.Forms.Panel();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.tabShows.SuspendLayout();
            this.pnlShowGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).BeginInit();
            this.pnlShowForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShowSeats)).BeginInit();
            this.tabUsers.SuspendLayout();
            this.pnlUserGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlUserForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(6, 445);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1762, 436);
            this.panel1.TabIndex = 0;
            // 
            // dgvMovie
            // 
            this.dgvMovie.AllowUserToAddRows = false;
            this.dgvMovie.AllowUserToDeleteRows = false;
            this.dgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovie.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.IMDB,
            this.Income,
            this.ReleaseDate,
            this.Genre,
            this.colPosterPath});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovie.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovie.Location = new System.Drawing.Point(0, 0);
            this.dgvMovie.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.ReadOnly = true;
            this.dgvMovie.RowHeadersWidth = 51;
            this.dgvMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovie.Size = new System.Drawing.Size(1762, 436);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellContentClick);
            this.dgvMovie.DoubleClick += new System.EventHandler(this.dgvMovie_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 179.8779F;
            this.Id.HeaderText = "Movie ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 66.77781F;
            this.Title.HeaderText = "Movie Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // IMDB
            // 
            this.IMDB.DataPropertyName = "IMDB";
            this.IMDB.FillWeight = 76.70847F;
            this.IMDB.HeaderText = "IMDB";
            this.IMDB.MinimumWidth = 6;
            this.IMDB.Name = "IMDB";
            this.IMDB.ReadOnly = true;
            // 
            // Income
            // 
            this.Income.DataPropertyName = "Income";
            this.Income.FillWeight = 84.18117F;
            this.Income.HeaderText = "Box Office";
            this.Income.MinimumWidth = 6;
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            this.Income.ToolTipText = "Income";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.FillWeight = 92.39635F;
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.FillWeight = 100.0585F;
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // colPosterPath
            // 
            this.colPosterPath.DataPropertyName = "PosterPath";
            this.colPosterPath.HeaderText = "PosterPath";
            this.colPosterPath.MinimumWidth = 6;
            this.colPosterPath.Name = "colPosterPath";
            this.colPosterPath.ReadOnly = true;
            this.colPosterPath.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtAutoSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1762, 439);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(278, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 32);
            this.label8.TabIndex = 134;
            this.label8.Text = "auto search";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(6, 8);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(256, 36);
            this.txtAutoSearch.TabIndex = 3;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(936, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 131);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.cmbGenre);
            this.panel3.Controls.Add(this.dtpReleaseDate);
            this.panel3.Controls.Add(this.lblGenre);
            this.panel3.Controls.Add(this.lblReleaseDate);
            this.panel3.Controls.Add(this.txtBoxOffice);
            this.panel3.Controls.Add(this.lblBoxOffice);
            this.panel3.Controls.Add(this.txtRating);
            this.panel3.Controls.Add(this.lblRating);
            this.panel3.Controls.Add(this.txtMovieName);
            this.panel3.Controls.Add(this.lblMovieName);
            this.panel3.Controls.Add(this.txtMId);
            this.panel3.Controls.Add(this.lblMovieId);
            this.panel3.Controls.Add(this.lblPosterCaption);
            this.panel3.Controls.Add(this.picPoster);
            this.panel3.Controls.Add(this.btnUploadPoster);
            this.panel3.Controls.Add(this.lblPosterHint);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1762, 440);
            this.panel3.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1570, 8);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 47);
            this.btnLogout.TabIndex = 200;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(936, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 133);
            this.btnDelete.TabIndex = 144;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Info;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(774, 175);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 133);
            this.btnClear.TabIndex = 143;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(774, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 133);
            this.btnSave.TabIndex = 142;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "action",
            "adventure",
            "comedy",
            "drama",
            "horror",
            "thriller"});
            this.cmbGenre.Location = new System.Drawing.Point(224, 273);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(6);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(264, 37);
            this.cmbGenre.TabIndex = 140;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(224, 223);
            this.dtpReleaseDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(264, 36);
            this.dtpReleaseDate.TabIndex = 139;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(18, 275);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(92, 37);
            this.lblGenre.TabIndex = 138;
            this.lblGenre.Text = "Genre";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(18, 225);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(186, 37);
            this.lblReleaseDate.TabIndex = 137;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // txtBoxOffice
            // 
            this.txtBoxOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBoxOffice.Location = new System.Drawing.Point(224, 173);
            this.txtBoxOffice.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxOffice.Name = "txtBoxOffice";
            this.txtBoxOffice.Size = new System.Drawing.Size(264, 36);
            this.txtBoxOffice.TabIndex = 136;
            // 
            // lblBoxOffice
            // 
            this.lblBoxOffice.AutoSize = true;
            this.lblBoxOffice.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxOffice.Location = new System.Drawing.Point(18, 175);
            this.lblBoxOffice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBoxOffice.Name = "lblBoxOffice";
            this.lblBoxOffice.Size = new System.Drawing.Size(146, 37);
            this.lblBoxOffice.TabIndex = 135;
            this.lblBoxOffice.Text = "Box Office";
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRating.Location = new System.Drawing.Point(224, 123);
            this.txtRating.Margin = new System.Windows.Forms.Padding(6);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(264, 36);
            this.txtRating.TabIndex = 134;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(18, 125);
            this.lblRating.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(96, 37);
            this.lblRating.TabIndex = 133;
            this.lblRating.Text = "Rating";
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMovieName.Location = new System.Drawing.Point(224, 73);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(264, 36);
            this.txtMovieName.TabIndex = 132;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(18, 75);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(172, 37);
            this.lblMovieName.TabIndex = 131;
            this.lblMovieName.Text = "Movie Name";
            // 
            // txtMId
            // 
            this.txtMId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMId.Location = new System.Drawing.Point(224, 23);
            this.txtMId.Margin = new System.Windows.Forms.Padding(6);
            this.txtMId.Name = "txtMId";
            this.txtMId.Size = new System.Drawing.Size(264, 36);
            this.txtMId.TabIndex = 130;
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieId.Location = new System.Drawing.Point(18, 25);
            this.lblMovieId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(128, 37);
            this.lblMovieId.TabIndex = 129;
            this.lblMovieId.Text = "Movie ID";
            // 
            // lblPosterCaption
            // 
            this.lblPosterCaption.AutoSize = true;
            this.lblPosterCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosterCaption.Location = new System.Drawing.Point(518, 12);
            this.lblPosterCaption.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPosterCaption.Name = "lblPosterCaption";
            this.lblPosterCaption.Size = new System.Drawing.Size(99, 33);
            this.lblPosterCaption.TabIndex = 145;
            this.lblPosterCaption.Text = "Poster";
            // 
            // picPoster
            // 
            this.picPoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPoster.Location = new System.Drawing.Point(518, 52);
            this.picPoster.Margin = new System.Windows.Forms.Padding(6);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(224, 218);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 146;
            this.picPoster.TabStop = false;
            // 
            // btnUploadPoster
            // 
            this.btnUploadPoster.BackColor = System.Drawing.SystemColors.Info;
            this.btnUploadPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPoster.Location = new System.Drawing.Point(518, 280);
            this.btnUploadPoster.Margin = new System.Windows.Forms.Padding(6);
            this.btnUploadPoster.Name = "btnUploadPoster";
            this.btnUploadPoster.Size = new System.Drawing.Size(225, 44);
            this.btnUploadPoster.TabIndex = 147;
            this.btnUploadPoster.Text = "Upload Poster...";
            this.btnUploadPoster.UseVisualStyleBackColor = false;
            this.btnUploadPoster.Click += new System.EventHandler(this.btnUploadPoster_Click);
            // 
            // lblPosterHint
            // 
            this.lblPosterHint.AutoEllipsis = true;
            this.lblPosterHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosterHint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPosterHint.Location = new System.Drawing.Point(518, 328);
            this.lblPosterHint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPosterHint.Name = "lblPosterHint";
            this.lblPosterHint.Size = new System.Drawing.Size(225, 25);
            this.lblPosterHint.TabIndex = 148;
            this.lblPosterHint.Text = "No poster selected";
            // 
            // openFileDialogPoster
            // 
            this.openFileDialogPoster.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            this.openFileDialogPoster.Title = "Select Movie Poster";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabMovies);
            this.tabControlMain.Controls.Add(this.tabShows);
            this.tabControlMain.Controls.Add(this.tabUsers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(6);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1790, 939);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.panel3);
            this.tabMovies.Controls.Add(this.panel2);
            this.tabMovies.Controls.Add(this.panel1);
            this.tabMovies.Location = new System.Drawing.Point(8, 44);
            this.tabMovies.Margin = new System.Windows.Forms.Padding(6);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(6);
            this.tabMovies.Size = new System.Drawing.Size(1774, 887);
            this.tabMovies.TabIndex = 0;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // tabShows
            // 
            this.tabShows.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabShows.Controls.Add(this.pnlShowGrid);
            this.tabShows.Controls.Add(this.pnlShowForm);
            this.tabShows.ForeColor = System.Drawing.Color.Black;
            this.tabShows.Location = new System.Drawing.Point(8, 44);
            this.tabShows.Margin = new System.Windows.Forms.Padding(6);
            this.tabShows.Name = "tabShows";
            this.tabShows.Padding = new System.Windows.Forms.Padding(6);
            this.tabShows.Size = new System.Drawing.Size(1774, 887);
            this.tabShows.TabIndex = 2;
            this.tabShows.Text = "Show Times";
            // 
            // pnlShowGrid
            // 
            this.pnlShowGrid.Controls.Add(this.dgvShows);
            this.pnlShowGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowGrid.Location = new System.Drawing.Point(6, 358);
            this.pnlShowGrid.Margin = new System.Windows.Forms.Padding(6);
            this.pnlShowGrid.Name = "pnlShowGrid";
            this.pnlShowGrid.Size = new System.Drawing.Size(1762, 523);
            this.pnlShowGrid.TabIndex = 1;
            // 
            // dgvShows
            // 
            this.dgvShows.AllowUserToAddRows = false;
            this.dgvShows.AllowUserToDeleteRows = false;
            this.dgvShows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShows.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShowId,
            this.colShowMovieId,
            this.colShowMovieTitle,
            this.colShowTime,
            this.colShowTotalSeats,
            this.colShowBooked,
            this.colShowAvailable});
            this.dgvShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShows.Location = new System.Drawing.Point(0, 0);
            this.dgvShows.Margin = new System.Windows.Forms.Padding(6);
            this.dgvShows.Name = "dgvShows";
            this.dgvShows.ReadOnly = true;
            this.dgvShows.RowHeadersWidth = 51;
            this.dgvShows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShows.Size = new System.Drawing.Size(1762, 523);
            this.dgvShows.TabIndex = 0;
            this.dgvShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShows_CellContentClick);
            this.dgvShows.DoubleClick += new System.EventHandler(this.dgvShows_DoubleClick);
            // 
            // colShowId
            // 
            this.colShowId.DataPropertyName = "ShowId";
            this.colShowId.HeaderText = "Show Id";
            this.colShowId.MinimumWidth = 6;
            this.colShowId.Name = "colShowId";
            this.colShowId.ReadOnly = true;
            this.colShowId.Visible = false;
            // 
            // colShowMovieId
            // 
            this.colShowMovieId.DataPropertyName = "MovieId";
            this.colShowMovieId.HeaderText = "Movie ID";
            this.colShowMovieId.MinimumWidth = 6;
            this.colShowMovieId.Name = "colShowMovieId";
            this.colShowMovieId.ReadOnly = true;
            // 
            // colShowMovieTitle
            // 
            this.colShowMovieTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShowMovieTitle.DataPropertyName = "MovieTitle";
            this.colShowMovieTitle.HeaderText = "Movie Title";
            this.colShowMovieTitle.MinimumWidth = 6;
            this.colShowMovieTitle.Name = "colShowMovieTitle";
            this.colShowMovieTitle.ReadOnly = true;
            // 
            // colShowTime
            // 
            this.colShowTime.DataPropertyName = "ShowTime";
            this.colShowTime.HeaderText = "Show Time";
            this.colShowTime.MinimumWidth = 6;
            this.colShowTime.Name = "colShowTime";
            this.colShowTime.ReadOnly = true;
            // 
            // colShowTotalSeats
            // 
            this.colShowTotalSeats.DataPropertyName = "TotalSeats";
            this.colShowTotalSeats.HeaderText = "Total Seats";
            this.colShowTotalSeats.MinimumWidth = 6;
            this.colShowTotalSeats.Name = "colShowTotalSeats";
            this.colShowTotalSeats.ReadOnly = true;
            // 
            // colShowBooked
            // 
            this.colShowBooked.DataPropertyName = "BookedSeats";
            this.colShowBooked.HeaderText = "Booked";
            this.colShowBooked.MinimumWidth = 6;
            this.colShowBooked.Name = "colShowBooked";
            this.colShowBooked.ReadOnly = true;
            // 
            // colShowAvailable
            // 
            this.colShowAvailable.DataPropertyName = "Available";
            this.colShowAvailable.HeaderText = "Available";
            this.colShowAvailable.MinimumWidth = 6;
            this.colShowAvailable.Name = "colShowAvailable";
            this.colShowAvailable.ReadOnly = true;
            // 
            // pnlShowForm
            // 
            this.pnlShowForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlShowForm.Controls.Add(this.lblShowStatus);
            this.pnlShowForm.Controls.Add(this.btnRefreshShow);
            this.pnlShowForm.Controls.Add(this.btnClearShow);
            this.pnlShowForm.Controls.Add(this.btnDeleteShow);
            this.pnlShowForm.Controls.Add(this.btnUpdateShow);
            this.pnlShowForm.Controls.Add(this.numShowSeats);
            this.pnlShowForm.Controls.Add(this.lblShowSeats);
            this.pnlShowForm.Controls.Add(this.cmbShowTime);
            this.pnlShowForm.Controls.Add(this.lblShowTime);
            this.pnlShowForm.Controls.Add(this.cmbShowMovie);
            this.pnlShowForm.Controls.Add(this.lblShowMovie);
            this.pnlShowForm.Location = new System.Drawing.Point(6, 6);
            this.pnlShowForm.Margin = new System.Windows.Forms.Padding(6);
            this.pnlShowForm.Name = "pnlShowForm";
            this.pnlShowForm.Size = new System.Drawing.Size(1762, 267);
            this.pnlShowForm.TabIndex = 0;
            // 
            // lblShowStatus
            // 
            this.lblShowStatus.AutoSize = true;
            this.lblShowStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowStatus.Location = new System.Drawing.Point(18, 227);
            this.lblShowStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowStatus.Name = "lblShowStatus";
            this.lblShowStatus.Size = new System.Drawing.Size(235, 29);
            this.lblShowStatus.TabIndex = 7;
            this.lblShowStatus.Text = "Select a show to edit";
            // 
            // btnRefreshShow
            // 
            this.btnRefreshShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefreshShow.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshShow.Location = new System.Drawing.Point(936, 175);
            this.btnRefreshShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefreshShow.Name = "btnRefreshShow";
            this.btnRefreshShow.Size = new System.Drawing.Size(210, 69);
            this.btnRefreshShow.TabIndex = 6;
            this.btnRefreshShow.Text = "Refresh";
            this.btnRefreshShow.UseVisualStyleBackColor = false;
            this.btnRefreshShow.Click += new System.EventHandler(this.btnRefreshShow_Click);
            // 
            // btnClearShow
            // 
            this.btnClearShow.BackColor = System.Drawing.SystemColors.Info;
            this.btnClearShow.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearShow.Location = new System.Drawing.Point(714, 175);
            this.btnClearShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearShow.Name = "btnClearShow";
            this.btnClearShow.Size = new System.Drawing.Size(210, 69);
            this.btnClearShow.TabIndex = 5;
            this.btnClearShow.Text = "Clear";
            this.btnClearShow.UseVisualStyleBackColor = false;
            this.btnClearShow.Click += new System.EventHandler(this.btnClearShow_Click);
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteShow.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShow.ForeColor = System.Drawing.Color.White;
            this.btnDeleteShow.Location = new System.Drawing.Point(936, 23);
            this.btnDeleteShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(210, 133);
            this.btnDeleteShow.TabIndex = 4;
            this.btnDeleteShow.Text = "Delete Show";
            this.btnDeleteShow.UseVisualStyleBackColor = false;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // btnUpdateShow
            // 
            this.btnUpdateShow.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdateShow.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateShow.Location = new System.Drawing.Point(714, 23);
            this.btnUpdateShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateShow.Name = "btnUpdateShow";
            this.btnUpdateShow.Size = new System.Drawing.Size(210, 133);
            this.btnUpdateShow.TabIndex = 3;
            this.btnUpdateShow.Text = "Add/Update Show";
            this.btnUpdateShow.UseVisualStyleBackColor = false;
            this.btnUpdateShow.Click += new System.EventHandler(this.btnSaveShow_Click);
            // 
            // numShowSeats
            // 
            this.numShowSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.numShowSeats.Location = new System.Drawing.Point(224, 181);
            this.numShowSeats.Margin = new System.Windows.Forms.Padding(6);
            this.numShowSeats.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numShowSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numShowSeats.Name = "numShowSeats";
            this.numShowSeats.Size = new System.Drawing.Size(266, 36);
            this.numShowSeats.TabIndex = 2;
            this.numShowSeats.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblShowSeats
            // 
            this.lblShowSeats.AutoSize = true;
            this.lblShowSeats.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSeats.Location = new System.Drawing.Point(18, 175);
            this.lblShowSeats.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowSeats.Name = "lblShowSeats";
            this.lblShowSeats.Size = new System.Drawing.Size(159, 37);
            this.lblShowSeats.TabIndex = 137;
            this.lblShowSeats.Text = "Total Seats";
            // 
            // cmbShowTime
            // 
            this.cmbShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbShowTime.FormattingEnabled = true;
            this.cmbShowTime.Items.AddRange(new object[] {
            "10:00 AM",
            "1:00 PM",
            "4:00 PM",
            "7:00 PM",
            "10:00 PM"});
            this.cmbShowTime.Location = new System.Drawing.Point(224, 127);
            this.cmbShowTime.Margin = new System.Windows.Forms.Padding(6);
            this.cmbShowTime.Name = "cmbShowTime";
            this.cmbShowTime.Size = new System.Drawing.Size(264, 37);
            this.cmbShowTime.TabIndex = 1;
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.Location = new System.Drawing.Point(18, 125);
            this.lblShowTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(156, 37);
            this.lblShowTime.TabIndex = 133;
            this.lblShowTime.Text = "Show Time";
            // 
            // cmbShowMovie
            // 
            this.cmbShowMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbShowMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowMovie.FormattingEnabled = true;
            this.cmbShowMovie.Location = new System.Drawing.Point(224, 28);
            this.cmbShowMovie.Margin = new System.Windows.Forms.Padding(6);
            this.cmbShowMovie.Name = "cmbShowMovie";
            this.cmbShowMovie.Size = new System.Drawing.Size(264, 37);
            this.cmbShowMovie.TabIndex = 0;
            // 
            // lblShowMovie
            // 
            this.lblShowMovie.AutoSize = true;
            this.lblShowMovie.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMovie.Location = new System.Drawing.Point(18, 25);
            this.lblShowMovie.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowMovie.Name = "lblShowMovie";
            this.lblShowMovie.Size = new System.Drawing.Size(89, 37);
            this.lblShowMovie.TabIndex = 129;
            this.lblShowMovie.Text = "Movie";
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabUsers.Controls.Add(this.pnlUserGrid);
            this.tabUsers.Controls.Add(this.pnlUserForm);
            this.tabUsers.Location = new System.Drawing.Point(8, 44);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(6);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(6);
            this.tabUsers.Size = new System.Drawing.Size(1774, 887);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "User Management";
            // 
            // pnlUserGrid
            // 
            this.pnlUserGrid.Controls.Add(this.dgvUsers);
            this.pnlUserGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserGrid.Location = new System.Drawing.Point(6, 358);
            this.pnlUserGrid.Margin = new System.Windows.Forms.Padding(6);
            this.pnlUserGrid.Name = "pnlUserGrid";
            this.pnlUserGrid.Size = new System.Drawing.Size(1762, 523);
            this.pnlUserGrid.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserId,
            this.colUserName,
            this.colUserRole});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(6);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1762, 523);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.DoubleClick += new System.EventHandler(this.dgvUsers_DoubleClick);
            // 
            // colUserId
            // 
            this.colUserId.DataPropertyName = "Id";
            this.colUserId.HeaderText = "User ID";
            this.colUserId.MinimumWidth = 6;
            this.colUserId.Name = "colUserId";
            this.colUserId.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserName.DataPropertyName = "Name";
            this.colUserName.HeaderText = "Name";
            this.colUserName.MinimumWidth = 6;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colUserRole
            // 
            this.colUserRole.DataPropertyName = "Role";
            this.colUserRole.HeaderText = "Role";
            this.colUserRole.MinimumWidth = 6;
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.ReadOnly = true;
            // 
            // pnlUserForm
            // 
            this.pnlUserForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlUserForm.Controls.Add(this.btnRemoveUser);
            this.pnlUserForm.Controls.Add(this.btnClearUser);
            this.pnlUserForm.Controls.Add(this.btnAddUser);
            this.pnlUserForm.Controls.Add(this.cmbUserRole);
            this.pnlUserForm.Controls.Add(this.lblUserRole);
            this.pnlUserForm.Controls.Add(this.txtUserPassword);
            this.pnlUserForm.Controls.Add(this.lblUserPassword);
            this.pnlUserForm.Controls.Add(this.txtUserName);
            this.pnlUserForm.Controls.Add(this.lblUserName);
            this.pnlUserForm.Controls.Add(this.txtUserId);
            this.pnlUserForm.Controls.Add(this.lblUserId);
            this.pnlUserForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserForm.Location = new System.Drawing.Point(6, 6);
            this.pnlUserForm.Margin = new System.Windows.Forms.Padding(6);
            this.pnlUserForm.Name = "pnlUserForm";
            this.pnlUserForm.Size = new System.Drawing.Size(1762, 267);
            this.pnlUserForm.TabIndex = 0;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveUser.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.Location = new System.Drawing.Point(936, 23);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(210, 94);
            this.btnRemoveUser.TabIndex = 5;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnClearUser
            // 
            this.btnClearUser.BackColor = System.Drawing.SystemColors.Info;
            this.btnClearUser.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUser.Location = new System.Drawing.Point(936, 150);
            this.btnClearUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(210, 94);
            this.btnClearUser.TabIndex = 6;
            this.btnClearUser.Text = "Clear";
            this.btnClearUser.UseVisualStyleBackColor = false;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(714, 23);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(210, 220);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbUserRole.Location = new System.Drawing.Point(224, 177);
            this.cmbUserRole.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(264, 45);
            this.cmbUserRole.TabIndex = 3;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(18, 175);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(73, 37);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Role";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Location = new System.Drawing.Point(224, 123);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(264, 44);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.Location = new System.Drawing.Point(18, 125);
            this.lblUserPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(137, 37);
            this.lblUserPassword.TabIndex = 133;
            this.lblUserPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(224, 73);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(264, 44);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(18, 75);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(144, 37);
            this.lblUserName.TabIndex = 131;
            this.lblUserName.Text = "Full Name";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserId.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(224, 23);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(264, 44);
            this.txtUserId.TabIndex = 0;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(18, 25);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(114, 37);
            this.lblUserId.TabIndex = 129;
            this.lblUserId.Text = "User ID";
            // 
            // FormAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1790, 939);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabShows.ResumeLayout(false);
            this.pnlShowGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).EndInit();
            this.pnlShowForm.ResumeLayout(false);
            this.pnlShowForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShowSeats)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.pnlUserGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlUserForm.ResumeLayout(false);
            this.pnlUserForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtBoxOffice;
        private System.Windows.Forms.Label lblBoxOffice;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMId;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosterPath;
        private System.Windows.Forms.Label lblPosterCaption;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Button btnUploadPoster;
        private System.Windows.Forms.Label lblPosterHint;
        private System.Windows.Forms.OpenFileDialog openFileDialogPoster;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel pnlUserGrid;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserRole;
        private System.Windows.Forms.Panel pnlUserForm;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TabPage tabShows;
        private System.Windows.Forms.Panel pnlShowGrid;
        private System.Windows.Forms.DataGridView dgvShows;
        private System.Windows.Forms.Panel pnlShowForm;
        private System.Windows.Forms.Label lblShowStatus;
        private System.Windows.Forms.Button btnRefreshShow;
        private System.Windows.Forms.Button btnClearShow;
        private System.Windows.Forms.Button btnDeleteShow;
        private System.Windows.Forms.Button btnUpdateShow;
        private System.Windows.Forms.NumericUpDown numShowSeats;
        private System.Windows.Forms.Label lblShowSeats;
        private System.Windows.Forms.ComboBox cmbShowTime;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.ComboBox cmbShowMovie;
        private System.Windows.Forms.Label lblShowMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowMovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowMovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowTotalSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowBooked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowAvailable;
    }
}

