using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        
        // GET: /Movies/Random
        public ActionResult Random()
        {
            //create instance of movie model 
            var movie= new Movie(){Name = "Shrek!"};
           
            //create List of customers 
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer 2"}
            };
            //create view model object 
            var viewModel = new RandomMovieViewModel
            {
                //initialise the movie and customer properties 
                Movie=movie,
                Customers = customers
            };
                //pass data to the view 
            return View(viewModel);//the best approch dont use the viewData or view Bag approch 
            }

        //create new action 
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);//pramator calles id 
        }

        //route atrribiutes and apply url templent 
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]//applay regular expresion 
        public ActionResult ByRealiseDate(int year, int month)
            //this action takes two pramators 
        {
            return Content(year +"/" + month);//return content with year and month 

        }

	}

}