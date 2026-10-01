using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater_Management
{
    public enum BookingResult
    {
        Success,
        NotEnoughSeats,
        Error
    }

    public class DataAccess : IDisposable
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

     

        public DataAccess()
        {

            this.Sqlcon = new SqlConnection(Theater_Management.Properties.Settings.Default.FSummerDbConnectionString);
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }



        public DataTable ExecuteQueryTable(string sql, params SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            if (parameters != null && parameters.Length > 0)
                this.Sqlcom.Parameters.AddRange(parameters);

            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql, params SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            if (parameters != null && parameters.Length > 0)
                this.Sqlcom.Parameters.AddRange(parameters);

            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            if (parameters != null && parameters.Length > 0)
                this.Sqlcom.Parameters.AddRange(parameters);

            return this.Sqlcom.ExecuteScalar();
        }

        public BookingResult BookTicket(string userId, string movieId, int showId, string showTime, int quantity, decimal totalPrice)
        {
            using (SqlTransaction tx = this.Sqlcon.BeginTransaction())
            {
                try
                {

                    string updateSql = @"UPDATE dbo.Show
                                          SET BookedSeats = BookedSeats + @Qty
                                          WHERE ShowId = @ShowId AND (TotalSeats - BookedSeats) >= @Qty;";
                    using (SqlCommand updateCmd = new SqlCommand(updateSql, this.Sqlcon, tx))
                    {
                        updateCmd.Parameters.AddWithValue("@Qty", quantity);
                        updateCmd.Parameters.AddWithValue("@ShowId", showId);
                        int rowsUpdated = updateCmd.ExecuteNonQuery();

                        if (rowsUpdated != 1)
                        {
                            tx.Rollback();
                            return BookingResult.NotEnoughSeats;
                        }
                    }

                    string insertSql = @"INSERT INTO dbo.Booking (UserId, MovieId, ShowId, ShowTime, Quantity, TotalPrice, BookingDate)
                                          VALUES (@UserId, @MovieId, @ShowId, @ShowTime, @Quantity, @TotalPrice, GETDATE());";
                    using (SqlCommand insertCmd = new SqlCommand(insertSql, this.Sqlcon, tx))
                    {
                        insertCmd.Parameters.AddWithValue("@UserId", userId);
                        insertCmd.Parameters.AddWithValue("@MovieId", movieId);
                        insertCmd.Parameters.AddWithValue("@ShowId", showId);
                        insertCmd.Parameters.AddWithValue("@ShowTime", showTime);
                        insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        int rowsInserted = insertCmd.ExecuteNonQuery();
                        if (rowsInserted != 1)
                        {
                            tx.Rollback();
                            return BookingResult.Error;
                        }
                    }

                    tx.Commit();
                    return BookingResult.Success;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }


        public bool DeleteMovieCascade(string movieId)
        {
            using (SqlTransaction tx = this.Sqlcon.BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking WHERE MovieId = @MovieId;", this.Sqlcon, tx))
                    {
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Show WHERE MovieId = @MovieId;", this.Sqlcon, tx))
                    {
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        cmd.ExecuteNonQuery();
                    }

                    int movieRowsDeleted;
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Movie WHERE Id = @MovieId;", this.Sqlcon, tx))
                    {
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        movieRowsDeleted = cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return movieRowsDeleted == 1;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public void Dispose()
        {
            try
            {
                if (this.sqlcon != null && this.sqlcon.State != ConnectionState.Closed)
                    this.sqlcon.Close();

                if (this.sqlcon != null)
                    this.sqlcon.Dispose();
            }
            catch
            {
               
            }
        }

    }
}
