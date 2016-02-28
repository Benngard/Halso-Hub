using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

/// <summary>
/// Ola Andersson
/// </summary>
namespace Halso_Hub
{
    /// <summary>
    /// Class for connecting to the database and sending information stored in the databse
    /// </summary>
    public class ConnectToDatabase
    {
        public String DatabaseName { private set; get; }
        public MySqlConnection Connection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="databaseName"></param>The name of the database.
        public ConnectToDatabase(String databaseName)
        {
            DatabaseName = databaseName;
            Connect();
        }

        /// <summary>
        /// Connects to the database
        /// </summary>
        public void Connect()
        {
            string connstring = string.Format("Server=localhost; database={0}; UID=root; password=vatten123", DatabaseName);
            Connection = new MySqlConnection(connstring);
        }

        /// <summary>
        /// Checks if the program is connected to the database.
        /// </summary>
        /// <returns></returns> True if connected, otherwise false.
        public bool IsConnected()
        {
            bool result = false;
            if (Connection != null)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Method for getting an Activity.
        /// </summary>
        /// <returns></returns>Returns all activities.
        public Activity GetActivityQuery(String activity)
        {
            OpenConnection();
            string commandText = "SELECT * FROM Activity WHERE Name = @Activity";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Activity", activity);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            Activity a = null;
            if (reader.Read())
            {
                a = new Activity("" + reader.GetString(0), "" + reader.GetString(1), reader.GetInt16(2), reader.GetInt16(3));
            }
            CloseConnection();
            return a;
        }

        /*/// <summary>
        /// Method for getting a Challenge.
        /// </summary>
        /// <returns></returns>Returns all activities.
        public Challenge GetChallengeQuery(String challenge)
        {
            OpenConnection();
            string commandText = "SELECT * FROM Challenge WHERE Name = @Challenge";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Activity", challenge);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            Challenge c = null;
            if (reader.Read())
            {
                c = new Challenge("" + reader.GetString(0), "" + reader.GetString(1), reader.GetInt(2), reader.Get(3),null);
            }
            CloseConnection();
            return c;
        }*/

        /// <summary>
        /// Method for getting all the activities.
        /// </summary>
        /// <returns></returns>Returns all activities.
        public List<Activity> GetAllActivitiesQuery()
        {
            OpenConnection();
            string commandText = "SELECT * FROM Activity";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            List<Activity> activityList = new List<Activity>();
            int i = 0;           
            while (reader.Read())
            {
                activityList.Add(new Activity("" + reader.GetString(i), "" + reader.GetString(i), reader.GetInt16(i), reader.GetInt16(i)));
                i++;
            }
            CloseConnection();
            return activityList;
        }

        /*/// <summary>
        /// Method for getting all the challenges
        /// </summary>
        /// <returns></returns> Returns all challenges
        public List<Challenge> GetAllChallengesQuery()
        {
            OpenConnection();
            string commandText = "SELECT * FROM Challenge";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            List<Challenge> challengesList = new List<Challenge>();
            int i = 0;
            while (reader.Read())
            {
                challengesList.Add(new Challenge("" + reader.GetString(i), "" + reader.GetString(i), reader.GetTime(i), reader.GetInt16(i), null));
                i++;
            }
            CloseConnection();
            return challengesList;
        }*/

        /// <summary>
        /// Method for getting a description of an Activity
        /// </summary>
        /// <param name="activity"></param>The Activity´s name
        /// <returns></returns>The descriptino of the Activity
        public String GetActivityDescriptionQuery(String activity)
        {
            OpenConnection();
            string commandText = "SELECT * FROM Activity WHERE Name = @Activity";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Activity", activity);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();                            
            String description = ""; 
            while (reader.Read())
            {
                description = reader.GetString(1);
            }
            CloseConnection();
            return description;
        }

        /// <summary>
        /// Method for getting a description of an Challenge
        /// </summary>
        /// <param name="challenge"></param>
        /// <returns></returns>
        public String GetChallengeDescriptionQuery(String challenge)
        {
            OpenConnection();
            string commandText = "SELECT * FROM Challenge WHERE Name = @Challenge";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Challenge", challenge);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            String description = "";
            while (reader.Read())
            {
                description = reader.GetString(1);
            }
            CloseConnection();
            return description;
        }

        public List<String> GetActivitiesQuery()
        {
            OpenConnection();
            List<String> listWithActivities = new List<string>();
            string commandText = "SELECT * FROM Activity";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                listWithActivities.Add(reader.GetString(0));
            }

            CloseConnection();
            return listWithActivities;
        }

        public List<String> GetChallengesQuery()
        {
            OpenConnection();
            List<String> listWithChallenges = new List<string>();
            string commandText = "SELECT * FROM Challenge";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                listWithChallenges.Add(reader.GetString(0));
            }

            CloseConnection();
            return listWithChallenges;
        }

        public void CloseConnection()
        {
            Connection.Close();
        }

        public void OpenConnection()
        {
            Connection.Open();
        }
    }
}
