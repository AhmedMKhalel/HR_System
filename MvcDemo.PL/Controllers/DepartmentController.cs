using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.BLL;
using MvcDemo.BLL.Interfaces;
using MvcDemo.DAL.Entities;

namespace MvcDemo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(/*IDepartmentRepository departmentRepository*/IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_departmentRepository = departmentRepository;
        }
        public async Task<IActionResult> Index()
        {
            //view data => key-value Dict --Current Request مش بتيجي معايا بعد الريكويست
            ViewData["Message"] = "Hello From Department";


            //view data => key-value Dict --Current Request مش بتيجي معايا بعد الريكويست
            ViewBag.Message = "Hello From Department";



            var departments =await _unitOfWork.DepartmentRepository.GetAll();
            return View(departments);
        }
        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        public async Task<IActionResult> Create(Department department)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.DepartmentRepository.Add(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            var department = await _unitOfWork.DepartmentRepository.Get(id);
            if (department == null)
                return NotFound();
            return View(department);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            var department = await _unitOfWork.DepartmentRepository.Get(id);
            if (department == null)
                return NotFound();
            return View(department);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id , Department department)
        {
            if (id != department.Id)
                return NotFound();
            if (ModelState.IsValid)
            {

                try
                {
                    await _unitOfWork.DepartmentRepository.Update(department);
                    return 
                        RedirectToAction("Index");
                }
                catch (Exception)
                {
                    return View(department);
                }
            }
            return View(department);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return NotFound();
            var department = await _unitOfWork.DepartmentRepository.Get(id);

            if (department is null)
                return NotFound();

            await _unitOfWork.DepartmentRepository.Delete(department);
            return RedirectToAction("Index");


        }

    }
}
