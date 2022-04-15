using eTicketsHEALTHWEB.Data.Base;
using eTicketsHEALTHWEB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Data.Services
{
    public class DoctorsService : EntityBaseRepository<Doctor>, IDoctorsService
    {
        //private readonly AppDbContext _context;
        public DoctorsService(AppDbContext context): base(context) { }
        //{
        //    _context = context;
        //}
        //public async Task AddAsync(Doctor doctor)
        //{
        //    await _context.Doctors.AddAsync(doctor);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Doctors.FirstOrDefaultAsync(n => n.Id == id);
        //    _context.Doctors.Remove(result);
        //    await _context.SaveChangesAsync();
        //}

       
        //public async Task <Doctor> UpdateAsync(int id, Doctor newDoctor)
        //{
        //    _context.Update(newDoctor);
        //    await _context.SaveChangesAsync();
        //    return newDoctor;
        //}

        //public Task UpdateAsync(object id, Doctor doctor)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
