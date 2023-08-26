using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Api.Model.Models;

namespace Api.DataAccess.Context
{
    public class ProjectContext :DbContext
    {


        //connection string
        //tabloların
        //konfigurasyonları(ilişkiler vs) dbcontextte yapıyorum

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }


        public DbSet<Employee> Employees { get; set; }

    }
}
