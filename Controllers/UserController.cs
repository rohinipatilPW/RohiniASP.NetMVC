using Microsoft.AspNetCore.Mvc;

namespace RohiniASP.NetMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }


        private Dictionary<int, string> _users = new Dictionary<int, string>();

        public void AddUserDetails(int userId, string Name)
        {
            if (_users.ContainsKey(userId))
            {
                _users[userId] = Name;
            }
            else
            {
                _users.Add(userId, Name);
            }
        }
    }
}
