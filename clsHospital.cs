using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProyecto
{
    
        class clsHospital
        {
            private String especialidad;
            List<clsPaciente> pacientes = new List<clsPaciente>();
            public clsHospital()
            {
                this.especialidad = "";
            }
            public clsPaciente obtenerUltimoPaciente()
            {
                return this.pacientes.Last();
            }
            public void grabarPaciente(clsPaciente p)
            {
                this.pacientes.Add(p);
            }
            public clsPaciente obtenerPaciente(clsHistClinica hist)
            {
                return this.pacientes.Where(p => p.historia == hist).FirstOrDefault();
            }
        }
    
}
