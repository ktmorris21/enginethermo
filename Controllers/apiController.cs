using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace enginethermo {

    [Route("api/[controller]")]
    [ApiController]
    public class createDatabaseController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> createDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(Shared.connectionString))
            {
                connection.Open();


                // Drop all existing tables
                List<string> tables = new List<string>(); 

                string queryString = @"SELECT table_name FROM information_schema.tables
                    WHERE table_schema = 'EngineThermo'";
                MySqlCommand command = new MySqlCommand(queryString, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tables.Add(reader.GetString(0));
                }

                reader.Close();

                foreach (string table in tables)
                {
                    queryString = $"DROP TABLE {table};";
                    command = new MySqlCommand(queryString, connection);
                    command.ExecuteNonQuery();
                }


                // Create each table
                queryString = @"CREATE TABLE testTable (
                        testTitle VARCHAR(10),
                        testAttribute int
                    );";
                command = new MySqlCommand(queryString, connection);
                command.ExecuteNonQuery();


            }

            return "test function ran";
        }
    }

}