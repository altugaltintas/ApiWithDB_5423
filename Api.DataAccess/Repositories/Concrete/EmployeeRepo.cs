using Api.DataAccess.Context;
using Api.DataAccess.Repositories.Abstract;
using Api.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.DataAccess.Repositories.Concrete
{
    public class EmployeeRepo : IEmployeeRepo
    {//bir sınıfın içerisinde crud işlemleri için context sınıfım lazım. bunu di ile almam lazım
        private readonly ProjectContext _context;

        public EmployeeRepo(ProjectContext context)
        {
            _context = context;
        }

        public Employee CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);//Employees dbset
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployee(id);// önce ilgili id li emloyeyi bul
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();// contextin içinde employeleri listele dedim
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public int MaxId()
        {
            return _context.Employees.Max(a => a.ID);// id kolonundaki max değeri bulduk
        }

        public Employee UpdateEmploye(Employee employee)// günceli içeri aktarmamız lazım
        {
            Employee updated = GetEmployee(employee.ID);
            updated.FirstName = employee.FirstName;
            updated.LastName = employee.LastName;
            updated.Department = employee.Department;

            _context.Employees.Update(updated);
            _context.SaveChanges();

            return employee;
        }
    }
}

