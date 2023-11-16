using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreProcedure.Data;
using StoreProcedure.Models;

namespace StoreProcedure.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext context;

        public StoreController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var data = context.Wendors.FromSqlRaw("exec spGetAllWendorList").ToList();  //fromsqlraw :- use in this method for return entity or data return from table
            return View(data);      //data=object;
        }
        //insert data of wendor
       

        public IActionResult Insert_Wendor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert_Wendor(Wendor model)
        {
            try
            {
                if(ModelState.IsValid) 
                {
                    context.Database.ExecuteSqlRaw($"spInsert_Wendor{model.Name},{model.gender},{model.city},{model.pincode}");
                    TempData["Success"] = "Record Is sucessfully inserted";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

            }
            return View();
        }
    }
}
