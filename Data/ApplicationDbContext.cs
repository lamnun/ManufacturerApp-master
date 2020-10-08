using System;
using System.Collections.Generic;
using System.Text;
using ManufacturerApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ManufacturerApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Manufacturer> Manufacturers { get; set; } //Manufacturers 테이블 생성

        public DbSet<Idea> Ideas { get; set; }
    }
}
