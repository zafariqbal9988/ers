using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DatabaseUtils;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ershad.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController : Controller
    {
        protected readonly AppDbContext context;

        public BaseController(AppDbContext context)
        {
            this.context = context;
        }
    }
}
