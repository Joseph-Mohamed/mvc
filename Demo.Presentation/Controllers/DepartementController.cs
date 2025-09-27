using Demo.BLL.Servies.Classes;
using Demo.BLL.Servies.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{

    public class DepartementController : Controller
    {
        private readonly IDepartementServices _departementServices;

        public DepartementController(IDepartementServices departementServices)
        {
            _departementServices = departementServices;
        }
        // baseurl / departement / index

        public IActionResult Index()
        {
            var dept = _departementServices.GetAllDepartement();
            return View(dept);
        }
    }
}
