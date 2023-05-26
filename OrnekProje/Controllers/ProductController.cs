using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;
using OrnekProje.Models.ViewModels;
using System.Text.Json;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //  var products = new List<Product>
            //{
            //    new Product{ Id = 1, ProductName = "A Product" , Quantity = 1},
            //    new Product{ Id = 2, ProductName = "B Product" , Quantity = 1},
            //    new Product{ Id = 3, ProductName = "C Product" , Quantity = 1}
            //};
            #region Model Bazlı Veri Gönderimi
            // return View(products);
            #endregion
            #region Veri Taşıma Kontrolleri

            #region  1- ViewBag

            //ViewBag.product = products;
            //return View();

            #endregion

            #region 2-ViewData

            //ViewData["productNew"] = products;
            //return View();

            #endregion

            #region 3- TempData

            //TempData["productNew"] = JsonSerializer.Serialize(products);

            return RedirectToAction("Index2", "product");


            #endregion




            #endregion

        }

        public IActionResult Index2()
        {

            var data = TempData["productNew"].ToString();

            List<Product> newProduct = JsonSerializer.Deserialize<List<Product>>(data);

            return View();
        }

        public IActionResult GetProducts()
        {
            Product product = new Product()
            {
                ////Id=1,
                //ProductName = "A",
                //Quantity = 100
            };
            User user = new User()
            {
                Id = 1,
                Name = "B"
            };


            UserProduct userProduct = new UserProduct()
            {
                User = user,
                Product = product
            };


            return View(userProduct);
        }
        public IActionResult TagHelperOrnek()
        {
            return View();
        }

        public class GelecekVeri
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
        }






        public IActionResult CreateProduct()
        {         
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct( Product product ) 
        {

            if (!ModelState.IsValid)
            {

                var state = ModelState.ToList();  
                
                return View(product);
                

            }
            
            return View();

        }


      


    }
}
