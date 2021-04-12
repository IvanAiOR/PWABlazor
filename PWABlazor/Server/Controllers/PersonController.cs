using Microsoft.AspNetCore.Mvc;
using PWABlazor.Server.Data;
using PWABlazor.Shared.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PWABlazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase

    {
        private readonly AppDbContext _context;
        public PersonController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> Get()
        {
            return await _context.People.ToListAsync(); 
        }
    }
}
