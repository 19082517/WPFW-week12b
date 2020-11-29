using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPFW_week12b.Data;
using WPFW_week12b.Models;

namespace WPFW_week12b.Controllers
{
    public class BaseController : Controller
    {
        protected readonly MijnContext context;

        public BaseController(MijnContext context)
        {
            this.context = context;
        }

        public override void OnActionExecuting(ActionExecutingContext c)
        {   
            ((BaseController)c.Controller).ViewData["OldestStudents"] = context.students.OrderByDescending(s => s.age).Take(3).ToList();
            ((BaseController)c.Controller).ViewData["OrderByFirstName"] = context.students.OrderBy(s => s.FirstName).Take(3).ToList();
        }
    }
}
