using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;

namespace HorairETML
{
    public class Data
    {
        private SQLiteConnection _sQLiteConnect;
        public Data()
        {
            
        }
        public SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            var pathDB = System.IO.Path.Combine(Environment.CurrentDirectory, "Assets/HoraireDB.db");
            if (!System.IO.File.Exists(pathDB)) throw new Exception();
            var connection_string = String.Format("Data Source={0};Version=3;", pathDB);
            sqlite_conn = new SQLiteConnection(connection_string);
            // Open the connection:
            try
            {
                sqlite_conn.Open();
                Debug.WriteLine("Connection réussie");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connection échouée.");
            }
            return sqlite_conn;
        }

        public List<object> GetRowData(string hour, string dayOfWeek, string date)
        {
            this._sQLiteConnect = CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd = this._sQLiteConnect.CreateCommand(); ;
            sqlite_cmd.CommandText = "SELECT * " +
                "FROM Periods " +
                "JOIN Courses " +
                "ON Periods.courseID = Courses.courseID " +
                $"WHERE Periods.startHour <= '{hour}' " +
                $"AND Periods.endHour > '{hour}' " +
                $"AND Courses.startDate <= '{date}' " +
                $"AND Courses.endDate >= '{date}' " +
                $"AND Courses.dayOfWeek = '{dayOfWeek}'; ";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // tableau de récolte des données
            List<object> dataCollected = new List<object>();
            
            sqlite_datareader.Read();
            try
            {
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    dataCollected.Add(sqlite_datareader[i]);
                }
            }
            catch (Exception e)
            {
            }
            this._sQLiteConnect.Close();
            return dataCollected;
        }
    }
}
