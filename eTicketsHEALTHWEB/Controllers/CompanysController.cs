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
    public class CompanysController : Controller
    {
      
        private readonly ICompaniesService _service;
       
        public CompanysController(ICompaniesService service)
        {
            _service = service;
        }
     
        public async Task<IActionResult> Index()
        {
            var allCompanys = await _service.GetAllAsync();
            return View(allCompanys);
        }
        //GET: companies(companys)/details/1
        public async Task<ActionResult> Details(int id)
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null ) return View("NotFound");
            return View(companyDetails);
        }
        //GET: companies(companys)/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // PoSt! starts from here 
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Company company)
        {
            if (!ModelState.IsValid) return View(company);

            await _service.AddAsync(company);
            return RedirectToAction(nameof(Index));
        }


        //GET: companies(companys)/edit/1  (copy from GET: .....create- well similar -of course with changes)
        public async Task <IActionResult> Edit(int id)
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null) return View("NotFound");
            return View(companyDetails);
            
        }

        [HttpPost] // PoSt! starts from here 
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Company company)
        {
            if (!ModelState.IsValid) return View(company);

            if(id == company.Id) // !!!!
            {

                await _service.UpdateAsync(id, company);
                return RedirectToAction(nameof(Index));

            }
            return View(company);

        }


        //GET: companies(companys)/delete/1  (copy from GET: .....edit- well similar -of course with changes)
        public async Task<IActionResult> Delete(int id)
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null) return View("NotFound");
            return View(companyDetails);

        }

        [HttpPost] // PoSt! starts from here // Define ACTION NAME - same name issue-  I RENAMED asp-action.... see DoctorsController the comment and in Deletes cshtml the result
        public async Task<IActionResult> DeleteConfirmed(int id) //don't need the Bind section
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }


    }
}
