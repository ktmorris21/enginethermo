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
            string connectionString = "Persist Security Info=False;database=EngineThermo;server=167.99.104.21;user id=root;Password=21Ktm4154^";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string cmdString = @"CREATE TABLE IF NOT EXISTS testing (
                    testString VARCHAR(255)
                )";
                MySqlCommand cmd = new MySqlCommand(cmdString, conn);
                cmd.ExecuteNonQuery();
            }

            return "test function ran";
        }
    }

}