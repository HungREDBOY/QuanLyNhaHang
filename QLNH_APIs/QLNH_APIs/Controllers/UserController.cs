using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
         {
            return _context.User.ToList();
        }
        /// <summary>
        /// Lấy Role với Id
        /// </summary>
        /// <returns>Danh sách Role</returns>
        /// <param name="Id"> Tham số là Id của Role</param>
        [HttpGet("Id")]

        public Object Get([FromQuery] int Id)
        {
            return _context.User.Where(user => user.Id == Id).Select(s=> new
            {
                Id=s.Id,
                UserName=s.UserName
            }).FirstOrDefault();
        }
        ///<summary>
        ///Thêm Role Mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]  
        public User Post([FromQuery] User User)
        {
            _context.User.Add(User);
            _context.SaveChanges();
            return User;
        }
    }
}
