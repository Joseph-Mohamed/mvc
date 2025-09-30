using Demo.BLL.DTO;
using Demo.BLL.Servies.Interfaces;
using Demo.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{

    public class DepartementController(IDepartementServices _departementServices, IWebHostEnvironment _env, ILogger<DepartementController> _logger) : Controller
    {

        // baseurl / departement / index

        #region Index
        [HttpGet]
        public IActionResult Index()
        {
            var deptar = _departementServices.GetAllDepartement();
            return View(deptar);
        }
        #endregion


        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDepartementDTO createDepartementDTO)
        {
            //ModelState.AddModelError("code", "code must be greater than 100");
            //ModelState.AddModelError(string.Empty, "Departement can not be created");
            if (ModelState.IsValid) //server side validation
            {
                //departement ==> mangerid [employee 11 = 5]
                //attribute mangeerid [range(1-100)]
                //magerid ==> 6

                try
                {
                    int res = _departementServices.AddDepartement(createDepartementDTO);
                    if (res > 0)
                    {
                        return View("index", _departementServices.GetAllDepartement()); // *************
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Departement can not be created");
                    }


                }
                catch (Exception ex)
                {
                    //development ==> action , log error in consloe , view
                    if (_env.IsDevelopment())
                    {
                        _logger.LogError($"Departement can not be created becusea :{ex.Message}");
                    }
                    else
                    {
                        _logger.LogError($"Departement can not be created becuse {ex}");
                    }
                    //deployement ==> action , log error in file , db , return view(ERROR)
                }
            }

            return View(createDepartementDTO);
        }

        #endregion


        #region Details

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest(); //400
            var dep = _departementServices.GetDepartementById(id.Value);
            if (dep is null)
            {
                return NotFound();

            }
            return View(dep);
        }
        #endregion


        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id.HasValue) return BadRequest(); // 400
            var dep = _departementServices.GetDepartementById(id.Value);
            if (dep is null) return NotFound(); // 404
            var depVM = new DepartementEditViewModel()
            {
                Code = dep.Code,
                Name = dep.Name,
                Descrption = dep.Description,
                CreatedOn = dep.CreatedOn.HasValue ? dep.CreatedOn.Value : default
                // default value 1/1/0001

            };
            return View(depVM);
        }

        [HttpPost]


        public IActionResult Edit([FromRoute] int? id, DepartementEditViewModel departementEditViewModel)
        {
            if (!ModelState.IsValid)
            {
                try
                {
                    var updateDepDTO = new UpdateDepartementDTO()
                    {
                        Code = departementEditViewModel.Code,
                        Decription = departementEditViewModel.Descrption,
                        Name = departementEditViewModel.Name,
                        DateOfCreation = departementEditViewModel.CreatedOn
                    };
                    var res = _departementServices.UpdateDepartement(updateDepDTO);
                    if (res > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Departement can not be updated");
                    }
                }

                catch (Exception ex)
                {
                    //development ==> action , log error in consloe , view
                    if (_env.IsDevelopment())
                    {
                        _logger.LogError($"Departement can not be created becusea :{ex.Message}");
                    }
                    else
                    {
                        _logger.LogError($"Departement can not be created becuse {ex}");
                    }
                    //deployement ==> action , log error in file , db , return view(ERROR)
                }
            }
            return View(departementEditViewModel);

        }


        #endregion


        #region Delete
        // get ==> render the view

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var dep = _departementServices.GetDepartementById(id.Value);
            if (dep is null) return NotFound();
            return View(dep);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();

            try
            {
                bool isDeleted = _departementServices.DeleteDepartement(id);
                if (isDeleted) return RedirectToAction(nameof(Index));
                else
                {
                    ModelState.AddModelError(string.Empty, "Departement can not be deleted");
                }

            }
            catch (Exception ex)
            {
                //development ==> action , log error in consloe , view
                if (_env.IsDevelopment())
                {
                    _logger.LogError($"Departement can not be created becusea :{ex.Message}");
                }
                else
                {
                    _logger.LogError($"Departement can not be created becuse {ex}");
                }
                //deployement ==> action , log error in file , db , return view(ERROR)

            }
            return RedirectToAction(nameof(Delete), new { id });
        }
        #endregion
    }
}
