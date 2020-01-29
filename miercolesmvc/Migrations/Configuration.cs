namespace miercolesmvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using miercolesmvc.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<miercolesmvc.Models.ContextoEmpleados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(miercolesmvc.Models.ContextoEmpleados context)
        {
            context.Empleados.AddOrUpdate(z => z.Nombre, new Empleadin
            {
                IdEmpleado = 1,
                Nombre = "David",
                Apellidos = "Fernandez Huertas",
                Direccion = "Calle Atletico de Madrid",
                Email = "david@mail.com"
            },
              new Empleadin
              {
                  IdEmpleado = 2,
                  Nombre = "Dani",
                  Apellidos = "Hernandez Puertas",
                  Direccion = "Calle Madrid",
                  Email = "dani@mail.com"
              },
              new Empleadin
              {
                  IdEmpleado = 3,
                  Nombre = "Ana",
                  Apellidos = "Huertas Fernandez ",
                  Direccion = "Calle Atletico ",
                  Email = "ana@mail.com"
              }

              );
        }

    }
}
