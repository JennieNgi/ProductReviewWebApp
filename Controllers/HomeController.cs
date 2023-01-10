using System;
using Microsoft.AspNetCore.Mvc;
using Boilerplate.Models;

namespace Boilerplate.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            MyModel myModel = new MyModel();
            myModel.ReadReview();
            return View(myModel);
        }
  
        public IActionResult Add(MyModel myModel, int rating, string firstName, string lastName, string comment, string date) {
            myModel.AddReview(rating, firstName, lastName, comment, date);
            myModel.ReadReview();
            return RedirectToAction("Index");
        } 
    }
}