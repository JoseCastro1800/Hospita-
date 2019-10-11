using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente:Persona
    {

        private int id;
        private string tipo;
        public string Tipo { get; set; }
        public int Id { get; set; }
    }
}
