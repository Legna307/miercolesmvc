﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace miercolesmvc.Models
{
    public class ContextoEmpleados : DbContext
    {
        //Acontinuacion llamamos a la cadena de conexion 
        public ContextoEmpleados() : base("cadenaempleados") { }
        public DbSet<Empleadin> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}