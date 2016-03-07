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
    /// Class for connecting to the database and sending information stored in the database.
    /// </summary>
    public class ConnectToDatabase
    {
        public String DatabaseName { private set; get; }
        public MySqlConnection Connection;

        /// <summary>
        /// Connects to the given database with the name databaseName.
        /// </summary>
        /// <param name="databaseName"></param>The name of the database.
        public ConnectToDatabase(String databaseName)
        {
            DatabaseName = databaseName;
            Connect();
        }

        /// <summary>
        /// Connects to the database.
        /// </summary>
        public void Connect()
        {
            //
            //----------------------------------------------------GLÖM INTE ATT ÄNDRA TILL DIN LOKALA DATABAS----------------------------------------------------:)
            //
            string connstring = string.Format("Server=localhost; database={0}; UID=root; password=", DatabaseName);
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
        /// Method for getting an Activity from the database.
        /// </summary>
        /// <param name="activity"></param>Name of the Activity.
        /// <returns></returns>Returns the Activity with the given name from param. 
        public Activity GetActivityQuery(String activity)
        {
            OpenConnection();

            string commandTextGetMoods = "SELECT moodType FROM GoodFor WHERE activityName = @Activity";
            var mySqlCommand = new MySqlCommand(commandTextGetMoods, Connection);
            mySqlCommand.Parameters.AddWithValue("@Activity", activity);
            var reader = mySqlCommand.ExecuteReader();
            List<string> moods = new List<string>();

            int i = 0;
            while (reader.Read())
            {
                moods.Add((String)reader.GetValue(i));
                i++;
            }

            CloseConnection();
            OpenConnection();

            string commandTextFromActivity = "SELECT * FROM Activity WHERE Name = @Activity2";
            var mySqlCommand2 = new MySqlCommand(commandTextFromActivity, Connection);
            mySqlCommand2.Parameters.AddWithValue("@Activity2", activity);
            var reader2 = mySqlCommand2.ExecuteReader();
            Activity a = null;

            if (reader2.Read())
            {
                a = new Activity("" + reader2.GetString(0), "" + reader2.GetString(1), reader2.GetInt16(2), reader2.GetInt16(3), moods);
            }
            CloseConnection();
            return a;
        }

        /// <summary>
        /// Method for getting an Challenge from the database.
        /// </summary>
        /// <param name="challenge"></param>Name of the Challenge.
        /// <returns></returns>Returns the Challenge with the given name from param. 
        public Challenge GetChallengeQuery(String challenge)
        {
            OpenConnection();
            string commandTextGetActivitiesNames = "SELECT activityName FROM ChallengeRequires WHERE challengeName = @ChallengeName";
            var mySqlCommand = new MySqlCommand(commandTextGetActivitiesNames, Connection);
            mySqlCommand.Parameters.AddWithValue("@ChallengeName", challenge);
            var reader = mySqlCommand.ExecuteReader();
            List<string> activitiesName = new List<string>();

            int i = 0;
            while (reader.Read())
            {
                activitiesName.Add(reader.GetString(0));
                i++;
            }

            CloseConnection();

            List<Activity> activities = new List<Activity>();

            foreach (String s in activitiesName)
            {
                activities.Add(GetActivityQuery(s));
            }

            OpenConnection();

            string commandTextFromActivity = "SELECT * FROM Challenge WHERE Name = @Challenge";
            var mySqlCommand2 = new MySqlCommand(commandTextFromActivity, Connection);
            mySqlCommand2.Parameters.AddWithValue("@Challenge", challenge);
            var reader2 = mySqlCommand2.ExecuteReader();
            Challenge a = null;

            if (reader2.Read())
            {
                String startTime = reader2.GetString(2);
                String endTime = reader2.GetString(3);

                string[] s1 = startTime.Split(':');
                string[] s2 = endTime.Split(':');

                a = new Challenge("" + reader2.GetString(0), "" + reader2.GetString(1), new Time(int.Parse(s1[0]), int.Parse(s1[1]), int.Parse(s1[2])), new Time(int.Parse(s2[0]), int.Parse(s2[1]), int.Parse(s2[2])), activities);
            }
            CloseConnection();
            return a;
        }

        /// <summary>
        /// Method for getting all the Activities from the database. 
        /// </summary>
        /// <returns></returns>A list with all Activities.
        public List<Activity> GetAllActivitiesQuery()
        {
            OpenConnection();
            string commandText = "SELECT Name FROM Activity";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            var ActivityList = new List<Activity>();
            var NamesOfChallenges = new List<string>();

            while (reader.Read())
            {
                NamesOfChallenges.Add(reader.GetString(0));
            }
            CloseConnection();

            foreach (string s in NamesOfChallenges)
            {
                ActivityList.Add(GetActivityQuery(s));
            }
            CloseConnection();
            return ActivityList;
        }

        /// <summary>
        /// Method for getting all the Challenges from the database. 
        /// </summary>
        /// <returns></returns>A list with all Challenges.
        public List<Challenge> GetAllChallengesQuery()
        {
            OpenConnection();
            string commandText = "SELECT Name FROM Challenge";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            var challengesList = new List<Challenge>();
            var namesOfChallenges = new List<string>();

            while (reader.Read())
            {
                namesOfChallenges.Add(reader.GetString(0));
            }
            CloseConnection();

            foreach (string s in namesOfChallenges)
            {
                challengesList.Add(GetChallengeQuery(s));
            }
            CloseConnection();
            return challengesList;
        }

        /// <summary>
        /// Method for getting a description of an Activity.
        /// </summary>
        /// <param name="activity"></param>The name of the Activity.
        /// <returns></returns>The description of the Activity.
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
        /// Method for getting a description of an Challenge.
        /// </summary>
        /// <param name="challenge"></param>The name of the Challenge.
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

        /// <summary>
        /// Method fot getting all Activities as a List containing all the names of every Activity.
        /// </summary>
        /// <returns></returns>A list with names of every Activity.
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

        /// <summary>
        /// Method fot getting all Challenges as a List containing all the names of every Challenge.
        /// </summary>
        /// <param name="username"></param>The user trying to access all Challenges.
        /// <returns></returns>A list with names of every Challenge.
        public List<String> GetChallengesQuery(string username)
        {
            var listWithCompletedChallenges = new List<string>();
            OpenConnection();
            string commandTextChallengesFromCompletedChallenges = "SELECT challengeName FROM ChallengeCompleted WHERE userName = '" + username + "'";
            MySqlCommand mySqlCommand1 = new MySqlCommand(commandTextChallengesFromCompletedChallenges, Connection);
            MySqlDataReader reader1 = mySqlCommand1.ExecuteReader();

            while (reader1.Read())
            {
                listWithCompletedChallenges.Add(reader1.GetString(0));
            }
            CloseConnection();

            OpenConnection();
            var listWithChallenges = new List<string>();
            var listwithEndTime = new List<string>();
            string commandText = "SELECT Name,EndTime FROM Challenge";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                listWithChallenges.Add(reader.GetString(0));
                listwithEndTime.Add(reader.GetString(1));
            }

            foreach (string time in listwithEndTime)
            {
                string[] t = time.Split(':');
                var EndTimeChallenge = new TimeSpan(int.Parse(t[0]), int.Parse(t[1]), int.Parse(t[2]));
                var timeSpan = TimeSpan.Compare(EndTimeChallenge, DateTime.Now.TimeOfDay);
                if (timeSpan == -1)
                {
                    var i = listwithEndTime.IndexOf(time);
                    listWithChallenges.RemoveAt(i);
                }
            }
            CloseConnection();

            for (int k = 0; k < listWithChallenges.Count; k++)
            {
                for (int m = 0; m < listWithCompletedChallenges.Count; m++)
                {
                    if (listWithChallenges[k] == listWithCompletedChallenges[m])
                    {
                        listWithChallenges.Remove(listWithChallenges[k]);
                    }
                }
            }

            CloseConnection();
            return listWithChallenges;
        }

        /// <summary>
        /// Method for getting a trophy.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nameOfActivity"></param>
        /// <returns></returns>

        public List<Trophy> getTrophy(string username, string nameOfActivity)
        {

            string commandTextInsertIntoActivityCompleted1 = "INSERT INTO ActivityCompleted VALUES ('" + username + "','" + nameOfActivity + "',1,1)";

            OpenConnection();
            string commandTextGetActivityCompleted = "SELECT nrAllTime,nrToday FROM ActivityCompleted WHERE userName = '" + username + "' AND activityName = '" + nameOfActivity + "'";
            MySqlCommand mySqlCommand4 = new MySqlCommand(commandTextGetActivityCompleted, Connection);
            MySqlDataReader reader4 = mySqlCommand4.ExecuteReader();
            var list = new List<int>();
            bool update = false;

            if (reader4.Read())
            {
                list.Add(reader4.GetInt16(0));
                list.Add(reader4.GetInt16(1));
                update = true;
                Debug.WriteLine("" + reader4.GetInt16(0) + " " + reader4.GetInt16(1));
            }
            else
            {
                CloseConnection();

                OpenConnection();
                MySqlCommand mySqlCommand6 = new MySqlCommand(commandTextInsertIntoActivityCompleted1, Connection);
                MySqlDataReader reader6 = mySqlCommand6.ExecuteReader();
            }
            CloseConnection();

            if (update)
            {
                OpenConnection();
                string commandTextUpdateActivityCompleted = "UPDATE ActivityCompleted SET nrAllTime = @a, nrToday = @b WHERE userName = @c AND activityName = @d";
                MySqlCommand mySqlCommand5 = new MySqlCommand(commandTextUpdateActivityCompleted, Connection);
                mySqlCommand5.Parameters.AddWithValue("@a", list[0] + 1);
                mySqlCommand5.Parameters.AddWithValue("@b", list[1] + 1);
                mySqlCommand5.Parameters.AddWithValue("@c", username);
                mySqlCommand5.Parameters.AddWithValue("@d", nameOfActivity);
                MySqlDataReader reader5 = mySqlCommand5.ExecuteReader();
                CloseConnection();
            }

            OpenConnection();
            string commandText = "SELECT Thophy FROM TrophiesNotEarnedTotalSumLeft WHERE User = @Username AND totalLeft = 0";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Username", username);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            var StringListWithTrophyNames = new List<string>();

            while (reader.Read())
            {
                StringListWithTrophyNames.Add(reader.GetString(0));
            }

            if (StringListWithTrophyNames.Count == 0)
            {
                CloseConnection();
                Debug.WriteLine("getTrophy returning new List<Trophy>()");
                return new List<Trophy>();
            }
            CloseConnection();

            for (int m = 0; m < StringListWithTrophyNames.Count; m++)
            {
                OpenConnection();
                string commandTextInsertIntoEarnedTrophy = "INSERT INTO EarnedTrophy VALUES ('" + username + "', '" + StringListWithTrophyNames[m] + "')";
                MySqlCommand mySqlCommand7 = new MySqlCommand(commandTextInsertIntoEarnedTrophy, Connection);
                MySqlDataReader reader7 = mySqlCommand7.ExecuteReader();
                CloseConnection();
            }

            CloseConnection();

            var trophyList = new List<Trophy>();
            int value = 0;
            for (int i = 0; i < StringListWithTrophyNames.Count; i++)
            {
                OpenConnection();
                string commandTextGetTrophy = "SELECT * FROM Trophy WHERE Name = @TrophyName";
                MySqlCommand mySqlCommand2 = new MySqlCommand(commandTextGetTrophy, Connection);
                mySqlCommand2.Parameters.AddWithValue("@TrophyName", StringListWithTrophyNames[i]);
                MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();
                while (reader2.Read())
                {
                    trophyList.Add(new Trophy("" + reader2.GetString(value), "" + reader2.GetString(value + 1), "" + reader2.GetString(value + 2)));
                }
                i++;
                CloseConnection();
            }
            CloseConnection();
            Debug.WriteLine("getTrophy returning trophyList, NEW TROPHY/TROPHIES");
            return trophyList;
        }

        /// <summary>
        /// Sets the current Challenge for the specified uer.
        /// </summary>
        /// <param name="username"></param>The user starting a new Challenge.
        /// <param name="challenge"></param>Name of the Challenge. 
        /// <returns></returns>
        public bool setCurrentChallenge(string username, string challenge)
        {
            if (TimeLeftForChallenge(challenge))
            {
                OpenConnection();
                string commandTextInsertIntoOnGoingChallenge = "INSERT INTO OnGoingChallenge VALUES ('" + username + "','" + challenge + "')";
                MySqlCommand mySqlCommand1 = new MySqlCommand(commandTextInsertIntoOnGoingChallenge, Connection);
                MySqlDataReader reader1 = mySqlCommand1.ExecuteReader();
                CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method for checking if the current Challenge is still operative. 
        /// </summary>
        /// <param name="challenge"></param>Name of the Challenge.
        /// <returns></returns>True if it is time left, otherwise false.
        public bool TimeLeftForChallenge(string challenge)
        {
            CloseConnection();
            OpenConnection();
            var EndTimeString = "";
            string commandText = "SELECT EndTime FROM Challenge WHERE Name = @Challenge";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Challenge", challenge);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                EndTimeString = reader.GetString(0);
            }
            CloseConnection();

            string[] t = EndTimeString.Split(':');
            var EndTimeChallenge = new TimeSpan(int.Parse(t[0]), int.Parse(t[1]), int.Parse(t[2]));
            var timeSpan = TimeSpan.Compare(EndTimeChallenge, DateTime.Now.TimeOfDay);
            if (timeSpan == 1)
            {
                CloseConnection();
                return true;
            }
            else
            {
                CloseConnection();
                return false;
            }
        }

        /// <summary>
        /// Method for checking if the user is currently in a Challenge.
        /// </summary>
        /// <param name="username"></param>The user who may be in a Challenge at the moment. 
        /// <returns></returns>True if the user is performing a Challenge, otherwise false.
        public bool onGoingChallenge(string username)
        {
            OpenConnection();
            string commandText = "SELECT challengeName FROM OnGoingChallenge WHERE userName = @Username";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Username", username);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            var value = false;
            if (reader.Read())
            {
                if (TimeLeftForChallenge(reader.GetString(0)))
                {
                    value = true;
                    CloseConnection();
                }
                else
                {
                    CloseConnection();
                    OpenConnection();
                    string commandText1 = "DELETE FROM OnGoingChallenge WHERE userName = @UserName";
                    MySqlCommand mySqlCommand1 = new MySqlCommand(commandText1, Connection);
                    mySqlCommand1.Parameters.AddWithValue("@UserName", username);
                    MySqlDataReader reader1 = mySqlCommand1.ExecuteReader();
                    Debug.WriteLine("onGoingChallenge. TimeLeftForChallenge(reader.GetString(0)) = false");
                    CloseConnection();
                }
                CloseConnection();
                return value;
            }
            else
            {
                CloseConnection();
                return value;
            }
        }

        /// <summary>
        /// Method for checking if a user has comepleted the given Challenge.
        /// </summary>
        /// <param name="username"></param>The user who may have completed the Challenge.
        /// <param name="challenge"></param>Name of the Challenge.
        /// <returns></returns>
        public bool challengeCompleted(string username, string challenge)
        {
            OpenConnection();
            string commandText = "SELECT challengeName FROM ChallengeCompleted WHERE challengeName = @ChallengeName";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@ChallengeName", challenge);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            else
            {
                CloseConnection();
                return false;
            }
        }

        /// <summary>
        /// Method for getting all Trophies. 
        /// </summary>
        /// <returns></returns>Returning a list with all Trophies from the database.
        public List<Trophy> AllTrophies()
        {
            OpenConnection();
            string commandTextGetTrophy = "SELECT * FROM Trophy";
            MySqlCommand mySqlCommand = new MySqlCommand(commandTextGetTrophy, Connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            var ListWithAllTrophies = new List<Trophy>();
            while (reader.Read())
            {
                ListWithAllTrophies.Add(new Trophy("" + reader.GetString(0), "" + reader.GetString(1), "" + reader.GetString(2)));
            }
            CloseConnection();
            return ListWithAllTrophies;
        }

        /// <summary>
        /// Method for getting all gold trophies for a given user. 
        /// </summary>
        /// <param name="username"></param>Name of the user.
        /// <returns></returns>
        public int GoldTrophies(String username)
        {
            OpenConnection();
            string commandText = "SELECT * FROM UserTotalGold WHERE User = @Username";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Username", username);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            return reader.GetInt16(0);
        }

        /// <summary>
        /// Method for getting all silver trophies for a given user.  
        /// </summary>
        /// <param name="username"></param>Name of the user.
        /// <returns></returns>
        public int SilverTrophies(String username)
        {
            OpenConnection();
            string commandText = "SELECT * FROM UserTotalSilver WHERE User = @Username";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Username", username);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            return reader.GetInt16(0);
        }

        /// <summary>
        /// Method for getting all bronze trophies for a given user. 
        /// </summary>
        /// <param name="username"></param>Name of the user.
        /// <returns></returns>
        public int BronzeTrophies(String username)
        {
            OpenConnection();
            string commandText = "SELECT * FROM UserTotalBronze WHERE User = @Username";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Username", username);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            return reader.GetInt16(0);
        }

        /// <summary>
        ///  Method for getting all points for a given user. 
        /// </summary>
        /// <param name="username"></param>Name of the user.
        /// <returns></returns>
        public int TotalPoints(String username)
        {
            OpenConnection();
            string commandText = "SELECT * FROM UserTotalPoints WHERE User = @Username";
            MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
            mySqlCommand.Parameters.AddWithValue("@Username", username);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            return reader.GetInt16(0);
        }

        /// <summary>
        /// Method for getting a all recomended activities for the user dependent on the user´s mood.
        /// </summary>
        /// <param name="moods"></param>The user´s different moods. 
        /// <returns></returns>A list with recommended activities for the user. 
        public List<string> RecommendedActivities(List<MoodType> moods)
        {
            var allActivities = GetActivitiesQuery();
            var activitiesForMoods = new List<string>();
            var recommendedActivities = new List<string>();

            for (int i = 0; i < moods.Count; i++)
            {
                OpenConnection();
                string commandText = "SELECT COUNT activityName FROM GoodFor WHERE moodType = @MoodType";
                MySqlCommand mySqlCommand = new MySqlCommand(commandText, Connection);
                mySqlCommand.Parameters.AddWithValue("@MoodType", moods[i].ToString());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                int numberOfActivities = reader.GetInt16(0);
                CloseConnection();

                OpenConnection();
                string commandText1 = "SELECT activityName FROM GoodFor WHERE moodType = @MoodType";
                MySqlCommand mySqlCommand1 = new MySqlCommand(commandText1, Connection);
                mySqlCommand1.Parameters.AddWithValue("@MoodType", moods[i].ToString());
                reader = mySqlCommand.ExecuteReader();
                int k = 0;

                if (reader.Read())
                {
                    while (k < numberOfActivities)
                    {
                        activitiesForMoods.Add(reader.GetString(k));
                        k++;
                    }
                }
                CloseConnection();
            }

            CloseConnection();

            foreach (string activityString in allActivities)
            {
                foreach (string stringFromMood in activitiesForMoods)
                {
                    if (stringFromMood == activityString && !recommendedActivities.Contains(stringFromMood))
                    {
                        recommendedActivities.Add(stringFromMood);
                    }
                }
            }
            return recommendedActivities;
        }

        /// <summary>
        /// Closing the connection to the database.
        /// </summary>
        public void CloseConnection()
        {
            Connection.Close();
        }

        /// <summary>
        /// Opening the connection to the database.
        /// </summary>
        public void OpenConnection()
        {
            Connection.Open();
        }
    }
}
