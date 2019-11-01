using System.Collections.Generic;
using FinalExamTest.Data.Interfaces;
using FinalExamTest.Data.Models;
using FinalExamTest.RabbitMQ;
using Microsoft.AspNetCore.Mvc;

namespace FinalExamTest.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _userRepository.GetAll();

            return new JsonResult(result);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] List<User> users)
        {
            foreach (User user in users)
            {
                var result = _userRepository.Find(user.id);
                if (result == null)
                {
                    _userRepository.Add(user);
                    new PublisherHelper("userLog", user.firstName + " " + user.lastName);
                }
            }

            return new JsonResult(users);
        }
    }
}