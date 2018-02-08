using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {   // example of Null Conditional Operator ? combined with Coalescing Operator ?? 
        //        string name = p?.Name ?? "<none>";
        //        decimal? price = p?.Price ?? 0;
        //        string relatedName = p?.Related?.Name ?? "<none>";
        //        string category = p?.Category;
        //        bool? inStock = p?.InStock;
        //        results.Add($"Name: {name}, Price: {price}, Related: {relatedName}, Category: {category}, In Stock: {inStock}");
        //    }

        //    return View(results);
        //}
        //using the extention method Twice on a string object
        //public ViewResult Index()
        //{   
        //    string name = "Bob";
        //    var extMeth = name.Twice();
        //    return View("Index", new string[] {extMeth, extMeth});
        //}


//        public ViewResult Index()
//        {
//            var querySample = from item in Product.AnonPoductList select item.Name;
//            return View(querySample);
//        }

        /*ASYNC METHODS*/
//        public async Task<long?> Index()
//        {
//            long? length=  await MyAsyncMethods.GetPageLength();
//            return length;
//        }
//        public async Task<string> Index()
//        {
//            string content=  await MyAsyncMethods.GetPageAsString();
//            return content;
//        }

        public IActionResult Index()
        {
            var content = MyAsyncMethods.GetPageAsString().Result["results"];
            
            return View(content);
        }
    }

}