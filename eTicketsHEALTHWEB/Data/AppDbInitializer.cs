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
                            Name = "Hospital 1",
                            Logo = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            Description = "This is the description of the first hospital"
                        },
                        new Hospital()
                        {
                            Name = "Hospital 2",
                            Logo = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            Description = "This is the description of the second hospital"
                        },
                        new Hospital()
                        {
                            Name = "Hospital 3",
                            Logo = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            Description = "This is the description of the third hospital"
                        },
                        new Hospital()
                        {
                            Name = "Hospital 4",
                            Logo = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            Description = "This is the description of the fourth hospital"
                        },
                        new Hospital()
                        {
                            Name = "Hospital 5",
                            Logo = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
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
                            FullName = "Doctor 1",
                            Bio = "This is the Bio of the first doctor",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"

                        },
                        new Doctor()
                        {
                            FullName = "Doctor 2",
                            Bio = "This is the Bio of the second doctor",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
                        },
                        new Doctor()
                        {
                           FullName = "Doctor 3",
                            Bio = "This is the Bio of the third doctor",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
                        },
                        new Doctor()
                        {
                            FullName = "Doctor 4",
                            Bio = "This is the Bio of the fourth doctor",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
                        },
                        new Doctor()
                        {
                            FullName = "Doctor 5",
                            Bio = "This is the Bio of the fifth doctor",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
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
                            FullName = "Company 1",
                            Bio = "This is the Bio of the first company",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"

                        },
                        new Company()
                        {
                             FullName = "Company 2",
                            Bio = "This is the Bio of the second company",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
                        },
                        new Company()
                        {
                             FullName = "Company 3",
                            Bio = "This is the Bio of the third company",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
                        },
                        new Company()
                        {
                             FullName = "Company 4",
                            Bio = "This is the Bio of the fourth company",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
                        },
                        new Company()
                        {
                             FullName = "Company 5",
                            Bio = "This is the Bio of the fifth company",
                            ProfilePictureURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076"
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
                            Name = "Fast Covid Test",
                            Description = "This is the Fast Covid Test description",
                            Price = 39.50,
                            ImageURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            HospitalId = 3,
                            CompanyId = 3,
                            VirusNameCategory = VirusNameCategory.Test
                        },
                        new VirusName()
                        {
                            Name = "Thorough Covid Test without antibodies investigation",
                            Description = "This is the Thorough Covid Test without antibodies investigation description",
                            Price = 29.50,
                            ImageURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
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
                            ImageURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            HospitalId = 4,
                            CompanyId = 4,
                            VirusNameCategory = VirusNameCategory.ThoroughTest
                        },
                        new VirusName()
                        {
                            Name = "Two Vaccination with Pfeizer to prevent Covid",
                            Description = "This is the Two Vaccination with Pfeizer description",
                            Price = 39.50,
                            ImageURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            HospitalId = 1,
                            CompanyId = 2,
                            VirusNameCategory = VirusNameCategory.TwoVaccination
                        },
                        new VirusName()
                        {
                            Name = "Janssen, All in One Vaccination",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            HospitalId = 1,
                            CompanyId = 3,
                            VirusNameCategory = VirusNameCategory.VaccinationAllinOne
                        },
                        new VirusName()
                        {
                            Name = "Janssen, All in One Vaccination for Covid-Omicron",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "https://posterstore-group.imgix.net/10-83167.jpg?auto=compress%2Cformat&h=550&w=515&s=8618d73b46ee6b8bf01b0d7c21cca076",
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