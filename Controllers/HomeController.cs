using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagement.Models;
using EmpManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: /<controller>/
        
        //add method
        public ViewResult Index()
        {
            var model=_employeeRepository.GetAllEmployees();
            return View(model);
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel hdvm = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };
            
            return View(hdvm);
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}
