using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppDAL.Utility;
using MyAppDAL.Model;


namespace MyAppDAL.Repository
{
    public interface IEmployeeRepository
    {
        ListResponseDTO<EmployeeDetailsModel> GetAllEmployee();
    }
}
