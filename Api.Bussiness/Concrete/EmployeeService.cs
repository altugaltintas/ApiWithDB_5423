using Api.Bussiness.Abstract;
using Api.DataAccess.Repositories.Abstract;
using Api.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Bussiness.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _repo;

        // bazı  kurallar dahilinde repoye iş yaptırmak istiyorum



        public EmployeeService(IEmployeeRepo repo)   //ctor tab yap,  reponu cağır sonra  create end assing  de prive alanı ile değiştir yani enjeksiyon yap  IRepodakiler gelsin ve doldur
        {
            _repo = repo;
        }


        public Employee CreateEmployee(Employee employee)
        {
            if (employee != null) _repo.CreateEmployee(employee);
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            if (id > 0 && id <= _repo.MaxId()) _repo.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repo.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            if (id > 0 && id <= _repo.MaxId()) return _repo.GetEmployee(id);
            throw new Exception("Silmek istediğiniz id'yi kontrol ediniz.");
        }

        public Employee UpdateEmployee(Employee employee)
        {
            if (employee != null) _repo.UpdateEmploye(employee);
            return employee;
        }
    }
}
