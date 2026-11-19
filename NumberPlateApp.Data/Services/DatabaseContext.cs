using Microsoft.EntityFrameworkCore;
using NumberPlateApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPlateApp.Data.Services;

public class DatabaseContext : DbContext
{
    public DbSet<Numberplate> Numberplates { get; set; }

    public DatabaseContext()
    {
        SQLitePCL.Batteries_V2.Init();
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string dbPath = Path.Combine(folder, "numberplate.db3");

        System.Diagnostics.Debug.WriteLine($"DB-Path: {dbPath}");

        optionsBuilder.UseSqlite($"Filename={dbPath}"); 

        base.OnConfiguring(optionsBuilder);
    }
}
