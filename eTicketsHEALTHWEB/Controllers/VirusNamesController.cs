using eTicketsHEALTHWEB.Data;
using eTicketsHEALTHWEB.Data.Services;
using eTicketsHEALTHWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Controllers
{
    public class VirusNamesController : Controller
    {
        private readonly IVirusNamesService _service;
        public VirusNamesController(IVirusNamesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allVirusNames = await _service.GetAllAsync(n => n.Hospital);
            return View(allVirusNames);
        }


        public async Task<IActionResult> Filter(string searchString)
        {
            var allVirusNames = await _service.GetAllAsync(n => n.Hospital);

            if(!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allVirusNames.Where(n => n.Name.Contains(searchString) || n.Description.Contains
                  (searchString)).ToList();
                return View("Index", filteredResult);
            }

            return View("Index", allVirusNames);
        }


        //GET: VirusNames/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var VirusNameDetail = await _service.GetVirusNameByIdAsync(id);
            return View(VirusNameDetail);
        }

        //GET: VirusNames/Create
        public async Task< IActionResult > Create()
        {
            var VirusNameDropData = await _service.GetNewVirusDropValues();

            ViewBag.HospitalId = new SelectList(VirusNameDropData.Hospitals, "Id", "Name");
            ViewBag.CompanyId = new SelectList(VirusNameDropData.Companies, "Id", "FullName");
            ViewBag.DoctorId = new SelectList(VirusNameDropData.Doctors, "Id", "FullName");
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(VirusNameVM vaccination)
        {
            if(!ModelState.IsValid)
            {
                var VirusNameDropData = await _service.GetNewVirusDropValues();

                ViewBag.HospitalId = new SelectList(VirusNameDropData.Hospitals, "Id", "Name");
                ViewBag.CompanyId = new SelectList(VirusNameDropData.Companies, "Id", "FullName");
                ViewBag.DoctorId = new SelectList(VirusNameDropData.Doctors, "Id", "FullName");

                return View(vaccination);
            }

            await _service.AddNewVaccinationAsync(vaccination);
            return RedirectToAction(nameof(Index));
        }

        //GET: VirusNames/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var VirusNameDetails = await _service.GetVirusNameByIdAsync(id);
            if (VirusNameDetails == null) return View("Not Found");

            var response = new VirusNameVM()
            {
                Id = VirusNameDetails.Id,
                Name = VirusNameDetails.Name,
                Description = VirusNameDetails.Description,
                Price = VirusNameDetails.Price,
                StartDate=VirusNameDetails.StartDate,
                EndDate=VirusNameDetails.EndDate,
                ImageURL = VirusNameDetails.ImageURL,
                VirusNameCategory = VirusNameDetails.VirusNameCategory,
                HospitalId = VirusNameDetails.HospitalId,
                CompanyId = VirusNameDetails.CompanyId,
                DoctorIds = VirusNameDetails.Doctors_VirusNames.Select(n => n.DoctorId).ToList(),

            };

            var VirusNameDropData = await _service.GetNewVirusDropValues();

            ViewBag.HospitalId = new SelectList(VirusNameDropData.Hospitals, "Id", "Name");
            ViewBag.CompanyId = new SelectList(VirusNameDropData.Companies, "Id", "FullName");
            ViewBag.DoctorId = new SelectList(VirusNameDropData.Doctors, "Id", "FullName");
            return View(response);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, VirusNameVM vaccination)
        {
            if (id != vaccination.Id) return View("Not Found");

            if (!ModelState.IsValid)
            {
                var VirusNameDropData = await _service.GetNewVirusDropValues();

                ViewBag.HospitalId = new SelectList(VirusNameDropData.Hospitals, "Id", "Name");
                ViewBag.CompanyId = new SelectList(VirusNameDropData.Companies, "Id", "FullName");
                ViewBag.DoctorId = new SelectList(VirusNameDropData.Doctors, "Id", "FullName");

                return View(vaccination);
            }

            await _service.UpdateVirusNameAsync(vaccination);
            return RedirectToAction(nameof(Index));
        }

    }
}
