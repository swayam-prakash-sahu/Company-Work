using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Security.AccessControl;
using System.Data.SqlClient;


namespace TodoWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoAppController : ControllerBase
    {
        private IConfiguration _configuration;

        public TodoAppController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetNotes")]

        public JsonResult GetNotes()
        {
            string query = "select * from dbo.notes";
            DataTable tables = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("todoDBCon");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDatasource))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    tables.Load(myReader);  
                    myReader.Close();
                    myCon.Close();

                }
            }
            return new JsonResult(tables);
        }
        
    }
}
