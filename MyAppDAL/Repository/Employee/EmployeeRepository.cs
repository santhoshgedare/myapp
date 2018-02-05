using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppDAL.Utility;
using MyAppDAL.Model;
namespace MyAppDAL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public ListResponseDTO<EmployeeDetailsModel> GetAllEmployee()
        {
        
            ListResponseDTO<EmployeeDetailsModel> oResult = new ListResponseDTO<EmployeeDetailsModel>();

            try
            {
                using (CompanyEntities db = new CompanyEntities())
                {
                    var oQuery = (from c in db.Employees.OrderBy(c => c.EmployeeID)
                                  select new EmployeeDetailsModel
                                  {
                                      DepartmentID=c.DepartmentID,
                                      EmployeeID=c.DepartmentID,
                                      EmployeeName=c.EmployeeName
                                  }
                                  ).ToList();

                    if (oQuery != null)
                    {
                        oResult.Valid = true;
                        oResult.Items = oQuery;
                        oResult.Msg = "Here is the view";
                    }
                    else
                    {
                        oResult.Valid = false;
                        oResult.Msg = "Something Went Wrong";
                    }
                }
            }
            catch (Exception ex)
            {
                oResult.Valid = false;
                oResult.Msg = ex.Message;
            }

            return oResult;
        }

     
    }
}
