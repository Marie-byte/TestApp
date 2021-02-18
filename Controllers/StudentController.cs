using Microsoft.AspNetCore.Mvc;
using TestApplication.Models;
using System.Collections.Generic;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> clas = new List<Students>();
            clas.Add(new Students(){Id = 120, First_Name = "Gabriel", Last_Name = "Johnson", Age = 10});
            clas.Add(new Students(){Id = 962, First_Name = "Adam",Last_Name = "Williams", Age = 15});
            clas.Add(new Students(){Id = 388, First_Name = "Raphaël",Last_Name = "Brown", Age = 20});
            clas.Add(new Students(){Id = 447, First_Name = "Louis",Last_Name = "Jones", Age = 25});
            clas.Add(new Students(){Id = 530, First_Name = "Arthur",Last_Name = "Miller", Age = 30});
            return clas;
        }

        [HttpGet]
        public List<Students> GetClass()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetStudentwithId(int id)
        {
            var student = GetStudents().Find(x => x.Id == id);
            if(student != null)
            {
                return student;
            }
            return NotFound();
        }
    }
}