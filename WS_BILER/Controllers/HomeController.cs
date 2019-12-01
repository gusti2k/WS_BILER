using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using WS_BILER.Models;

namespace WS_BILER.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public IActionResult AddContent()
        //{
        //    var url = "https://www.nationsonline.org/oneworld/country_code_list.htm";
        //    var web = new HtmlWeb();
        //    var doc = web.Load(url);

        //    var nodes = doc.DocumentNode.Descendants().Where(n => n.HasClass("border1"));

        //    try
        //    {
        //        using (var con = _context)
        //        {
        //            foreach (var node in nodes)
        //            {
        //                var country = node.Descendants().Where(n => n.HasClass("abs")).FirstOrDefault().InnerText;

        //                con.Add(new CountryModel
        //                {
        //                    Country = country
        //                });
        //                con.SaveChanges();
        //            }
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        //throw;
        //    }
        //    return RedirectToAction(nameof(Index));
        //}
        //public IActionResult DeleteContent()
        //{
        //    using (var con = _context)
        //    {
        //        con.Database.ExecuteSqlCommand("delete from CountryModel");
        //    }
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
