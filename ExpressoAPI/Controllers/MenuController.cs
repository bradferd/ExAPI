using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpressoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public MenuController(ExpressoDbContext expressoDbContext)
        {
            expressoDbContext = _expressoDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _expressoDbContext.Menus;
            return Ok(menus);
        }
    }
}