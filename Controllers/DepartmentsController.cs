using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebSales.Models;

namespace WebSales.Controllers;

public class DepartmentsController : Controller
{

    public IActionResult Index()
    {
        List<Department> Departments = new();
        Departments.Add(new  Department(1, "Eletronics"));
        Departments.Add(new Department(2, "Fashion"));

        return View(Departments);
    }

}