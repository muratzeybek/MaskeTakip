using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Citizen citizen);
        List<Citizen> GetList();
        bool CheckPerson(Citizen citizen);
    }
}
