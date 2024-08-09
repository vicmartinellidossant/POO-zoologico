using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interfaces;

namespace Zoologico.Classes
{
    public class ZoologicoClass
    {

        private List<Animal> animais = new List<Animal>();

        private List<Tratador> tratadores = new List<Tratador>();

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
        }

        public void ListarAnimais()
        {
            if (animais.Count > 0)
            {
                Console.WriteLine("Animais do zoológico");
                foreach (Animal animal in animais)
                {
                    animal.EmitirSom();
                    Console.WriteLine($"Nome: {animal.Nome} | Idade: {animal.Idade}");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }

        public void AlimentarAnimais()
        {
            foreach (Animal animal in animais)
            {
                if (animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
            }
        }

        public void AdicionarTratador(Tratador tratador)
        {
            tratadores.Add(tratador);
            Console.WriteLine($"{tratador.Nome} foi adicionado");
        }

        public void ListarTratadores()
        {
            if (tratadores.Count > 0)
            {
                Console.WriteLine("Tratadores do zoológico");
                foreach (Tratador tratador in tratadores)
                { 
                    Console.WriteLine($"Nome: {tratador.Nome} | Especialidade: {tratador.Especialidade}");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }

    }
}
