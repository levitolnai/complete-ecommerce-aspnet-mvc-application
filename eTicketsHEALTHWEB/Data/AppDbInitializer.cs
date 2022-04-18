using eTicketsHEALTHWEB.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB.Data
{
    public class AppDbInitializer
    {//Don't forget import Namespace - IApplicationBuilder
        public static void Seed(IApplicationBuilder applicationBuilder)
        {//Don't forget import Namespace - CreateScope
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Hospital
                if (!context.Hospitals.Any())
                {
                    context.Hospitals.AddRange(new List<Hospital>()
                    {
                        new Hospital()
                        {
                            Name = "North Hospital",
                            Logo = "https://media.istockphoto.com/vectors/medical-concept-with-hospital-building-in-flat-style-vector-id1131216472?k=20&m=1131216472&s=612x612&w=0&h=809tQqEycyhLSS6E2nrAaP_3WAMzHVjHuPdYJwmQXZk=",
                            Description = "This is the description of the first hospital"
                        },
                        new Hospital()
                        {
                            Name = "West Hospital",
                            Logo = "https://media.istockphoto.com/vectors/medical-concept-with-hospital-building-in-flat-style-vector-id1131216472?k=20&m=1131216472&s=612x612&w=0&h=809tQqEycyhLSS6E2nrAaP_3WAMzHVjHuPdYJwmQXZk=",
                            Description = "This is the description of the second hospital"
                        },
                        new Hospital()
                        {
                            Name = "South Hospital",
                            Logo = "https://media.istockphoto.com/vectors/medical-concept-with-hospital-building-in-flat-style-vector-id1131216472?k=20&m=1131216472&s=612x612&w=0&h=809tQqEycyhLSS6E2nrAaP_3WAMzHVjHuPdYJwmQXZk=",
                            Description = "This is the description of the third hospital"
                        },
                        new Hospital()
                        {
                            Name = "East Hospital",
                            Logo = "https://media.istockphoto.com/vectors/medical-concept-with-hospital-building-in-flat-style-vector-id1131216472?k=20&m=1131216472&s=612x612&w=0&h=809tQqEycyhLSS6E2nrAaP_3WAMzHVjHuPdYJwmQXZk=",
                            Description = "This is the description of the fourth hospital"
                        },
                        new Hospital()
                        {
                            Name = "North-East Hospital",
                            Logo = "https://media.istockphoto.com/vectors/medical-concept-with-hospital-building-in-flat-style-vector-id1131216472?k=20&m=1131216472&s=612x612&w=0&h=809tQqEycyhLSS6E2nrAaP_3WAMzHVjHuPdYJwmQXZk=",
                            Description = "This is the description of the fifth hospital"
                        },
                    });
                    context.SaveChanges();
                }
                //Doctors
                if (!context.Doctors.Any())
                {
                    context.Doctors.AddRange(new List<Doctor>()
                    {
                        new Doctor()
                        {
                            FullName = "Doctor Black",
                            Bio = "This is the Bio of the first doctor",
                            ProfilePictureURL = "https://en.pimg.jp/055/021/026/1/55021026.jpg"

                        },
                        new Doctor()
                        {
                            FullName = "Doctor Brown",
                            Bio = "This is the Bio of the second doctor",
                            ProfilePictureURL = "https://en.pimg.jp/004/472/040/1/4472040.jpg"
                        },
                        new Doctor()
                        {
                           FullName = "Doctor White",
                            Bio = "This is the Bio of the third doctor",
                            ProfilePictureURL = "https://en.pimg.jp/002/386/012/1/2386012.jpg"
                        },
                        new Doctor()
                        {
                            FullName = "Doctor Red",
                            Bio = "This is the Bio of the fourth doctor",
                            ProfilePictureURL = "https://png.pngtree.com/png-clipart/20190611/original/pngtree-vector-hand-painted-doctor-png-image_3236614.jpg"
                        },
                        new Doctor()
                        {
                            FullName = "Doctor Green",
                            Bio = "This is the Bio of the fifth doctor",
                            ProfilePictureURL = "https://png.pngtree.com/png-clipart/20190604/original/pngtree-doctors-png-image_979759.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Companies 
                if (!context.Companys.Any())
                {
                    context.Companys.AddRange(new List<Company>()
                    {
                        new Company()
                        {
                            FullName = "Alpha Ltd.",
                            Bio = "This is the Profile of the first company",
                            ProfilePictureURL = "https://c8.alamy.com/comp/MW10CY/insurance-concept-painted-red-family-and-palm-icon-on-digital-data-paper-background-with-hand-drawn-insurance-icons-MW10CY.jpg"

                        },
                        new Company()
                        {
                             FullName = "Beta Inc.",
                            Bio = "This is the Profile of the second company",
                            ProfilePictureURL = "https://thumbs.dreamstime.com/z/vector-senior-young-people-covered-health-insurance-being-assisted-medical-staff-190011905.jpg"
                        },
                        new Company()
                        {
                             FullName = "Gamma Ltd.",
                            Bio = "This is the Profile of the third company",
                            ProfilePictureURL = "https://image.shutterstock.com/image-vector/home-shield-logo-260nw-601529891.jpg"
                        },
                        new Company()
                        {
                             FullName = "Delta Inc.",
                            Bio = "This is the Profile of the fourth company",
                            ProfilePictureURL = "https://image.shutterstock.com/image-vector/home-heart-shape-logo-icon-260nw-1933492772.jpg"
                        },
                        new Company()
                        {
                             FullName = "Omega Inc.",
                            Bio = "This is the Profile of the fifth company",
                            ProfilePictureURL = "https://i.pinimg.com/originals/49/37/ee/4937ee3b369f48e76c4843c407e057c5.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //VirusNames
                if (!context.VirusNames.Any())
                {
                    context.VirusNames.AddRange(new List<VirusName>()
                    {
                        new VirusName()
                        {
                            Name = "Two Vaccination with Pfeizer to prevent Covid",
                            Description = "This is the Fast Covid Test description",
                            Price = 39.50,
                            ImageURL = "https://www.bu.edu/files/2022/08/v4-21-1011-VAC-017.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            HospitalId = 3,
                            CompanyId = 3,
                            VirusNameCategory = VirusNameCategory.Test
                        },
                        new VirusName()
                        {
                            Name = "Janssen, All in One Vaccination",
                            Description = "This is the Thorough Covid Test without antibodies investigation description",
                            Price = 29.50,
                            ImageURL = "https://www.bu.edu/files/2022/08/v4-21-1011-VAC-017.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            HospitalId = 1,
                            CompanyId = 1,
                            VirusNameCategory = VirusNameCategory.ThoroughTest
                        },
                        new VirusName()
                        {
                            Name = "Thorough Covid Test with antibodies investigation",
                            Description = "This is the Thorough Covid Test with antibodies investigation description",
                            Price = 39.50,
                            ImageURL = "https://img.virusmaszk.hu/HY-tyK5S/s-b4:BgigsNyBrlTd5_lkI_WS4yr1oakGCKCw55/w:560_h:840_c:pad_bg:56a7c5_q:93/i/33927406.png.webp",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            HospitalId = 4,
                            CompanyId = 4,
                            VirusNameCategory = VirusNameCategory.ThoroughTest
                        },
                        new VirusName()
                        {
                            Name = "Fast Covid Test",
                            Description = "This is the Two Vaccination with Pfeizer description",
                            Price = 39.50,
                            ImageURL = "https://img.virusmaszk.hu/HY-tyK5S/s-b4:BgigsNyBrlTd5_lkI_WS4yr1oakGCKCw55/w:560_h:840_c:pad_bg:56a7c5_q:93/i/33927406.png.webp",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            HospitalId = 1,
                            CompanyId = 2,
                            VirusNameCategory = VirusNameCategory.TwoVaccination
                        },
                        new VirusName()
                        {
                            Name = "Thorough Covid Test/ no antibodies investigation",
                            Description = "This is description",
                            Price = 39.50,
                            ImageURL = "https://img.virusmaszk.hu/HY-tyK5S/s-b4:BgigsNyBrlTd5_lkI_WS4yr1oakGCKCw55/w:560_h:840_c:pad_bg:56a7c5_q:93/i/33927406.png.webp",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            HospitalId = 1,
                            CompanyId = 3,
                            VirusNameCategory = VirusNameCategory.VaccinationAllinOne
                        },
                        new VirusName()
                        {
                            Name = "Janssen, All in One Vaccination for Covid-Omicron",
                            Description = "This is description",
                            Price = 39.50,
                            ImageURL = "https://www.bu.edu/files/2022/08/v4-21-1011-VAC-017.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            HospitalId = 1,
                            CompanyId = 5,
                            VirusNameCategory = VirusNameCategory.VaccinationAllinOne
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Doctors_VirusNames.Any())
                {
                    context.Doctors_VirusNames.AddRange(new List<Doctor_VirusName>()
                    {
                        new Doctor_VirusName()
                        {
                            DoctorId = 1,
                            VirusNameId = 1
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 3,
                            VirusNameId = 1
                        },

                         new Doctor_VirusName()
                        {
                            DoctorId = 1,
                            VirusNameId = 2
                        },
                         new Doctor_VirusName()
                        {
                            DoctorId = 4,
                            VirusNameId = 2
                        },

                        new Doctor_VirusName()
                        {
                            DoctorId = 1,
                            VirusNameId = 3
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 2,
                            VirusNameId = 3
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 5,
                            VirusNameId = 3
                        },


                        new Doctor_VirusName()
                        {
                            DoctorId = 2,
                            VirusNameId = 4
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 3,
                            VirusNameId = 4
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 4,
                            VirusNameId = 4
                        },


                        new Doctor_VirusName()
                        {
                            DoctorId = 2,
                            VirusNameId = 5
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 3,
                            VirusNameId = 5
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 4,
                            VirusNameId = 5
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 5,
                            VirusNameId = 5
                        },


                        new Doctor_VirusName()
                        {
                          DoctorId = 3,
                          VirusNameId = 6
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 4,
                            VirusNameId = 6
                        },
                        new Doctor_VirusName()
                        {
                            DoctorId = 5,
                            VirusNameId = 6
                        },
                    });
                    context.SaveChanges();
                }

            }

        }
    }
}