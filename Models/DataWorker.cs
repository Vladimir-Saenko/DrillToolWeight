using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace DrillToolWeight.Models
{
    public class DataWorker
    {
        private static string connectionString = "";

        public bool connectionState { get; set; } = false;

    //    SQLiteDataAdapter sqlDataAdapter = null;

        /* статический конструктор для инициализации
         * строки подключения к БД */
        static DataWorker() 
        {
            string dbFilePath = ConfigurationManager.AppSettings.Get("dbFilePath"); // получение переменной из App.config
//            if (!File.Exists(dbFilePath))
                connectionString = (@"Data Source=" + dbFilePath + ";Version=3;"); // строка подключения
        }
        

        /* Чтение списка двигателей */
        internal List<Engine> GetEngines(string typeSection)
        {
            string sqlQuery = "SELECT * FROM Engines";
            
            // Фильтр по типу двигателя
            if (typeSection != "Все") 
            {
                sqlQuery += $" WHERE type = '{typeSection}'";
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString)) 
                {

                    connection.Open();
                    using (var sqlCmd = new SQLiteCommand(sqlQuery, connection)) 
                    {
                        using (var rdr = sqlCmd.ExecuteReader()) 
                        {
                            List<Engine> engines = new List<Engine>();

                            while (rdr.Read()) 
                            {
                                engines.Add(new Engine
                                {
                                    Id = rdr.GetInt32(0),
                                    Name = rdr.GetString(1),
                                    Type = rdr.GetString(2),
                                    Length = rdr.GetFloat(3),
                                    Weight = rdr.GetFloat(4)
                                });
                            }

                            return engines;

                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return null;
        }

        /* Чтение списка труб */
        internal List<Pipe> GetPipes(string typeSection)
        {
            string sqlQuery = "SELECT * FROM Pipes";

            // Фильтр по типу двигателя
            if (typeSection != "Все")
            {
                sqlQuery += $" WHERE type = '{typeSection}'";
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {

                    connection.Open();
                    using (var sqlCmd = new SQLiteCommand(sqlQuery, connection))
                    {
                        using (var rdr = sqlCmd.ExecuteReader())
                        {
                            List<Pipe> pipes = new List<Pipe>();

                            while (rdr.Read())
                            {
                                pipes.Add(new Pipe
                                {
                                    Id = rdr.GetInt32(0),
                                    Name = rdr.GetString(5),
                                    Type = rdr.GetString(4),
                                    Dn = rdr.GetFloat(1),
                                    Dv = rdr.GetFloat(2),
                                    Weight1m = rdr.GetFloat(3)
                                });
                            }

                            return pipes;

                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return null;
        }

        /* Чтение списка прочего инструмента */
        internal List<Other> GetOthers(string typeSection)
        {
            string sqlQuery = "SELECT * FROM Other";

            // Фильтр по типу
            if (typeSection != "Все")
            {
                sqlQuery += $" WHERE type = '{typeSection}'";
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {

                    connection.Open();
                    using (var sqlCmd = new SQLiteCommand(sqlQuery, connection))
                    {
                        using (var rdr = sqlCmd.ExecuteReader())
                        {
                            List<Other> others = new List<Other>();

                            while (rdr.Read())
                            {
                                others.Add(new Other
                                {
                                    Id = rdr.GetInt32(0),
                                    Name = rdr.GetString(1),
                                    Type = rdr.GetString(2),
                                    Length = rdr.GetFloat(3),
                                    Weight = rdr.GetFloat(4)
                                });
                            }

                            return others;

                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return null;
        }
    }
}
