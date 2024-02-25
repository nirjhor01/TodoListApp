using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public ActionResult Save(Layer layer)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\localDB; Initial Catalog = Todoo; Integrated Security = true;");
            conn.Open();
            string que = "INSERT INTO info(id,TaskName,Description,status)VALUES('" + layer.id + "','" + layer.TaskName + "','" + layer.Description + "','" + layer.Status + "')";
            SqlCommand cmd = new SqlCommand(que, conn);
           // try
           // {
               
            int cnt = cmd.ExecuteNonQuery();
            string s = "";
            if (cnt > 0)
            {
                s = "successful";
            }
            else
            {
                s = "Unsuccessful";
            }
            ViewBag.msg = s;
            return View();
               
            //}
            //catch (Exception ex)
            //{
             //   return "Exception occured";
            //}
          
        }
        public ActionResult SaveAll()
        {
            return View();
        }
        public ActionResult Rdex()
        {
            Layer layer = new Layer();
            layer.TaskName = "Nirjhor";
            layer.Description = "abcd";
            layer.Status = "ok";
            ViewBag.msg = layer;

            return View();
        }
        public ActionResult GetAll()
        {
            return View();
        }
       
    }
}
