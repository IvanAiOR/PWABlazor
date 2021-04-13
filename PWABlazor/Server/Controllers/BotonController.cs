using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PWABlazor.Server.Data;
using PWABlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWABlazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotonController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BotonController(AppDbContext context)
        {
            this._context = context;
        }
        [HttpGet(Name ="boton")]
        public async Task<ActionResult<Boton[]>> Index()
        {
            return await _context.Boton.OrderByDescending(b=>b.Fecha).ToArrayAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post(Boton btn)
        {
            try
            {
                await _context.Boton.AddAsync(btn);
                await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                
            }

            return new JsonResult(true);
        }
    }
}
