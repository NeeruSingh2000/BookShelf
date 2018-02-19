using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessObjects;
using System.Data.SqlClient;
using System.Data;
using System.Collections;


namespace DataLayer
{
   public static class BookShelf
    {
        /// <summary>
        /// Returns list of all books 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Book> GetAllBooks()
        {
            string query = @"SELECT * from Book";
            List<Book> list = null;

            using (SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings.Get("dbConnectionString")))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query))
                {
                    sqlCommand.Connection = sqlConnection;
                    using (SqlDataReader booksDataReader = sqlCommand.ExecuteReader())
                    {
                        try
                        {
                            list = new List<Book>();
                            while (booksDataReader.Read())
                            {
                                Book book = new Book();
                                book.Title = booksDataReader.GetString(0);
                                book.Author = booksDataReader.GetString(1);
                                book.ISBN = booksDataReader.GetString(2);
                                if (booksDataReader.IsDBNull(3))
                                    book.LoanedTo = null;
                                else
                                    book.LoanedTo = booksDataReader.GetInt32(3);

                                list.Add(book);

                            }
                        }
                        catch(Exception exp)
                        {
                            //log execption here
                        }
                    }

                }
            }

            return list;
        }


        /// <summary>
        /// Set Loanedto  column value to 1 in database
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static bool Loan(Book book)
        {
            bool isValid = false; 
            string query = @"update book set LoanedTo = 1 where isbn =  '" +book.ISBN + "'";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query))
                {
                    try
                    {
                        sqlCommand.Connection = connection;
                        int ret = sqlCommand.ExecuteNonQuery();
                        isValid = ret > 0;
                    }
                    catch(Exception exp)
                    {
                        //Log Exception Here
                        isValid = false;
                    }

                }
            }
            return isValid;
        }


        /// <summary>
        /// Set LoanedTo column value  to null in the database
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static bool Return(Book book)
        {
            bool isValid = false;
            string query = @"update book set LoanedTo = null where isbn =  '" + book.ISBN + "'";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query))
                {
                    try
                    {
                        sqlCommand.Connection = connection;
                        int ret = sqlCommand.ExecuteNonQuery();
                        isValid = ret > 0;
                    }
                    catch(Exception exp)
                    {
                        //Log Exception Here
                        isValid = false;
                    }

                }
            }
            return isValid;
        }
    }
}
