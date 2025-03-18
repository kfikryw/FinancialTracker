using Microsoft.AspNetCore.Mvc;
using SpendSmart.Models;
using System.Collections.Generic;
using System.Linq;
namespace SpendSmart.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MyDbContext _context;
        public EmployeeController(MyDbContext context)
        {
            _context = context;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var allItems = _context.Employee.ToList();
            return View(allItems);
        }

        public ActionResult Create()
        {
            
            return View(new Employee());
           // return View(employee);
        }
        [HttpPost]
        public ActionResult Create(Employee employee){
            if(ModelState.IsValid){
                _context.Employee.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Edit(int? id){
            if(id != null){
                var itemInDb = _context.Employee.FirstOrDefault(x => x.Id == id);
                return View(itemInDb);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Employee employee){
            _context.Employee.Update(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id){
            if(id != null){
                var deleteItemInDb = _context.Employee.FirstOrDefault(x => x.Id == id);
                return View(deleteItemInDb);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(int id){
            var deleteItem = _context.Employee.FirstOrDefault(x => x.Id == id);
            _context.Employee.Remove(deleteItem);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }

    }
}
