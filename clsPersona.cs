using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProyecto
{
    class clsPersona
    {
           protected String nombre { get; set; }
            protected String apellido { get; set; }
            protected String direccion { get; set; }
            protected String id { get; set; }
            protected String telefono { get; set; }
            protected char sexo { get; set; }
            protected int edad { get; set; }
            protected DateTime fechNac { get; set; }
            protected String pswd { get; set; }

            public clsPersona(String nombre, String apellido, String direccion, String id, String telefono, char sexo, int edad, DateTime fechNac, String pswd)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.direccion = direccion;
                this.id = id;
                this.telefono = telefono;
                this.sexo = sexo;
                this.edad = edad;
                this.fechNac = fechNac;
                this.pswd = pswd;
            }

        
        }





    }
}
