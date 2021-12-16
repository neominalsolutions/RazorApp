using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp.Models;

namespace RazorApp.Pages
{
    public class ProductCreatePageModel : PageModel
    {
        private ProductContext _db;
        public ProductCreatePageModel(ProductContext db)
        {
            _db = db;
        }


     

        public void OnGet()
        {
        }

        // Json bir result d�nd�receksek d�n�� tipimiz JsonResult olmal�d�r. Javascript Objesi d�ner.
        // Formdan de�il js �zerinden veri g�nderece�imiz i�in BindProperty kullanmad�k. JS ile veriyi g�nderiken g�nderece�imiz nesneyi method i�erisine parametre olarak tan�ml�yoruz.

        //serialization

        public JsonResult OnPost([FromBody] Product product)
        {
            _db.Products.Add(product);
            var result = _db.SaveChanges() > 0 ? "Ba�ar�l�" : "Tekrar deneyiniz";
            return new JsonResult(result);
        }
    }
}
