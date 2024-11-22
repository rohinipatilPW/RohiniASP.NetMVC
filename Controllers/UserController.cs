using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RohiniASP.NetMVC.Data;
using RohiniASP.NetMVC.Models;
using RohiniASP.NetMVC.Models.Entities;

namespace RohiniASP.NetMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDBContext dbContext;

        public UserController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //[HttpGet]
        //public IActionResult AddUSer()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddUser(UserModel viewModel)
        {
            Console.WriteLine("add user-----------------------");
            var user = new User
            {
                Name = viewModel.Name,
                Email = viewModel.Email
            };
             dbContext.Users.AddAsync(user);
             dbContext.SaveChangesAsync();
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

        public string GetUserName(int userID)
        {
            if (_users.ContainsKey(userID))
            {
                return _users[userID];
            }
            else
            {
                return "User not found";
            }
        }

        public void RemoveUser(int userID)
        {
            if (_users.ContainsKey(userID))
            {
                _users.Remove(userID);
                Console.WriteLine("User removed successfully.");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

    }
}
