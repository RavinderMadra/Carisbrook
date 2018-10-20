using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carisbrook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OurSchool(string page)
        {
            //ViewBag.message = "";
            //if (page == "Principals Message")
            //{
            //    ViewBag.message = "<div class=/"blog-agileinfo blog - info - mdl/">< div class=""col-xs-8 blog-grid-text""><h4>Academic English</h4><h6>Rerum Delectus</h6><p>Sed interdum interdum accumsan. Aenean nec purus ac orci finibus facilisis.In sit amet placerat nisl, in auctor sapien.Donec ultricies faucibus ante in mattis earum rerum hic a sapiente delectus.</p><a class=""button-style"" href=""join.html"">Apply Now</a></div><div class=""col-xs-4 blog-grid-img blog-img-rght""><img src = ""~/Assets/images/c1.jpg"" class=""img-responsive"" alt="""" /></div><div class"clearfix"> </div></div>";
            //}
            //else if (page == "Principals Message")
            //{
            //    ViewBag.message = "<div class=""blog-agileinfo blog - info - mdl"">< div class=""col-xs-8 blog-grid-text""><h4>Academic English</h4><h6>Rerum Delectus</h6><p>Sed interdum interdum accumsan. Aenean nec purus ac orci finibus facilisis.In sit amet placerat nisl, in auctor sapien.Donec ultricies faucibus ante in mattis earum rerum hic a sapiente delectus.</p><a class=""button-style"" href=""join.html"">Apply Now</a></div><div class=""col-xs-4 blog-grid-img blog-img-rght""><img src = ""~/Assets/images/c1.jpg"" class=""img-responsive"" alt="""" /></div><div class=""clearfix""> </div></div>";
            //}
            //else
            //{
            //    ViewBag.message = "<div class=""blog-agileinfo blog - info - mdl"">< div class=""col-xs-8 blog-grid-text""><h4>Academic English</h4><h6>Rerum Delectus</h6><p>Sed interdum interdum accumsan. Aenean nec purus ac orci finibus facilisis.In sit amet placerat nisl, in auctor sapien.Donec ultricies faucibus ante in mattis earum rerum hic a sapiente delectus.</p><a class=""button-style"" href=""join.html"">Apply Now</a></div><div class=""col-xs-4 blog-grid-img blog-img-rght""><img src = ""~/Assets/images/c1.jpg"" class=""img-responsive"" alt="""" /></div><div class=""clearfix""> </div></div>";
            //}
            return View();
        }
        public ActionResult About()
        {
             return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Newsletter()
        {
            return View();
        }

        public ActionResult Sports()
        {
            return View();
        }

        public ActionResult Learning2018()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
                
        public ActionResult Contact()
        {
            return View();
        }
    }
}