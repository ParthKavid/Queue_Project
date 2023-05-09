using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Project.Interfaces
{
    public interface IPersonInfo
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string Phone { get; set; }

        string Email { get; set; }

        string Password { get; set; }

        int CountryId { get; set; }
        int ProvinceId { get; set; }
        int CityId { get; set; }
        string Zipcode { get; set; }


    }
}
