using Api.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Bussiness.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        
        Employee GetEmployee(int id);


        Employee CreateEmployee(Employee employee);

        Employee UpdateEmployee(Employee employee);

        void DeleteEmployee(int id);

        
    }
}
