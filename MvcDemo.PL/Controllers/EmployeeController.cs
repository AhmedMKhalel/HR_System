using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MvcDemo.BLL;
using MvcDemo.BLL.Interfaces;
using MvcDemo.DAL.Entities;
using MvcDemo.PL.Helper;
using MvcDemo.PL.Models;

namespace MvcDemo.PL.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly IEmployeeRepository _employeeRepository;
        //private readonly IDepartmentRepository _isDepartmentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(/*IEmployeeRepository employeeRepository,IDepartmentRepository isDepartmentRepository*/ 
            IUnitOfWork unitOfWork, IMapper mapper )
        {
            //_employeeRepository = employeeRepository;
            //_isDepartmentRepository = isDepartmentRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(string SearchValue="")
        {
            if (string.IsNullOrEmpty(SearchValue))
            {
                var employees = await _unitOfWork.EmployeeRepository.GetAll();
                //var mappedEmployees = _mapper.Map<IEnumerable< Employee>,IEnumerable<EmployeeViewModel>>( employees);
                var mappedEmployees = _mapper.Map<IEnumerable<EmployeeViewModel>>(employees);
                return View(mappedEmployees);
            }
            else
            {
                var employees = await _unitOfWork.EmployeeRepository.Search(SearchValue);
                //var mappedEmployees = _mapper.Map<IEnumerable< Employee>,IEnumerable<EmployeeViewModel>>( employees);
                var mappedEmployees = _mapper.Map<IEnumerable<EmployeeViewModel>>(employees);
                return View(mappedEmployees);

            }

        }



        [HttpGet]
        public async Task<IActionResult> Create() 
        {
            ViewBag.Departments = await _unitOfWork.EmployeeRepository.GetAll(); 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                //var employeeViewModel = new EmployeeViewModel()
                //{
                //    Id = employee.Id,
                //    Name = employee.Name,
                //    Address = employee.Address,
                //    Age = employee.Age
                //}
                employeeViewModel.ImageUrl = DocumentSetting.UploadFile(employeeViewModel.Image, "Images");
                var mappedEmployee = _mapper.Map<Employee>(employeeViewModel);
                await _unitOfWork.EmployeeRepository.Add(mappedEmployee);
                return RedirectToAction("Index");
            }
            return View(employeeViewModel);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            var employee = await _unitOfWork.EmployeeRepository.Get(id);
            var departmentName = await _unitOfWork.EmployeeRepository.GetDepartmentNameByEmployeeId(id);
            var mappedEmployee = _mapper.Map<EmployeeViewModel>(employee);
              

            //var departmentName =  await _employeeRepository.GetDepartmentNameByEmployeeId(id);

            if (employee == null)
                return NotFound();
            return View(mappedEmployee);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            var employee = await _unitOfWork.EmployeeRepository.Get(id);
            var mappedEmployee = _mapper.Map<EmployeeViewModel>(employee);

            if (employee == null)
                return NotFound();
            return View(mappedEmployee);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, EmployeeViewModel employeeViewModel)
        {
            if (id != employeeViewModel.Id)
                return NotFound();
            if (ModelState.IsValid)
            {

                try
                {
                    employeeViewModel.ImageUrl = DocumentSetting.UploadFile(employeeViewModel.Image, "Images");

                    var mappedEmployee = _mapper.Map<Employee>(employeeViewModel);
                    await _unitOfWork.EmployeeRepository.Update(mappedEmployee);
                    return
                        RedirectToAction("Index");
                }
                catch (Exception)
                {
                    return View(employeeViewModel);
                }
            }
            return View(employeeViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return NotFound();
            var employee = await _unitOfWork.EmployeeRepository.Get(id);

            if (employee is null)
                return NotFound();
            DocumentSetting.DeleteFile(employee.ImageUrl,"Images");
            await _unitOfWork.EmployeeRepository.Delete(employee);
            return RedirectToAction("Index");


        }

        //public async Task<IActionResult> Detail(int id)
        //{

        //}
    }
}
