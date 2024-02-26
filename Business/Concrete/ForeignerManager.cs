using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public List<Citizen> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
