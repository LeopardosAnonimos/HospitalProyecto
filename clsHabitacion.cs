using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProyecto
{
    class clsHabitacion
    {
        List<clsPaciente> paciente = new List<clsPaciente>();

        public void grabarPaciente(clsPaciente pac )
        {
            this.paciente.Add(pac);
        }

        public clsPaciente obtenerPaciente(clsHabitacion cuarto)
        {
            return this.paciente.Where(pac => pac.id == cuarto).FirstOrDefault;
        }
    }
}
