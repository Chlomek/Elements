using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuestions = 25;
            Random rnd = new Random();
            Console.WriteLine("Chcete použít i pokročilé prvky? (ano/ne)");
            string usageOfOptional = Console.ReadLine();
            int correctAnsweredQuestions = 0;
            string[] optionalElement = { "Rubidium", "Stroncium", "Indium", "Bismut", "Polonium", "Baryum", "Thallium", "Cesium", "Radon", "Francium", "Radium", "Nihonium", "Flerovium", "Moscovium", "Livermorium", "Tennessin", "Oganesson", };
            string[] elementName = { "Vodík", "Helium", "Lithium", "Beryllium", "Bor", "Uhlík", "Dusík", "Kyslík", "Fluor", "Neon", "Sodík", "Hořčík", "Hliník", "Křemík", "Fosfor", "Síra", "Chlor", "Argon", "Draslík", "Vápník", "Gallium", "Germanium", "Arsen", "Selen", "Brom", "Krypton", "Cín", "Antimon", "Tellur", "Jod", "Xenon", "Olovo", "Astat", "Železo", "Kobalt", "Nikl", "Měď", "Stříbro", "Zlato", };


            for (int i = 0; i <= numberOfQuestions; i++)
            {
                int rnd1;
                
                if (usageOfOptional.ToLower() == "ano")
                { 
                    elementName = elementName.Concat(optionalElement).ToArray();
                    rnd1 = rnd.Next(0, 56);
                }
                else
                {
                    rnd1 = rnd.Next(0, 39);
                }

                string currentElement = elementName[rnd1];

                switch(currentElement)
                {
                    case ("Vodík"):
                        Console.WriteLine("Zadejte název prvku H");
                        break;
                    case ("Helium"):
                        Console.WriteLine("Zadejte název prvku He");
                        break;
                    case ("Lithium"):
                        Console.WriteLine("Zadejte název prvku Li");
                        break;
                    case ("Beryllium"):
                        Console.WriteLine("Zadejte název prvku Be");
                        break;
                    case ("Bor"):
                        Console.WriteLine("Zadejte název prvku B");
                        break;
                    case ("Uhlík"):
                        Console.WriteLine("Zadejte název prvku C");
                        break;
                    case ("Dusík"):
                        Console.WriteLine("Zadejte název prvku N");
                        break;
                    case ("Kyslík"):
                        Console.WriteLine("Zadejte název prvku O");
                        break;
                    case ("Fluor"):
                        Console.WriteLine("Zadejte název prvku F");
                        break;
                    case ("Neon"):
                        Console.WriteLine("Zadejte název prvku Ne");
                        break;
                    case ("Sodík"):
                        Console.WriteLine("Zadejte název prvku Na");
                        break;
                    case ("Hořčík"):
                        Console.WriteLine("Zadejte název prvku Mg");
                        break;
                    case ("Hliník"):
                        Console.WriteLine("Zadejte název prvku Al");
                        break;
                    case ("Křemík"):
                        Console.WriteLine("Zadejte název prvku Si");
                        break;
                    case ("Fosfor"):
                        Console.WriteLine("Zadejte název prvku P");
                        break;
                    case ("Síra"):
                        Console.WriteLine("Zadejte název prvku S");
                        break;
                    case ("Chlor"):
                        Console.WriteLine("Zadejte název prvku Cl");
                        break;
                    case ("Argon"):
                        Console.WriteLine("Zadejte název prvku Ar");
                        break;
                    case ("Draslík"):
                        Console.WriteLine("Zadejte název prvku K");
                        break;
                    case ("Vápník"):
                        Console.WriteLine("Zadejte název prvku Ca");
                        break;
                    case ("Gallium"):
                        Console.WriteLine("Zadejte název prvku Ga");
                        break;
                    case ("Germanium"):
                        Console.WriteLine("Zadejte název prvku Ge");
                        break;
                    case ("Arsen"):
                        Console.WriteLine("Zadejte název prvku As");
                        break;
                    case ("Selen"):
                        Console.WriteLine("Zadejte název prvku Se");
                        break;
                    case ("Brom"):
                        Console.WriteLine("Zadejte název prvku Br");
                        break;
                    case ("Krypton"):
                        Console.WriteLine("Zadejte název prvku Kr");
                        break;
                    case ("Rubidium"):
                        Console.WriteLine("Zadejte název prvku Rb");
                        break;
                    case ("Stroncium"):
                        Console.WriteLine("Zadejte název prvku Sr");
                        break;
                    case ("Indium"):
                        Console.WriteLine("Zadejte název prvku In");
                        break;
                    case ("Cín"):
                        Console.WriteLine("Zadejte název prvku Sn"); 
                        break;
                    case ("Antimon"):
                        Console.WriteLine("Zadejte název prvku Sb");
                        break;
                    case ("Tellur"):
                        Console.WriteLine("Zadejte název prvku Te");
                        break;
                    case ("Jod"):
                        Console.WriteLine("Zadejte název prvku I");
                        break;
                    case ("Xenon"):
                        Console.WriteLine("Zadejte název prvku Xe");
                        break;
                    case ("Cesium"):
                        Console.WriteLine("Zadejte název prvku Cs");
                        break;
                    case ("Baryum"):
                        Console.WriteLine("Zadejte název prvku Ba");
                        break;
                    case ("Thallium"):
                        Console.WriteLine("Zadejte název prvku Tl");
                        break;
                    case ("Olovo"):
                        Console.WriteLine("Zadejte název prvku Pb");
                        break;
                    case ("Bismut"):
                        Console.WriteLine("Zadejte název prvku Bi");
                        break;
                    case ("Polonium"):
                        Console.WriteLine("Zadejte název prvku Po");
                        break;
                    case ("Astat"):
                        Console.WriteLine("Zadejte název prvku At");
                        break;
                    case ("Radon"):
                        Console.WriteLine("Zadejte název prvku Rn");
                        break;
                    case ("Francium"):
                        Console.WriteLine("Zadejte název prvku Fr");
                        break;
                    case ("Radium"):
                        Console.WriteLine("Zadejte název prvku Ra");
                        break;
                    case ("Nihonium"):
                        Console.WriteLine("Zadejte název prvku Nh");
                        break;
                    case ("Flerovium"):
                        Console.WriteLine("Zadejte název prvku Fl");
                        break;
                    case ("Moscovium"):
                        Console.WriteLine("Zadejte název prvku Mc");
                        break;
                    case ("Livermorium"):
                        Console.WriteLine("Zadejte název prvku Lv");
                        break;
                    case ("Tennessin"):
                        Console.WriteLine("Zadejte název prvku Ts");
                        break;
                    case ("Oganesson"):
                        Console.WriteLine("Zadejte název prvku Og");
                        break;
                    case ("Železo"):
                        Console.WriteLine("Zadejte název prvku Fe");
                        break;
                    case ("Kobalt"):
                        Console.WriteLine("Zadejte název prvku Co");
                        break;
                    case ("Nikl"):
                        Console.WriteLine("Zadejte název prvku Ni");
                        break;
                    case ("Měď"):
                        Console.WriteLine("Zadejte název prvku Cu");
                        break;
                    case ("Stříbro"):
                        Console.WriteLine("Zadejte název prvku Ag");
                        break;
                    case ("Zlato"):
                        Console.WriteLine("Zadejte název prvku Au");
                        break;
                }
                string answer = Console.ReadLine();
                if( answer.ToLower() == currentElement.ToLower())
                {
                    Console.WriteLine("Správně!");
                    correctAnsweredQuestions++;
                }
                else
                {
                    Console.WriteLine($"Špatně, byl to {currentElement}");
                }
            }
            Console.WriteLine($"Správné odpovědi {correctAnsweredQuestions}/{numberOfQuestions}");
            Console.ReadLine();
        }
    }
}
