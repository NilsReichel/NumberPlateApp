using NumberPlateApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPlateApp.Data.Interfaces;

public interface IRepository
{
    bool Add(Numberplate n);

    List<Numberplate> Load();
}
