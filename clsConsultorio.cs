using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class clsConsultorio
    {
        List<clsMedico> medicos = new List<clsMedico>();


        public clsMedico obtenerUltimoMedico()
        {
            return this.medicos.Last();
        }
        public void grabarMedico(clsMedico m)
        {
            this.medicos.Add(m);
        }
        public clsMedico obtenerMedico(????? ident)
        {
            return this.medicos.Where(p => p.id == ident).FirstOrDefault();
        }
    }
}
