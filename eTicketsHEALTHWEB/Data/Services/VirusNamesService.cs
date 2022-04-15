using eTicketsHEALTHWEB.Data.Base;
using eTicketsHEALTHWEB.Data.ViewModels;
using eTicketsHEALTHWEB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Data.Services
{
    public class VirusNamesService: EntityBaseRepository<VirusName>, IVirusNamesService
    {
        private readonly AppDbContext _context;
        public VirusNamesService(AppDbContext context): base(context)
        {
            _context = context;
        }

       

        public async Task<VirusName> GetVirusNameByIdAsync(int id)
        {
            var VirusNameDetails = await _context.VirusNames
                .Include(h => h.Hospital)
                .Include(c => c.Company)
                .Include(dv => dv.Doctors_VirusNames).ThenInclude(d => d.Doctor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return VirusNameDetails;
        }

        public async Task<NewVirusDropVM> GetNewVirusDropValues()
        {
            var response = new NewVirusDropVM()
            { 
            Doctors = await _context.Doctors.OrderBy(n => n.FullName).ToListAsync(),
            Hospitals = await _context.Hospitals.OrderBy(n => n.Name).ToListAsync(),
            Companies = await _context.Companys.OrderBy(n => n.FullName).ToListAsync()
            };
            return response;
        }

        public async Task AddNewVaccinationAsync(VirusNameVM data)
        {
            var newVaccination = new VirusName()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                HospitalId = data.HospitalId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                VirusNameCategory = data.VirusNameCategory,
                CompanyId = data.CompanyId
            };
            await _context.VirusNames.AddAsync(newVaccination);
            await _context.SaveChangesAsync();

            //Add VirusName(Vaccination&Tests could be better?, maybe change at the end)-Doctors
            foreach (var doctorId in data.DoctorIds)
            {
                var newDoctorVirusName = new Doctor_VirusName()
                {
                    VirusNameId = newVaccination.Id,
                    DoctorId = doctorId
                };
                await _context.Doctors_VirusNames.AddAsync(newDoctorVirusName);

            }
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVirusNameAsync(VirusNameVM data)
        {
            var dbVirusName = await _context.VirusNames.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbVirusName != null)
            {

                dbVirusName.Name = data.Name;
                dbVirusName.Description = data.Description;
                dbVirusName.Price = data.Price;
                dbVirusName.ImageURL = data.ImageURL;
                dbVirusName.HospitalId = data.HospitalId;
                dbVirusName.StartDate = data.StartDate;
                dbVirusName.EndDate = data.EndDate;
                dbVirusName.VirusNameCategory = data.VirusNameCategory;
                dbVirusName.CompanyId = data.CompanyId;
               
                await _context.SaveChangesAsync();
            }

            //Remove existing Doctors
            var existingDoctorsDb = _context.Doctors_VirusNames.Where(n => n.VirusNameId == data.Id).ToList();
            _context.Doctors_VirusNames.RemoveRange(existingDoctorsDb); //not an Async method
            await _context.SaveChangesAsync();

            //Add VirusName(Vaccination&Tests could be better?, maybe change at the end)-Doctors
            foreach (var doctorId in data.DoctorIds)
            {
                var newDoctorVirusName = new Doctor_VirusName()
                {
                    VirusNameId = data.Id,
                    DoctorId = doctorId
                };
                await _context.Doctors_VirusNames.AddAsync(newDoctorVirusName);

            }
            await _context.SaveChangesAsync();
        }
    }
}
