using System;
using Microsoft.EntityFrameworkCore;
using SpendSmart.Models;
namespace SpendSmart.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){

    }
    public DbSet<Employee> Employee { get; set; }
}
