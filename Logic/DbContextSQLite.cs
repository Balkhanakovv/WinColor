using System.IO;
using System.Linq;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace WinColor
{
    public class DbContextSQLite
    {
        private string connectionString;

        public DbContextSQLite(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        public DbContextSQLite()
        {
            connectionString = "profiles.db";
        }

        public void IsDbExist()
        {
            if (!File.Exists(connectionString))
            {
                using (SQLiteConnection conn = new SQLiteConnection($"DataSource={connectionString}"))
                {
                    conn.Open();

                    SQLiteCommand command = conn.CreateCommand();

                    command.CommandText = "CREATE TABLE profiles (" +
                                            "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                                            "name TEXT NOT NULL UNIQUE" +
                                            ")";
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO profiles (name) VALUES " +
                        "(\'default_profile\')";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE parameters (" +
                                            "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                                            "name TEXT NOT NULL UNIQUE" +
                                            ")";
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO parameters (name) VALUES " +
                        "(\'Hilight\'), " +
                        "(\'HotTrackingColor\')";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE notes (" +
                        "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                        "profileId NOT NULL," +
                        "parameterId NOT NULL," +
                        "value TEXT NOT NULL," +
                        "FOREIGN KEY (profileId)  REFERENCES profiles (id)," +
                        "FOREIGN KEY (parameterId)  REFERENCES parameters (id) " +
                        ")";
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO notes (profileId, parameterId, value) VALUES " +
                        "(1, 1, \'0 120 215\')," +
                        "(1, 2, \'0 102 204\')";
                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }

        public void GetDefaultParameters(Microsoft.Win32.RegistryKey registryKey)
        {
            IsDbExist();

            using (SQLiteConnection conn = new SQLiteConnection($"DataSource={connectionString}"))
            {
                conn.Open();

                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = "select parameters.name, notes.value from notes" +
                    " left join profiles on profiles.id = notes.profileId" +
                    " left join parameters on parameters.id = notes.parameterId" +
                    " where notes.profileId = 1";
                
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())   
                        {
                            registryKey.SetValue(reader.GetString(0), reader.GetString(1));
                        }
                    }
                }

                conn.Close();
            }
        }

        public void SaveProfile(string parameterName, List<ParameterModel> parameters)
        {
            IsDbExist();

            using (SQLiteConnection conn = new SQLiteConnection($"DataSource={connectionString}"))
            {
                conn.Open();

                SQLiteCommand command = conn.CreateCommand();

                command.CommandText = $"INSERT INTO profiles (name) VALUES (\'{parameterName}\')";
                command.ExecuteNonQuery();

                foreach (var param in parameters)
                {
                    command.CommandText = $"INSERT INTO notes (profileId, parameterId, value) VALUES " +
                        $"((select id from profiles where name = \'{parameterName}\'), (select id from parameters where name = \'{param.Name}\'), \'{param.Value}\')";
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public List<string> GetProfilesNames()
        {
            IsDbExist();

            var profilesList = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection($"DataSource={connectionString}"))
            {
                conn.Open();

                SQLiteCommand command = conn.CreateCommand();

                command.CommandText = "SELECT name FROM profiles";

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            profilesList.Add(reader.GetString(0));
                        }
                    }
                }

                conn.Close();
            }

            return profilesList;
        }

        public void GetProfileParams(string profileName, List<Button> buttons)
        {
            IsDbExist();

            using (SQLiteConnection conn = new SQLiteConnection($"DataSource={connectionString}"))
            {
                conn.Open();

                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = "select parameters.name, notes.value from notes" +
                    " left join profiles on profiles.id = notes.profileId" +
                    " left join parameters on parameters.id = notes.parameterId" +
                    $" where profiles.name = \'{profileName}\'";

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var btn = buttons.Find(x => x.Text == reader.GetString(0));

                            if (btn != null)
                            {
                                var color = reader.GetString(1).Split(' ');
                                btn.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));
                            }
                        }
                    }
                }

                conn.Close();
            }
        }
    }
}
