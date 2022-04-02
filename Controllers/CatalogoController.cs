using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using appcomics.Models;
using appcomics.Data;
using Microsoft.EntityFrameworkCore;


namespace appcomics.Controllers
{
    public class CatalogoController: Controller
    {
        private readonly ILogger<CatalogoController> _logger;
        private readonly ApplicationDbContext _context;

        public CatalogoController(ApplicationDbContext context,
            ILogger<CatalogoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProductos select o;
            return View(await productos.ToListAsync());
        }
    }
}