using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Boilerplate.Models {

    public class MyModel {

        private const string CONNECTION_STRING = "Server=localhost;port=3306;Database=dotnetcoreSamples;Uid=user;Pwd=test;SslMode=none;";

        // database connectivity variables
        private MySqlConnection dbConnection; 
        private MySqlCommand dbCommand;
        private MySqlDataReader dbReader;

        private List<Review> _reviews;
        private List<Review> _reviewDetails;

        public MyModel(){

            _reviews = new List<Review>();
            _reviewDetails = new List<Review>();

            // construct required DB objects for use in private methods
            dbConnection = new MySqlConnection(CONNECTION_STRING);
            dbCommand = new MySqlCommand("", dbConnection); 
        }

        public static DateTime Now { get; }

        public List<Review> reviews {
            get {
                return _reviews;
            }
        }

        public List<Review> reviewDetails {
            get {
                return _reviewDetails;
            }
        }

        public int rating = 0;

        public void AddReview (int rating, string firstName, string lastName, string comment, string date) {
            // set the date variable to the current DateTime
            DateTime localDate = DateTime.Now;
            date = localDate.ToString();
            
            try {
                dbConnection.Open();
                dbCommand.Parameters.Clear();
                dbCommand.CommandText = "INSERT INTO tblTest (rating,firstName,lastName,comment,date) VALUES (?rating,?firstName,?lastName,?comment,?date)";

                dbCommand.Parameters.AddWithValue("?rating", rating);
                dbCommand.Parameters.AddWithValue("?firstName", firstName);
                dbCommand.Parameters.AddWithValue("?lastName", lastName);
                dbCommand.Parameters.AddWithValue("?comment", comment);
                dbCommand.Parameters.AddWithValue("?date", date);
                     
                // ExecuteNonQuery doesn't return anything
                dbCommand.ExecuteNonQuery();
            } catch (Exception e) {
                Console.WriteLine(">>> " + e.Message);
            }finally {
                dbConnection.Close();
            }
        }

        public List<Review> ReadReview(){
            try {
                dbConnection.Open();
                dbCommand.CommandText = "SELECT * FROM tblTest";
                dbReader = dbCommand.ExecuteReader();
                
                // populate List
                while (dbReader.Read()) {
                    Review item = new Review();
                    item.rating = Convert.ToInt32(dbReader["rating"]);
                    if (Convert.ToString(dbReader["firstName"]) == "" &&  Convert.ToString(dbReader["lastName"]) == ""){
                        item.firstName = "Anonymous";
                        item.lastName = "";
                    } else {
                        item.firstName = Convert.ToString(dbReader["firstName"]);
                        item.lastName = Convert.ToString(dbReader["lastName"]);
                    }
                    item.comment = Convert.ToString(dbReader["comment"]);
                    item.date = Convert.ToString(dbReader["date"]);
                    _reviewDetails.Add(item);
                }
                dbReader.Close();

            } catch (Exception e) {
                Console.WriteLine(">>> " + e.Message);
            } finally {
                dbConnection.Close();
            }
            return _reviewDetails;
        }
    }
}
