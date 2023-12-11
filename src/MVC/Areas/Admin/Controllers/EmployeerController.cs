using Business.Services.implementations;
using Business.Services.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.Admin.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeerController : Controller
    {
        private IEmployeerService EmployeeService { get; }
        private ISocialMediaAccountService SocialMediaService { get; }
        private IEmployeePositionService EmployeePositionService { get; }
        public EmployeerController(IEmployeerService employeeService, ISocialMediaAccountService socialMediaService, IEmployeePositionService employeePositionService)
        {
            EmployeeService = employeeService;
            SocialMediaService = socialMediaService;
            EmployeePositionService = employeePositionService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await EmployeeService.GetAllEmployees());
        }

        public async Task<IActionResult> Create()
        {

            CreateViewModel model = new CreateViewModel()
            {
                Employeer = new Employeer(),
                SocialMediaAccounts = await SocialMediaService.GetAllSocialMedias(),
                EmplooyeePositions = await EmployeePositionService.EmployeePositionRepo.GetAllAsync()
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel newEmp)
        {
            if (!ModelState.IsValid) return View(newEmp);

            //await EmployeeService.CreateNewEmployee(newEmp);

            return RedirectToAction("Index");
        }
    }
}
