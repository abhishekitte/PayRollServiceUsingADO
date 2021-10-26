using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollServicesUsingADO
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
           
            EmployeeModel model = new EmployeeModel();
            //model.EmployeeName = "Abhishek";
            //model.BasicPay = 950000;
            ////repository.UpdateSalaryUsingStoredProcedure(model);
            //model.StartDate = DateTime.Today;
            //model.Gender = "M";
            ////repository.PerformAggregateFunctions(model);
            //model.PhoneNumber =9967320888;
            //model.Address = "Mumbai";
            //model.Department = "Sales";
            //model.TaxablePay = 5000;
            repository.AddEmployee(model);
        }
    }
}