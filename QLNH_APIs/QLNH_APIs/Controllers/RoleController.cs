using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Lấy tất cả danh sách
        /// </summary>
        /// <returns>Danh sách Roles</returns>

        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _context.Role.ToList();
        }

        /// <summary>
        /// Lấy Role với Id
        /// </summary>
        /// <returns>Danh sách Role</returns>
        /// <param name="Id"> Tham số là Id của Role</param>
        [HttpGet("Id")]
        
        public Role Get([FromQuery] int Id)
        {
            return _context.Role.Where(role => role.Id == Id).FirstOrDefault();
        }
    ///<summary>
    ///Thêm Role Mới
    /// </summary>
    /// <returns>Role</returns>
    [HttpPost]
    public Role Post([FromQuery] Role Role)
        {
            _context.Role.Add(Role);
            _context.SaveChanges();
            return Role;
        }
    }
}
