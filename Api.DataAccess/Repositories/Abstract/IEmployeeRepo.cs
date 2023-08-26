using Api.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.DataAccess.Repositories.Abstract
{
    public interface IEmployeeRepo
    {
        Employee CreateEmployee(Employee employee);//aldığı employee nesnesini veritabanına ekler ve eklediğini geri döner

        Employee GetEmployee(int id); //aldığı id ye sahip nesneyi geri döner

        List<Employee> GetAllEmployees();

        Employee UpdateEmploye(Employee employee); // aldığı güncel employee nesnesine işlem yapar ve geri döner

        void DeleteEmployee(int id); // id sini bildiği nesneyi siler, geriye değer dönmez

        int MaxId();// veritabanındaki en son id bilgisini döner.
    }


}
