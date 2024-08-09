using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interfaces;

namespace Zoologico.Classes
{
    public class Ave : Animal, IAlimentavel, ICuidavel
    {

        public double EnvergaduraDasAsas {  get; set; }

        public Ave(string nome, int idade, double envergaduraDasAsas)
            : base(nome, idade)
        {
            EnvergaduraDasAsas = envergaduraDasAsas;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz som de ave");
        }

        public void Alimentar()
        {
            Console.WriteLine($"{Nome} é ave e está se alimentando");
        }

        public void Cuidar()
        {
            Console.WriteLine($"{Nome} é ave e está sendo cuidado");
        }
    }
}
