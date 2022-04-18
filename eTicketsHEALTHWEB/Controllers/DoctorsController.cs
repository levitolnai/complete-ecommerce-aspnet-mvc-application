using eTicketsHEALTHWEB.Data;
using eTicketsHEALTHWEB.Data.Services;
using eTicketsHEALTHWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IDoctorsService _service;
        public int id;


        public DoctorsController(IDoctorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Doctors/Create - well no data manipulation don"t need async Task
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Doctor doctor)
        {
            if(!ModelState.IsValid)
            {
                return View(doctor);
            }
            await _service.AddAsync(doctor);
            return RedirectToAction(nameof(Index));
        }
        //Get: Doctors/Details/1

        public async Task<IActionResult> Details (int id)
        {
            var doctorDetails = await _service.GetByIdAsync(id);
            if (doctorDetails == null) return View("NotFound");
            return View(doctorDetails);
        }
        //Get: Doctors/Edit -copy from Create if you want new but dont forget Async... if data manipulated thing going on
        public async Task <IActionResult> Edit(int id)
        {
            var doctorDetails = await _service.GetByIdAsync(id);
            if (doctorDetails == null) return View("NotFound");
            return View(doctorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id,FullName,ProfilePictureURL,Bio")] Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return View(doctor);
            }
            await _service.UpdateAsync(id, doctor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Doctors/Delete -copy from Edti *EDit Copy from Create //if you want new but dont forget Async... if data manipulated thing going on
        public async Task<IActionResult> Delete(int id)
        {
            var doctorDetails = await _service.GetByIdAsync(id);
            if (doctorDetails == null) return View("NotFound");
            return View(doctorDetails);
        }
        [HttpPost]//Can"t be the same Delete name! othervise, ActionName("Delete") after HttpPost but i renamed
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctorDetails = await _service.GetByIdAsync(id);
            if (doctorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
          
            return RedirectToAction(nameof(Index));
        }

    }
}
