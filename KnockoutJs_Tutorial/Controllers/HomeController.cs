using KnockoutJs_Tutorial.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace KnockoutJs_Tutorial.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Save(string data)
        {
            var person = JsonConvert.DeserializeObject<Person>(data); //lấy data person
            var message = string.Format("Save {0} {1} ", person.firstName, person.lastName); //tạo messge lấy đã lưu tên đầu và cuối
            message += string.Format("with {0} friends", person.friends?.Count); //tạo thêm 1 message về số lượng bạn bè 
            
            return Json(new {message});
        }
    }
}
