using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProyecto
{
    class clsPaciente
    {
        private clsHistClinica historia;
        public clsHistClinica Historia
        {
            get
            {
                return historia;
            }
            set
            {
                historia = value;
            }
        }

        private clsCita cita;
        public clsPacientepublic clsMedico(String nombre, String apellido, String direccion, String id, String telefono, char sexo, int edad, DateTime fechNac, String psw)
            : base(nombre, apellido, direccion, id, telefono, sexo, edad, fechNac, psw)
        {
            clsHistClinica historia = new clsHistClinica();
            clsCita cita = new clsCita();
        }
    }
}

