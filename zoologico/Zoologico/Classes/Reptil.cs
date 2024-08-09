using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.Classes
{
    public class Reptil : Animal
    {

        public string TipoDeEscama { get; set; }

        public Reptil(string nome, int idade, string tipoDeEscama) 
            : base(nome, idade)
        { 
            TipoDeEscama = tipoDeEscama;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Répteis não emitem som");
        }
    }
}
