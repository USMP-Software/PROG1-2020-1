using System;
using System.Collections.Generic;
using System.Linq;

namespace net_ejercicio1
{
  class Program
  {
    static void Main(string[] args)
    {
      Empleado e1 = new Empleado();
      var e2 = new Empleado
      {
        Nombres = "X",
        Apellidos = "Y",
        FechaNacimiento = new DateTime(1998, 12, 30)
      };

      e1.Nombres = "A";
      e1.Apellidos = "B";
      e1.FechaNacimiento = new DateTime(2000, 3, 15);

      var empleados = new List<Empleado>();
      empleados.Add(e1);
      empleados.Add(e2);


      var empleadosMayores99 = empleados.Where(x => x.FechaNacimiento.Year > 1999).Skip(1).Take(3);
    }
  }
}
