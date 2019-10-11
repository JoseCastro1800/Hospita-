using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente();
            paciente.Id = 1;
            paciente.Nombre = "Castro Pacheco Jose Manuel";
            paciente.Nacimiento = "18 de julio del 2000";
            paciente.Tipo = "Super musculoso";

            Console.WriteLine("Numero del paciente:" + paciente.Id);
            Console.WriteLine("Nombre del paciente:" + paciente.Nombre);
            Console.WriteLine("Fecha de nacimiento:" + paciente.Nacimiento);
            Console.WriteLine("Tipo de paciente:" + paciente.Tipo);

            Cirujano  cirujano = new Cirujano ();
            cirujano.Id = 5465;
            cirujano.Nombre = "Emanuel villalobos zarco";
            cirujano.Area = " Ayudante general";
            cirujano.Especialidad  = "Herramientas de cirujia";

            Console.WriteLine("Numero del cirujano:" + cirujano .Id);
            Console.WriteLine("Nombre del cirujano:" + cirujano.Nombre);
            Console.WriteLine("Area:" + cirujano.Area);
            Console.WriteLine("Especialidad :" +  cirujano.Especialidad);

            Medico  medico = new Medico ();
            medico.Id  = 78;
            medico.Nombre ="Jennifer Garcia Macias";
            medico.Especialidad = " Medicina";
           
            Console.WriteLine("Numero del medico:" + medico.Id);
            Console.WriteLine("Nombre del medico:" + medico.Nombre);
            Console.WriteLine("Especialidad:" + medico.Especialidad);
            

            Enfermera enfermera = new Enfermera();
            enfermera.Id = 1;
            enfermera.Nombre = "Cristian Manuel Bautista Martinez";
            enfermera.Area = "Ayudante general";
            

            Console.WriteLine("Numero de la enfermera:" + enfermera.Id);
            Console.WriteLine("Nombre de la enfermera:" + enfermera.Nombre);
            Console.WriteLine("Area:" + enfermera.Area);
            

            MedicoFamiliar mf = new MedicoFamiliar ();
            mf.Id  = 1;
            mf.Nombre = "Alan Rodriguex";
            mf.Especialidad  = "Musculatoria";
            

            Console.WriteLine("Numero del medico familiar:" + mf.Id);
            Console.WriteLine("Nombre del medico familiar:" + mf.Nombre);
            Console.WriteLine("Especialidad:" + mf.Especialidad );
            

            Fisioterapeuta fisio = new Fisioterapeuta ();
            fisio.Id = 1;
            fisio.Nombre = "Castro Pacheco Jose Manuel";
            fisio.Area  = "Adultos";
            fisio.Consultorio  = "Los valientes";

            Console.WriteLine("Numero del fisioterapeuta:" + fisio.Id);
            Console.WriteLine("Nombre del fisiotepaeuta:" + fisio.Nombre);
            Console.WriteLine("Area:" + fisio.Area);
            Console.WriteLine("Consultorio:" + fisio.Consultorio);

            Hombre hombre = new Hombre();
            hombre.Nombre = "Jonhni paz";
            hombre.Nacimiento = "19 de julio del 2000";

            
            Console.WriteLine("Nombre del hombre:" + hombre.Nombre);
            Console.WriteLine("Fecha de nacimiento:" + hombre.Nacimiento);
           

            Mujer mujer = new Mujer();
            
            mujer.Nombre = "Laisha Lopez";
            mujer.Nacimiento = "20 de julio del 2000";
            

            
            Console.WriteLine("Nombre de la mujer:" + mujer.Nombre);
            Console.WriteLine("Fecha de nacimiento:" + mujer.Nacimiento);
           



            Console.ReadKey();


        }
    }
}
