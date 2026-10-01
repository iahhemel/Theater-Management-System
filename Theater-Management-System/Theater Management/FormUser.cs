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
    public partial class FormUser : Form
    {
      

        private string UserId { get; set; }
        private string UserName { get; set; }

        private const decimal TicketPrice = 1000m;

        private const int MaxTicketsPerBooking = 5;

        private const string SearchPlaceholder = "Enter Movie Name";

        public FormUser() : this(null, "Guest")
        {
        } 

        public FormUser(string userId, string userName)
        {
            InitializeComponent();
            this.UserId = userId;
            this.UserName = userName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.lblWelcomeUser.Text = "Welcome, " + this.UserName + " !";

            try
            {
               
                this.movieTableAdapter.Fill(this.fSummerDbDataSet.Movie);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not load movies from the database.\n" + exc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Genre filter
            this.cmbAllGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAllGenre.Items.Clear();
            this.cmbAllGenre.Items.AddRange(new object[] { "All Genres", "action", "adventure", "comedy", "drama", "horror", "thriller" });
            this.cmbAllGenre.SelectedIndex = 0;

            
            this.cmbRatings.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRatings.Items.Clear();
            this.cmbRatings.Items.AddRange(new object[] { "All Ratings", "9+", "8+", "7+", "6+", "Below 6" });
            this.cmbRatings.SelectedIndex = 0;

            this.txtEnterMovieName.Text = SearchPlaceholder;
            this.txtEnterMovieName.ForeColor = Color.Gray;

            this.txtTotalPrice.ReadOnly = true;
            this.RecalculateTotalPrice();

            if (this.dgvAvailableMovies.Rows.Count > 0)
                this.dgvAvailableMovies.Rows[0].Selected = true;

            this.ShowSelectedMovieDetails();
            this.LoadShowTimesForSelectedMovie();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.txtEnterMovieName.Text == SearchPlaceholder)
            {
                this.txtEnterMovieName.Text = "";
                this.txtEnterMovieName.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtEnterMovieName.Text))
            {
                this.txtEnterMovieName.Text = SearchPlaceholder;
                this.txtEnterMovieName.ForeColor = Color.Gray;
            }
        }

   
        private void filter_Changed(object sender, EventArgs e)
        {
            this.ApplyFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtEnterMovieName.Text = SearchPlaceholder;
            this.txtEnterMovieName.ForeColor = Color.Gray;
            this.cmbAllGenre.SelectedIndex = 0;
            this.cmbRatings.SelectedIndex = 0;
            this.movieBindingSource.Filter = null;
        }

        private void ApplyFilter()
        {
            var conditions = new List<string>();

            string title = this.txtEnterMovieName.Text.Trim();
            if (!string.IsNullOrEmpty(title) && title != SearchPlaceholder)
                conditions.Add("Title LIKE '" + title.Replace("'", "''") + "%'");

            if (this.cmbAllGenre.SelectedIndex > 0)
                conditions.Add("Genre = '" + this.cmbAllGenre.Text.Replace("'", "''") + "'");

            if (this.cmbRatings.SelectedIndex > 0)
            {
                string ratingText = this.cmbRatings.Text;
                if (ratingText == "Below 6")
                    conditions.Add("IMDB < 6");
                else
                {
                    string digits = ratingText.TrimEnd('+');
                    conditions.Add("IMDB >= " + digits);
                }
            }

            this.movieBindingSource.Filter = conditions.Count > 0 ? string.Join(" AND ", conditions) : null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.ShowSelectedMovieDetails();
            this.LoadShowTimesForSelectedMovie();
        }

        private void ShowSelectedMovieDetails()
        {
            if (this.dgvAvailableMovies.CurrentRow == null || this.dgvAvailableMovies.CurrentRow.DataBoundItem == null)
            {
                this.lblMovieIdDetails.Text = "-";
                this.lblMovieTitleDetails.Text = "-";
                this.lblGenreDetails.Text = "-";
                this.lblRatingDetails.Text = "-";
                this.lbllblReleaseDateDetails.Text = "-";
                this.ClearPosterPreview();
                return;
            }

            DataRowView row = (DataRowView)this.dgvAvailableMovies.CurrentRow.DataBoundItem;

            this.lblMovieIdDetails.Text = row["Id"].ToString();
            this.lblMovieTitleDetails.Text = row["Title"].ToString();
            this.lblGenreDetails.Text = row["Genre"].ToString();
            this.lblRatingDetails.Text = row["IMDB"].ToString();
            this.lbllblReleaseDateDetails.Text = row["ReleaseDate"].ToString();
         
            this.LoadPosterPreview(row["Id"].ToString());
        }


        private void LoadPosterPreview(string movieId)
        {
            this.ClearPosterPreview();

            try
            {
                using (DataAccess da = new DataAccess())
                {    
                    object result = da.ExecuteScalar("SELECT PosterPath FROM dbo.Movie WHERE Id = @Id;", new SqlParameter("@Id", movieId));
                    string posterPath = (result == null || result == DBNull.Value) ? null : result.ToString();
                   
                    if (!string.IsNullOrEmpty(posterPath) && File.Exists(posterPath))
                        this.picSMDPoster.Image = Image.FromFile(posterPath);
                }
            }
            catch
            {
              
            }
        }

        private void ClearPosterPreview()
        {
            if (this.picSMDPoster.Image != null)
            {
                var old = this.picSMDPoster.Image;
                this.picSMDPoster.Image = null;
                old.Dispose();
            }
        }

        private void LoadShowTimesForSelectedMovie()
        {
            this.cmbShowTime.DataSource = null;
            this.cmbShowTime.Items.Clear();

            if (this.dgvAvailableMovies.CurrentRow == null || this.dgvAvailableMovies.CurrentRow.DataBoundItem == null)
            {
                this.cmbShowTime.Enabled = false;
                this.nudNumberOfTickets.Enabled = false;
                this.btnBookTicket.Enabled = false;
                this.lblSeatsInfo.Text = "Available Seats : -";
                return;
            }

            DataRowView movieRow = (DataRowView)this.dgvAvailableMovies.CurrentRow.DataBoundItem;
            string movieId = movieRow["Id"].ToString();

            try
            {
                using (DataAccess da = new DataAccess())
                {
                    string sql = @"SELECT ShowId, ShowTime, TotalSeats, BookedSeats, (TotalSeats - BookedSeats) AS Available
                                   FROM dbo.Show
                                   WHERE MovieId = @MovieId
                                   ORDER BY ShowTime;";
                    DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter("@MovieId", movieId));
                   
                    if (dt.Rows.Count == 0)
                    {
                        //control diseable
                        this.cmbShowTime.Enabled = false;
                        this.nudNumberOfTickets.Enabled = false;
                        this.btnBookTicket.Enabled = false;
                        this.lblSeatsInfo.Text = "No show times available for this movie";
                        return;
                    }

                    this.cmbShowTime.Enabled = true;
                    this.cmbShowTime.DisplayMember = "ShowTime";
                    this.cmbShowTime.ValueMember = "ShowId";
                    this.cmbShowTime.DataSource = dt;
                    this.cmbShowTime.SelectedIndex = 0;
                    this.UpdateSeatInfoAndPrice();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not load show times.\n" + exc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSeatInfoAndPrice();
        }
        private void UpdateSeatInfoAndPrice()
        {
            DataRowView row = this.cmbShowTime.SelectedItem as DataRowView;
            if (row != null)
            {
                int totalSeats = Convert.ToInt32(row["TotalSeats"]);
                int booked = Convert.ToInt32(row["BookedSeats"]);
                int available = Convert.ToInt32(row["Available"]);

                this.lblSeatsInfo.Text = "Available Seats : " + available + " / " + totalSeats + " (Booked: " + booked + ")";

                if (available <= 0)
                {
                    this.nudNumberOfTickets.Enabled = false;
                    this.btnBookTicket.Enabled = false;
                }
                else
                {
                    this.nudNumberOfTickets.Enabled = true;
                    this.btnBookTicket.Enabled = true;
                    int cap = Math.Min(available, MaxTicketsPerBooking);
                    this.nudNumberOfTickets.Maximum = cap;
                    if (this.nudNumberOfTickets.Value > cap)
                        this.nudNumberOfTickets.Value = cap;
                    if (this.nudNumberOfTickets.Value < this.nudNumberOfTickets.Minimum)
                        this.nudNumberOfTickets.Value = this.nudNumberOfTickets.Minimum;
                }
            }
            else
            {
                this.lblSeatsInfo.Text = "Available Seats : -";
            }
          
            this.RecalculateTotalPrice();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.RecalculateTotalPrice();
        }

        private void RecalculateTotalPrice()
        {
            decimal total = TicketPrice * this.nudNumberOfTickets.Value;
            this.txtTotalPrice.Text = total.ToString("0") + " Bdt";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dgvAvailableMovies.CurrentRow == null || this.dgvAvailableMovies.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Please select a movie first.", "Book Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView showRow = this.cmbShowTime.SelectedItem as DataRowView;
            if (showRow == null)
            {
                MessageBox.Show("Please choose a show time.", "Book Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(this.UserId))
            {
                MessageBox.Show("You must be logged in to book a ticket.", "Book Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView movieRow = (DataRowView)this.dgvAvailableMovies.CurrentRow.DataBoundItem;
            string movieId = movieRow["Id"].ToString();
            string movieTitle = movieRow["Title"].ToString();

            int showId = Convert.ToInt32(showRow["ShowId"]);
            string showTime = showRow["ShowTime"].ToString();
            int available = Convert.ToInt32(showRow["Available"]);
            int quantity = (int)this.nudNumberOfTickets.Value;

            if (quantity > MaxTicketsPerBooking)
            {
                MessageBox.Show("You can book a maximum of " + MaxTicketsPerBooking + " ticket(s) at a time.", "Book Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity > available)
            {
                MessageBox.Show("Only " + available + " seat(s) left for this show time.", "Book Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.LoadShowTimesForSelectedMovie();
                return;
            }

            decimal totalPrice = TicketPrice * quantity;

            this.btnBookTicket.Enabled = false;
            try
            {
                using (DataAccess da = new DataAccess())
                {
                    BookingResult result = da.BookTicket(this.UserId, movieId, showId, showTime, quantity, totalPrice);

                    switch (result)
                    {
                        case BookingResult.Success:
                            MessageBox.Show(
                                "Booking confirmed!\n\nMovie: " + movieTitle +
                                "\nShow Time: " + showTime +
                                "\nTickets: " + quantity +
                                "\nTotal: " + totalPrice.ToString("0") + " Bdt",
                                "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.nudNumberOfTickets.Value = 1;
                            this.LoadShowTimesForSelectedMovie();
                            this.TrySelectShowTime(showId);
                            break;

                        case BookingResult.NotEnoughSeats:
                            MessageBox.Show("Sorry, someone just booked those seats. Please check the updated availability and try again.", "Book Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.LoadShowTimesForSelectedMovie();
                            break;

                        default:
                            MessageBox.Show("The booking could not be completed. Please try again.", "Book Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            catch (SqlException sqlExc)
            {
                MessageBox.Show("Could not connect to the database.\n" + sqlExc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.btnBookTicket.Enabled = true;
            }
        }

        private void TrySelectShowTime(int showId)
        {
            DataTable dt = this.cmbShowTime.DataSource as DataTable;
            if (dt == null)
                return;

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["ShowId"]) == showId)
                {
                    this.cmbShowTime.SelectedValue = showId;
                    return;
                }
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSeatsInfo_Click(object sender, EventArgs e)
        {

        }

       
    }
}
