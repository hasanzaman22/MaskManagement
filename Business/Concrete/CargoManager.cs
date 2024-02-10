using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CargoManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public CargoManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine("Mask was given to " + person.FirstName + " " + person.LastName);
            }
            else
            {
                Console.WriteLine("Mask was NOT given to " + person.FirstName + " " + person.LastName);
            }
        }
    }
}
