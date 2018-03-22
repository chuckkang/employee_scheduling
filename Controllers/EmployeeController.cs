using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using employee_scheduling.Models;
using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Identity;
namespace employee_scheduling
{
	public class EmployeeController : Controller
	{	private DbConnector db;
		public EmployeeController(DbConnector connect){
			db = connect;
			ViewBag.Layout = "~/Views/Shared/_EmployeeLayout";
		}

		[HttpGet, HttpPost]
		// [ValidateAntiForgeryToken] // required to secure the form
		[Route("employee")]
		public IActionResult Index(EmployeeModel _employee)
		{	// show a blank form
			Console.WriteLine(">>>>>>>>>>>>>>>>>we are in the employee controller");
			Console.WriteLine(HttpContext.Request.ToString() + ">>>>>>>>>>>>");
			// PasswordHasher<string> asdf = new PasswordHasher<string>();
			ViewData["Errors"] = "";
			if (TryValidateModel(_employee) ==false)
			{
				ViewData["Errors"] = ModelState.Values;
				return View(_employee);
			}
			else{
				return RedirectToAction("add");
			}
		
		}

		[HttpGet]
		[Route("employee/add")]
		public IActionResult Add()
		{
			ViewData["Message"] = "SUCCESS";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View();
		}
	}
}
