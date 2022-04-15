using eTicketsHEALTHWEB.Data;
using eTicketsHEALTHWEB.Data.Services;
using eTicketsHEALTHWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Controllers
{
    public class HospitalsController : Controller
    {
        private readonly IHospitalsService _service;
        public HospitalsController(IHospitalsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allHospitals = await _service.GetAllAsync();
            return View(allHospitals);
        }

        //Get Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Hospital hospital)
        {
            if (!ModelState.IsValid)
            {
                return View(hospital);
            }
            await _service.AddAsync(hospital);
            return RedirectToAction(nameof(Index));

        }

        //Get: Details

        public async Task<IActionResult> Details(int id)
        {
            var hospitalDetails = await _service.GetByIdAsync(id);
            if (hospitalDetails == null) return View("NotFound");
            return View(hospitalDetails);
        }

        //Get: Edit

        public async Task<IActionResult> Edit(int id)
        {
            var hospitalDetails = await _service.GetByIdAsync(id);
            if (hospitalDetails == null) return View("NotFound");
            return View(hospitalDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Hospital hospital)
        {
            if (!ModelState.IsValid)
            {
                return View(hospital);
            }
            await _service.UpdateAsync(id, hospital);
            return RedirectToAction(nameof(Index));

        }


        //Get: Delete

        public async Task<IActionResult> Delete(int id)
        {
            var hospitalDetails = await _service.GetByIdAsync(id);
            if (hospitalDetails == null) return View("NotFound");
            return View(hospitalDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hospitalDetails = await _service.GetByIdAsync(id);
            if (hospitalDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }


    }
}
