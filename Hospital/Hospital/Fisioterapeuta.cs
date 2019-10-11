using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Fisioterapeuta:Persona
    {

        private int id;
        private string area;
        private string consultorio;

        public string Area { get; set; }
        public int Id { get; set; }
        public string Consultorio { get; set; }
    }
}
