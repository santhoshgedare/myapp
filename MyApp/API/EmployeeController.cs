using MyAppDAL;
using MyAppDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyAppDAL.Utility;
using MyAppDAL.Model;


namespace MyApp.API
{
    public class EmployeeController : ApiController
    {
        private IEmployeeRepository _iEmployeeRepository;
        public EmployeeController(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
        }
        [HttpGet]
        public ListResponseDTO<EmployeeDetailsModel> GetAllEmployee()
        {
            return _iEmployeeRepository.GetAllEmployee();
        }

    }
}
