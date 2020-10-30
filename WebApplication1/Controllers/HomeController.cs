using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public ActionResult Index()
    {
        ViewBag.Operation = new SelectListItem[]
            {
 new SelectListItem() { Value = "multiply", Text ="multiply" },
 new SelectListItem() { Value = "sum", Text ="sum" },
 new SelectListItem() { Value = "minus", Text ="minus" },
 new SelectListItem() { Value = "division", Text ="division" }
 };
        return View();
    }
    [HttpPost]
    public ActionResult Index(
 double firstNumber,
 double secondNumber,
 string operation)
    {
        ITwoArgumentsCalculator calculator =
        TwoArgumentsFactory.CreateCalculator(operation);
        double result = calculator.Calculate(firstNumber, secondNumber);

        ViewBag.Result = result;
        ViewBag.Operation = new SelectListItem[]
        {
 new SelectListItem() { Value = "multiply", Text ="multiply" },
 new SelectListItem() { Value = "sum", Text ="sum" },
 new SelectListItem() { Value = "minus", Text ="minus" },
 new SelectListItem() { Value = "division", Text ="division" }
        };
        return View();
    }
    @using(Html.BeginForm("Index", "Home", "Post"))
{
 <input type = "number" name="firstNumber" value="0"/>
 <input type = "number" name="secondNumber" value="0"/>
 <select name = "operation" >
 @for(int i = 0; i<ViewBag.Operation.Length; i++)
 {
 <option value = "@ViewBag.Operation[i].Value" >
 @ViewBag.Operation[i].Text
 </ option >
 }
 </ select >
 < input type = "submit" value = "вычислить" />
   
    < p > @ViewBag.Result </ p >
}
    //public class HomeController : Controller
    //{
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    public ActionResult About()
    //    {
    //        ViewBag.Message = "Your application description page.";

    //        return View();
    //    }

    //    public ActionResult Contact()
    //    {
    //        ViewBag.Message = "Your contact page.";

    //        return View();
    //    }
    //}
}