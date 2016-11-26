using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProyecto
{
   
   public class clsCita
    {
        private clsMedico medico { get; set; }
        private DateTime fecha { get; set; }
        private DateTime hora { get; set; }
    }
     public Cita()
    {
        
        clsMedico medico = new clsMedico();
        DateTime fecha = new DateTime();
        DateTime hora = new DateTime();
    }
    

}
