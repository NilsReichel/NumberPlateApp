using NumberPlateApp.Data.Interfaces;
using NumberPlateApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace NumberPlateApp.Data.Services;

public class DatabaseRepository : IRepository
{
    public bool Add(Numberplate n)
    {
        try
        {

            using (var context = new DatabaseContext())
            {
                context.Add(n);
                context.SaveChanges();
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<Numberplate> Load()
    {
        try
        {
            using (var context = new DatabaseContext())
            {
                var list = (from entry in context.Numberplates select entry).ToList();
                return list;
            }
        }
        catch
        {
            return new List<Numberplate>();
        }
    }
}
