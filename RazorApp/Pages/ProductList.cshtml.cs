using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp.Models;

namespace RazorApp.Pages
{
    public class ProductListModel : PageModel
    {
        private ProductContext _db;

        public ProductListModel(ProductContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }



       
        public JsonResult OnGetJson()
        {
            var plist = _db.Products.ToList();

            return new JsonResult(plist);
        }
    }
}
