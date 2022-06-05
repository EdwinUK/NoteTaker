using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LinqToDB;
using System.Diagnostics;

namespace NoteTaker
{
    internal class DBHandler
    {
        private string ConnectionString { get; }

        // The class is constructed with a database connection string property since this is used in every method
        public DBHandler()
        {
            // IMPORTANT: PLEASE ENTER THE CONNECTION STRING FROM YOUR SQL DATABASE BELOW
            this.ConnectionString = "";
        }

        // This method is used for saving a new note to the database
        public void SaveToDatabase(Note note)
        {
            string queryString = "INSERT INTO Notes (Title, Content) VALUES(@noteTitle, @noteContent)";

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@noteTitle", note.Title);
                cmd.Parameters.AddWithValue("@noteContent", note.Content);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        // The method below is for updating an existing note in the database
        public void UpdateNote(Note note)
        {
            string queryString = "UPDATE Notes SET Title = @noteTitle, Content = @noteContent WHERE ID = @noteID";

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@noteTitle", note.Title);
                cmd.Parameters.AddWithValue("@noteContent", note.Content);
                cmd.Parameters.AddWithValue("@noteID", note.ID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        // This function is used for retrieving all existing notes in the database
        public Dictionary<string, int> RetrieveAllNotes()
        {
            string queryString = "SELECT * FROM Notes;";

            Dictionary<string, int> indexOfNotes = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    indexOfNotes.Add((string)reader.GetValue(1), (int)reader.GetValue(0));
                }

                connection.Close();

            }

            return indexOfNotes;
        }

        // This method specifically retrieves a single note using the primary ID
        public Note RetrieveSingleNote(int noteID)
        {
            string queryString = $"SELECT * FROM Notes WHERE ID = @noteID";

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@noteID", noteID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                string noteTitle = "";
                string noteContent = "";
                Note singleNote;

                while (reader.Read())
                {
                    noteID = (int)reader.GetValue(0);
                    noteTitle = (string)reader.GetValue(1);
                    noteContent = (string)reader.GetValue(2);
                }

                singleNote = new Note(noteTitle, noteContent, noteID);

                connection.Close();

                return singleNote;
            }
        }

        // This method is used for deleting notes from the database using the primary ID
        public void DeleteNote(int noteID)
        {
            string queryString = $"DELETE FROM Notes WHERE ID = @noteID";

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@noteID", noteID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }
    }
}
