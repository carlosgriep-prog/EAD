using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_
{

    public class Materia
    {
        public double Nota { get; set; }
        
        


        public void MatematicaNota()
        {
            Console.WriteLine($"qual sua Nota em matematica");
        }
        public void PortuguesNota()
        {
            Console.WriteLine($"Qual sua Nota em portugues");

        }
        public void GeografiaNota()
        {
            Console.WriteLine($"qual sua Nota em geografia");

        }
        public void HistoriaNota()
        {
            Console.WriteLine($"Qual sua Nota em historia");

        }
        public void FisicaNota()
        {
            Console.WriteLine($"Qual sua Nota em fisica");

        }

    }
}