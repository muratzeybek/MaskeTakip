using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Citizen citizen)
        {
            CitizenManager personManager = new CitizenManager();
            if (personManager.CheckPerson(citizen))
            {
                Console.WriteLine(citizen.FirstName + " için maske verildi.");
            }
            else
                Console.WriteLine("Böyle bir kişi yok");
        }
    }
}
