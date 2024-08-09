using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Classes;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZoologicoClass zoologico = new ZoologicoClass();

            while (true) 
            {
                Console.WriteLine("Selecione a opção");
                Console.WriteLine("1. Adicionais mamífero");
                Console.WriteLine("2. Adicionar ave");
                Console.WriteLine("3. Adicionar réptil");
                Console.WriteLine("4. Listar animais");
                Console.WriteLine("5. Alimentar animais");
                Console.WriteLine("6. Adicionar tratador de mamíferos");
                Console.WriteLine("7. Adicionar tratador de aves");
                Console.WriteLine("8. Listar tratadores");
                Console.WriteLine("9. Sair");

                string opcao = Console.ReadLine();

                if (opcao == "9")
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do mamífero: ");
                        string nomeMamifero = Console.ReadLine();

                        Console.WriteLine("Digite a idade do mamífero: ");
                        int idadeMamifero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de pelo do mamífero: ");
                        string tipoDePelo = Console.ReadLine();

                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoDePelo);

                        zoologico.AdicionarAnimal(mamifero);
                        break;

                    case "2":
                        Console.WriteLine("Digite o nome da ave: ");
                        string nomeAve = Console.ReadLine();

                        Console.WriteLine("Digite a idade da ave: ");
                        int idadeAve = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura de asa da ave: ");
                        double envergaduraDaAsa = double.Parse(Console.ReadLine());

                        Ave ave = new Ave(nomeAve, idadeAve, envergaduraDaAsa);

                        zoologico.AdicionarAnimal(ave);
                        break;

                    case "3":
                        Console.WriteLine("Digite o nome do réptil: ");
                        string nomeReptil = Console.ReadLine();

                        Console.WriteLine("Digite a idade do réptil: ");
                        int idadeReptil = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de escama do réptil: ");
                        string tipoDeEscama = (Console.ReadLine());

                        Reptil reptil = new Reptil(nomeReptil, idadeReptil, tipoDeEscama);

                        zoologico.AdicionarAnimal(reptil);
                        break;

                    case "4":

                        zoologico.ListarAnimais();
                        break;       

                    case "5":

                        zoologico.AlimentarAnimais();
                        break;

                    case "6":

                        Console.WriteLine("Digite o nome do tratador de mamíferos: ");
                        string nomeTratadorMamiferos = Console.ReadLine();

                        Console.WriteLine("Digite a idade do tratador de mamíferos: ");
                        string especialidadeTratadorMamiferos = Console.ReadLine();

                        TratadorMamiferos tratadorMamiferos = new TratadorMamiferos(nomeTratadorMamiferos, especialidadeTratadorMamiferos);

                        zoologico.AdicionarTratador(tratadorMamiferos);
                        break;

                    case "7":
                        Console.WriteLine("Digite o nome do tratador de mamíferos: ");
                        string nomeTratadorAves = Console.ReadLine();

                        Console.WriteLine("Digite a idade do tratador de mamíferos: ");
                        string especialidadeTratadorAves = Console.ReadLine();

                        TratadorAves tratadorAves = new TratadorAves(nomeTratadorAves, especialidadeTratadorAves);

                        zoologico.AdicionarTratador(tratadorAves);
                        break;

                    case "8":

                        zoologico.ListarTratadores();
                        break;

                    default:
                        Console.WriteLine("Opção não é válida");
                        break;
                }
            }
        }
    }
}
