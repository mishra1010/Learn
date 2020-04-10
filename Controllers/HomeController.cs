using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagement.Controllers
{
    public class HomeController: Controller
    {
        public JsonResult Index()
        {
            return this.Json(new { id=1, name="Deepak"});
        }
    }
}
