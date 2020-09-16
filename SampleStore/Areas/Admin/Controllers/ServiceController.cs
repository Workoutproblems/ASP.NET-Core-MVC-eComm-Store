using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SampleStore.DataAccess.Data.Repository.IRepository;
using SampleStore.Models.ViewModels;

namespace SampleStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;
        // Use: to find the root path where images are hosted.
        private readonly IWebHostEnvironment _hostEnvironment;


        [BindProperty]
        public ServiceVM ServVM { get; set; }

        public ServiceController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            ServVM = new ServiceVM()
            {
                Service = new Models.Service(),
                CategoryList = _unitOfWork.Category.GetCategoryListForDropDown(),
                FrequencyList = _unitOfWork.Frequency.GetFrequencyListForDropDown(),
            };
            if (id != null)
            {
                ServVM.Service = _unitOfWork.Service.Get(id.GetValueOrDefault());
            }

            return View(ServVM);
        }

        #region
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Service.GetAll(includeProperties: "Category, Frequency") });
        }
        #endregion
    }
}