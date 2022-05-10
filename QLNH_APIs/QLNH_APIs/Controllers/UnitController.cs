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
    public class UnitController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UnitController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Unit> Get()
        {
            return _context.Unit.ToList();
        }
    }
}
