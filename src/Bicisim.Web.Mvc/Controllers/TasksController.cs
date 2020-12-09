using Bicisim.Controllers;
using Bicisim.Tasks;
using Bicisim.Tasks.DTO;
using Bicisim.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bicisim.Web.Controllers
{
    public class TasksController : BicisimControllerBase
    {
        private readonly ITaskAppService _taskAppService;
        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }


        public ActionResult Index( )
        {
            var output =  _taskAppService.GetAll();
            var model = new IndexViewModel(output.Items);
            return View(model);
        }
    }
}
