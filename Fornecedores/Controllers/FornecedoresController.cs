using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores.Controllers
{
    public class FornecedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
