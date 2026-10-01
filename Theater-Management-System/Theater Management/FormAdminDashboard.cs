using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater_Management
{
    public partial class FormAdminDashboard : Form
    {
        private DataAccess Da { get; set; }
        private string AdminId { get; set; }
        private string AdminName { get; set; }

    
        private string PendingPosterSourcePath { get; set; }

        private static readonly string PosterFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PosterImages");

     
        private int? SelectedShowId { get; set; }

 
        public FormAdminDashboard() : this(null, "Admin")
        {
        }

        public FormAdminDashboard(string adminId, string adminName)
        {
            InitializeComponent();
            tabMovies.BackColor = Color.MediumSeaGreen;
            this.AdminId = adminId;
            this.AdminName = adminName;
            this.Text = "Admin Dashboard - " + adminName;

            try
            {
                this.Da = new DataAccess();
                this.PopulateGridView();
                this.PopulateUsersGridView();
                this.PopulateShowMovieCombo();
                this.PopulateShowsGridView();
                this.cmbUserRole.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not connect to the database.\n" + exc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void PopulateGridView(string sql = "select * from Movie;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = ds.Tables[0];
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Movie where Title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from Movie where Id = '" + this.txtMId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                string newPosterPath = this.SavePosterFileIfNeeded(this.txtMId.Text);

                if(dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Movie
                                set Title = '" + this.txtMovieName.Text + @"',
                                IMDB = " + this.txtRating.Text + @",
                                Income = " + this.txtBoxOffice.Text + @",
                                ReleaseDate = '" + this.dtpReleaseDate.Text + @"',
                                Genre = '" + this.cmbGenre.Text + "'";

                    if (newPosterPath != null)
                        sql += ", PosterPath = '" + newPosterPath.Replace("'", "''") + "'";

                    sql += " where Id = '" + this.txtMId.Text + "'; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    string posterSqlValue = newPosterPath != null ? "'" + newPosterPath.Replace("'", "''") + "'" : "NULL";
                    var sql = "insert into Movie (Id, Title, IMDB, Income, ReleaseDate, Genre, PosterPath) values('"
                                + this.txtMId.Text + "', '" + this.txtMovieName.Text + "', " + this.txtRating.Text + ", "
                                + this.txtBoxOffice.Text + ", '" + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text
                                + "', " + posterSqlValue + ")";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }               

                this.PopulateGridView();
                this.PopulateShowMovieCombo();
                this.ClearAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtMId.Clear();
            this.txtMovieName.Clear();
            this.txtRating.Clear();
            this.txtBoxOffice.Clear();
            this.dtpReleaseDate.Text = "";
            this.cmbGenre.SelectedIndex = -1;

            this.txtAutoSearch.Text = "";

            this.ClearPosterPreview();

            this.dgvMovie.ClearSelection();
        }

     

        private void btnUploadPoster_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogPoster.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                this.PendingPosterSourcePath = this.openFileDialogPoster.FileName;
                this.SetPosterPreviewImage(this.PendingPosterSourcePath);
                this.lblPosterHint.Text = Path.GetFileName(this.PendingPosterSourcePath);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not load the selected image.\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPosterPreviewImage(string filePath)
        {
            this.ClearPosterPreview();
            this.picPoster.Image = Image.FromFile(filePath);
        }

        private void ClearPosterPreview()
        {
            if (this.picPoster.Image != null)
            {
                var old = this.picPoster.Image;
                this.picPoster.Image = null;
                old.Dispose();
            }
        }


        private string SavePosterFileIfNeeded(string movieId)
        {
            if (string.IsNullOrEmpty(this.PendingPosterSourcePath))
                return null;

            if (!Directory.Exists(PosterFolder))
                Directory.CreateDirectory(PosterFolder);

            string ext = Path.GetExtension(this.PendingPosterSourcePath);
            string destPath = Path.Combine(PosterFolder, movieId + ext);
            File.Copy(this.PendingPosterSourcePath, destPath, true);

            return destPath;
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtMId.Text) || string.IsNullOrEmpty(this.txtMovieName.Text) ||
                string.IsNullOrEmpty(this.txtRating.Text) || string.IsNullOrEmpty(this.txtBoxOffice.Text) ||
                string.IsNullOrEmpty(this.cmbGenre.Text))
                return false;
            else
                return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.txtMId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please enter the ID of the movie to remove, or double-click a row to select it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var checkSql = "select Title from Movie where Id = @Id;";
                var existing = this.Da.ExecuteQueryTable(checkSql, new SqlParameter("@Id", id));

                if (existing.Rows.Count != 1)
                {
                    MessageBox.Show("No movie found with ID \"" + id + "\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var title = existing.Rows[0]["Title"].ToString();

                DialogResult res = MessageBox.Show(
                    "Are you sure to remove \"" + title + "\" (" + id + ")?\n\nThis will also remove all of its show times and any bookings made for it.",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                bool deleted = this.Da.DeleteMovieCascade(id);

                if (deleted)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data hasn't been removed properly");

                this.PopulateGridView();
                this.PopulateShowMovieCombo();
                this.PopulateShowsGridView();
                this.ClearAll();
            }
            catch (SqlException sqlExc)
            {
               
                MessageBox.Show("This movie could not be removed because it has related records (e.g. show times or bookings).\n" + sqlExc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.txtMId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please enter the ID of the movie to update, or double-click a row to select it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                decimal imdb, income;
                if (!decimal.TryParse(this.txtRating.Text.Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out imdb) ||
                    !decimal.TryParse(this.txtBoxOffice.Text.Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out income))
                {
                    MessageBox.Show("IMDB rating and Income must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var checkSql = "select Id from Movie where Id = @Id;";
                var existing = this.Da.ExecuteQueryTable(checkSql, new SqlParameter("@Id", id));

                if (existing.Rows.Count != 1)
                {
                    MessageBox.Show("No movie found with ID \"" + id + "\". Nothing to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

           
                string newPosterPath = this.SavePosterFileIfNeeded(id);

                var sql = @"update Movie
                            set Title = @Title,
                                IMDB = @IMDB,
                                Income = @Income,
                                ReleaseDate = @ReleaseDate,
                                Genre = @Genre";

                if (newPosterPath != null)
                    sql += ", PosterPath = @PosterPath";

                sql += " where Id = @Id;";

                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Title", this.txtMovieName.Text),
                    new SqlParameter("@IMDB", imdb),
                    new SqlParameter("@Income", income),
                    new SqlParameter("@ReleaseDate", this.dtpReleaseDate.Text),
                    new SqlParameter("@Genre", this.cmbGenre.Text),
                    new SqlParameter("@Id", id)
                };

                if (newPosterPath != null)
                    parameters.Add(new SqlParameter("@PosterPath", newPosterPath));

                int count = this.Da.ExecuteDMLQuery(sql, parameters.ToArray());

                if (count == 1)
                    MessageBox.Show("Data has been updated properly");
                else
                    MessageBox.Show("Data hasn't been updated properly");

                this.PopulateGridView();
                this.PopulateShowMovieCombo();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.dgvMovie.ClearSelection();
        }

        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            this.txtMId.Text = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
            this.txtMovieName.Text = this.dgvMovie.CurrentRow.Cells[1].Value.ToString();
            this.txtRating.Text = this.dgvMovie.CurrentRow.Cells["IMDB"].Value.ToString();
            this.txtBoxOffice.Text = this.dgvMovie.CurrentRow.Cells["Income"].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvMovie.CurrentRow.Cells[4].Value.ToString();
            this.cmbGenre.Text = this.dgvMovie.CurrentRow.Cells["Genre"].Value.ToString();

            // No new poster has been picked yet for this loaded movie - "Save"
            // will keep whichever poster is already on file unless the admin
            // clicks "Upload Poster..." to replace it.
            this.PendingPosterSourcePath = null;

            object posterVal = this.dgvMovie.CurrentRow.Cells["colPosterPath"].Value;
            string posterPath = (posterVal == null || posterVal == DBNull.Value) ? null : posterVal.ToString();

            if (!string.IsNullOrEmpty(posterPath) && File.Exists(posterPath))
            {
                try
                {
                    this.SetPosterPreviewImage(posterPath);
                    this.lblPosterHint.Text = "Current poster";
                }
                catch
                {
                    this.ClearPosterPreview();
                    this.lblPosterHint.Text = "Poster file could not be loaded";
                }
            }
            else
            {
                this.ClearPosterPreview();
                this.lblPosterHint.Text = "No poster set";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (this.Da != null)
                this.Da.Dispose();

      
            this.Close();
        }


        private void PopulateUsersGridView()
        {
            string sql = "SELECT Id, Name, Role FROM dbo.Users ORDER BY Id;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.DataSource = dt;
        }

        private bool IsUserFormValid()
        {
            if (string.IsNullOrWhiteSpace(this.txtUserId.Text) ||
                string.IsNullOrWhiteSpace(this.txtUserName.Text) ||
                string.IsNullOrWhiteSpace(this.txtUserPassword.Text) ||
                this.cmbUserRole.SelectedIndex == -1)
                return false;

            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsUserFormValid())
                {
                    MessageBox.Show("Please fill in User ID, Name, Password and Role.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string id = this.txtUserId.Text.Trim();

                var existing = this.Da.ExecuteQueryTable("SELECT Id FROM dbo.Users WHERE Id = @Id;", new SqlParameter("@Id", id));
                if (existing.Rows.Count > 0)
                {
                    MessageBox.Show("A user with this ID already exists. Please use a different ID.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "INSERT INTO dbo.Users (Id, Name, Password, Role) VALUES (@Id, @Name, @Password, @Role);";
                int count = this.Da.ExecuteDMLQuery(sql,
                    new SqlParameter("@Id", id),
                    new SqlParameter("@Name", this.txtUserName.Text.Trim()),
                    new SqlParameter("@Password", this.txtUserPassword.Text),
                    new SqlParameter("@Role", this.cmbUserRole.Text));

                if (count == 1)
                    MessageBox.Show("User has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User could not be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.PopulateUsersGridView();
                this.ClearUserForm();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUsers.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a user from the list first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string id = this.dgvUsers.CurrentRow.Cells["colUserId"].Value.ToString();
                string name = this.dgvUsers.CurrentRow.Cells["colUserName"].Value.ToString();

                if (string.Equals(id, this.AdminId, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("You cannot remove the account you are currently logged in with.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult res = MessageBox.Show("Are you sure you want to remove \"" + name + "\" (" + id + ")?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                string sql = "DELETE FROM dbo.Users WHERE Id = @Id;";
                int count = this.Da.ExecuteDMLQuery(sql, new SqlParameter("@Id", id));

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User could not be removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.PopulateUsersGridView();
                this.ClearUserForm();
            }
            catch (SqlException sqlExc)
            {
                // Most likely the user still has related Booking rows (foreign key constraint).
                MessageBox.Show("This user could not be removed because they have related records (e.g. bookings).\n" + sqlExc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            this.ClearUserForm();
        }

        private void ClearUserForm()
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtUserPassword.Clear();
            this.cmbUserRole.SelectedIndex = 0;
            this.dgvUsers.ClearSelection();
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvUsers.CurrentRow == null)
                return;

            this.txtUserId.Text = this.dgvUsers.CurrentRow.Cells["colUserId"].Value.ToString();
            this.txtUserName.Text = this.dgvUsers.CurrentRow.Cells["colUserName"].Value.ToString();
            this.txtUserPassword.Clear();
            this.cmbUserRole.Text = this.dgvUsers.CurrentRow.Cells["colUserRole"].Value.ToString();
        }

     

        private void PopulateShowMovieCombo()
        {
            string sql = "SELECT Id, Title FROM dbo.Movie ORDER BY Id;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

          
            dt.Columns.Add("Display", typeof(string));
            foreach (DataRow row in dt.Rows)
                row["Display"] = row["Id"].ToString() + " - " + row["Title"].ToString();

            string previouslySelected = this.cmbShowMovie.SelectedValue as string;

            this.cmbShowMovie.DataSource = dt;
            this.cmbShowMovie.DisplayMember = "Display";
            this.cmbShowMovie.ValueMember = "Id";

            if (!string.IsNullOrEmpty(previouslySelected))
                this.cmbShowMovie.SelectedValue = previouslySelected;
        }

        private void PopulateShowsGridView()
        {
            string sql = @"SELECT s.ShowId, s.MovieId, m.Title AS MovieTitle, s.ShowTime,
                                   s.TotalSeats, s.BookedSeats, (s.TotalSeats - s.BookedSeats) AS Available
                            FROM dbo.Show s
                            JOIN dbo.Movie m ON m.Id = s.MovieId
                            ORDER BY s.MovieId, s.ShowTime;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            this.dgvShows.AutoGenerateColumns = false;
            this.dgvShows.DataSource = dt;
        }

        private bool IsShowFormValid()
        {
            if (this.cmbShowMovie.SelectedValue == null || string.IsNullOrWhiteSpace(this.cmbShowTime.Text))
                return false;

            return true;
        }

        private void btnSaveShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsShowFormValid())
                {
                    MessageBox.Show("Please choose a movie and enter a show time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string movieId = this.cmbShowMovie.SelectedValue.ToString();
                string showTime = this.cmbShowTime.Text.Trim();
                int totalSeats = (int)this.numShowSeats.Value;

                if (this.SelectedShowId.HasValue)
                {
                
                    string checkSql = "SELECT BookedSeats FROM dbo.Show WHERE ShowId = @ShowId;";
                    object bookedObj = this.Da.ExecuteScalar(checkSql, new SqlParameter("@ShowId", this.SelectedShowId.Value));
                    int booked = bookedObj == null ? 0 : Convert.ToInt32(bookedObj);

                    if (totalSeats < booked)
                    {
                        MessageBox.Show("Total seats can't be less than the " + booked + " seat(s) already booked for this show.", "Show Times", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql = @"UPDATE dbo.Show
                                   SET MovieId = @MovieId, ShowTime = @ShowTime, TotalSeats = @TotalSeats
                                   WHERE ShowId = @ShowId;";
                    int count = this.Da.ExecuteDMLQuery(sql,
                        new SqlParameter("@MovieId", movieId),
                        new SqlParameter("@ShowTime", showTime),
                        new SqlParameter("@TotalSeats", totalSeats),
                        new SqlParameter("@ShowId", this.SelectedShowId.Value));

                    if (count == 1)
                        MessageBox.Show("Show time has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Show time could not be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = @"INSERT INTO dbo.Show (MovieId, ShowTime, TotalSeats, BookedSeats)
                                   VALUES (@MovieId, @ShowTime, @TotalSeats, 0);";
                    int count = this.Da.ExecuteDMLQuery(sql,
                        new SqlParameter("@MovieId", movieId),
                        new SqlParameter("@ShowTime", showTime),
                        new SqlParameter("@TotalSeats", totalSeats));

                    if (count == 1)
                        MessageBox.Show("Show time has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Show time could not be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.PopulateShowsGridView();
                this.ClearShowForm();
            }
            catch (SqlException sqlExc)
            {
          
                MessageBox.Show("This show time could not be saved. It may already exist for this movie.\n" + sqlExc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShows.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a show time from the list first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               int showId = Convert.ToInt32(this.dgvShows.CurrentRow.Cells["colShowId"].Value);
                string showTime = this.dgvShows.CurrentRow.Cells["colShowTime"].Value.ToString();
                string movieTitle = this.dgvShows.CurrentRow.Cells["colShowMovieTitle"].Value.ToString();
                int bookedSeats = Convert.ToInt32(this.dgvShows.CurrentRow.Cells["colShowBooked"].Value);

                string confirmMsg = "Are you sure you want to remove the " + showTime + " show for \"" + movieTitle + "\"?";
                if (bookedSeats > 0)
                    confirmMsg += "\n\nNote: this show already has " + bookedSeats + " booked seat(s).";

                DialogResult res = MessageBox.Show(confirmMsg, "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

               string sql = "DELETE FROM dbo.Show WHERE ShowId = @ShowId;";
               int count = this.Da.ExecuteDMLQuery(sql, new SqlParameter("@ShowId", showId));

                if (count == 1)
                    MessageBox.Show("Show time has been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Show time could not be removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.PopulateShowsGridView();
                this.ClearShowForm();
            }
            catch (SqlException sqlExc)
            {
                
                MessageBox.Show("This show time could not be removed because it has existing bookings.\n" + sqlExc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearShow_Click(object sender, EventArgs e)
        {
            this.ClearShowForm();
        }

        private void btnRefreshShow_Click(object sender, EventArgs e)
        {
            this.PopulateShowsGridView();
        }

        private void ClearShowForm()
        {
            this.SelectedShowId = null;
            if (this.cmbShowMovie.Items.Count > 0)
                this.cmbShowMovie.SelectedIndex = 0;
            this.cmbShowTime.Text = "";
            this.numShowSeats.Value = 100;
            this.lblShowStatus.Text = "Select a show to edit";
            this.dgvShows.ClearSelection();
        }

        private void dgvShows_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvShows.CurrentRow == null)
                return;

            this.SelectedShowId = Convert.ToInt32(this.dgvShows.CurrentRow.Cells["colShowId"].Value);
            this.cmbShowMovie.SelectedValue = this.dgvShows.CurrentRow.Cells["colShowMovieId"].Value.ToString();
            this.cmbShowTime.Text = this.dgvShows.CurrentRow.Cells["colShowTime"].Value.ToString();
            this.numShowSeats.Value = Convert.ToInt32(this.dgvShows.CurrentRow.Cells["colShowTotalSeats"].Value);

            int booked = Convert.ToInt32(this.dgvShows.CurrentRow.Cells["colShowBooked"].Value);
            int available = Convert.ToInt32(this.dgvShows.CurrentRow.Cells["colShowAvailable"].Value);
            this.lblShowStatus.Text = "Editing Show ID " + this.SelectedShowId + " - Booked: " + booked + ", Available: " + available;
        }

        private void dgvShows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
