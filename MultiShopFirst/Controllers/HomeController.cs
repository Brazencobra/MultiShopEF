using Microsoft.AspNetCore.Mvc;
using MultiShopFirst.Models;

namespace MultiShopFirst.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Slide> slides = new List<Slide>() 
            {
                new Slide
                {
                    Name = "Kisi geyimleri",
                    Description = "En bomba kisi geyimleri burada",
                    ImageUrl = "carousel-1.jpg"
                },
                new Slide
                {
                    Name = "Qadin geyimleri",
                    Description = "En bomba Qadin geyimleri burada",
                    ImageUrl = "carousel-2.jpg"
                },
                new Slide
                {
                    Name = "Usaq geyimleri",
                    Description = "En bomba Usaq geyimleri burada",
                    ImageUrl = "carousel-3.jpg"
                },
            };
            ViewBag.Slides = slides;
            List<Category> categories = new List<Category>()
            { 
                new Category
                {
                    Name = "Qadin geyimleri",
                    ProductCount = 25,
                    ImageUrl = "cat-1.jpg"
                },
                new Category
                {
                    Name = "Aksesuarlar",
                    ProductCount = 45,
                    ImageUrl = "cat-2.jpg"
                },
                new Category
                {
                    Name = "Ayaqqabilar",
                    ProductCount = 55,
                    ImageUrl = "cat-3.jpg"
                },
                new Category
                {
                    Name = "Nelerse",
                    ProductCount = 15,
                    ImageUrl = "cat-4.jpg"
                },
            };
            ViewBag.Categories = categories;
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Name = "Dyson Kamera",
                    Price = 150,
                    DeletedPrice = 200,
                    Review = 150,
                    ImageUrl = "product-1.jpg"
                },
                new Product
                {
                    Name = "Goy Kofta",
                    Price = 50,
                    DeletedPrice = 80,
                    Review = 95,
                    ImageUrl = "product-2.jpg"
                },
                new Product
                {
                    Name = "Isiq lampasi",
                    Price = 100,
                    DeletedPrice = 130,
                    Review = 50,
                    ImageUrl = "product-3.jpg"
                },
                new Product
                {
                    Name = "Nike ayaqqabi",
                    Price = 50,
                    DeletedPrice = 90,
                    Review = 140,
                    ImageUrl = "product-4.jpg"
                },
            };
            return View(products);
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

    }
}
