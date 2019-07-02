using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        private static string _connectionString = @"Server=DESKTOP-8FCTU48\SQLEXPRESS;Database=AdoNetDB;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            //AddAuthor();
            //AddBook();
            //EditAuthor();
            EditBook();
            //AddAuthorBySP();
            Console.ReadLine();
        }
        private static void AddAuthor()
        {
            Console.WriteLine("Please enter a FirstName for Author: ");
            var authorFName = Console.ReadLine();
            Console.WriteLine("Please enter a LastName for Author: ");
            var authorLName = Console.ReadLine();

            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format("Insert into Author (FirstName, LastName) values ('{0}','{1}')", authorFName, authorLName);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Author added!");
        }
        private static void AddBook()
        {
            Console.WriteLine("Please enter a Title for Book: ");
            var bookTitle = Console.ReadLine();
            Console.WriteLine("Please enter a Genre for Book: ");
            var bookGenre = Console.ReadLine();

            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = string.Format("Insert into Book (Title, Genre) values ('{0}','{1}')", bookTitle, bookGenre);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Book added!");
        }

        private static void EditAuthor()
        {
          
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Update Author SET FirstName = 'Fjodor' WHERE FirstName = 'Charles' ";

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Author edited");
        }
        private static void EditBook()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Update Book SET Title = 'Happy life' WHERE Title = 'Factotum' ";

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Book edited");
        }
        private static void AddAuthorBySP()
        {
            Console.WriteLine("Author FirstName: ");
            var authorName = Console.ReadLine();
            Console.WriteLine("Author LastName: ");
            var authorSurname = Console.ReadLine();

            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand("AddAuthor", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = authorName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = authorSurname;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
