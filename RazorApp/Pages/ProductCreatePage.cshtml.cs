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

        // Json bir result döndüreceksek dönüþ tipimiz JsonResult olmalýdýr. Javascript Objesi döner.
        // Formdan deðil js üzerinden veri göndereceðimiz için BindProperty kullanmadýk. JS ile veriyi gönderiken göndereceðimiz nesneyi method içerisine parametre olarak tanýmlýyoruz.

        //serialization

        public JsonResult OnPost([FromBody] Product product)
        {
            _db.Products.Add(product);
            var result = _db.SaveChanges() > 0 ? "Baþarýlý" : "Tekrar deneyiniz";
            return new JsonResult(result);
        }
    }
}
