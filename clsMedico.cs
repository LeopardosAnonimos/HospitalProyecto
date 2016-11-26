using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProyecto
{
    class clsMedico : clsPersona
    {
             
            private String especialidad { get; set; }

            public clsMedico(String nombre, String apellido, String direccion, String id, String telefono, char sexo, int edad, DateTime fechNac, String psw)
            : base(nombre, apellido, direccion, id, telefono, sexo, edad, fechNac, psw)
        {
            
             
               


        }



    }
    }

}
