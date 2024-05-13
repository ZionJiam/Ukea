using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UKEA.Data;
using UKEA.Models;

namespace UKEA.Controllers
{
    public class InventoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public InventoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<FurnitureCategory> objCategoryList = _db.FurnitureCategories;
            return View(objCategoryList);
        }
    }
}
