using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "HASAN";
            person1.LastName = "ZAMANLI";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentitiy = 01234567891;

            CargoManager cargoManager = new CargoManager(new PersonManager());
            cargoManager.GiveMask(person1);
        }
    }
}