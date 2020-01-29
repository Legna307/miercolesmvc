using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace miercolesmvc.Models
{
    public class Empleadin
    {
   
        [Key]
        public int IdEmpleado { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Direccion { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    }
}