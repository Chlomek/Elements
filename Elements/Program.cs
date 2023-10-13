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
            bool end = false;
            do
            {

                string gameMode = "1";
                int numberOfQuestions = 20;
                bool latinNames = false;
                string usageOfLatin = "ne";
                bool reset = false;

                //Inicializace proměnných
                Random rnd = new Random();
                int correctAnsweredQuestions = 0;
                string answerVariant;
                string[] optionalElement = { "Rubidium", "Stroncium", "Indium", "Bismut", "Polonium", "Baryum", "Thallium", "Cesium", "Radon", "Francium", "Radium", "Nihonium", "Flerovium", "Moscovium", "Livermorium", "Tennessin", "Oganesson", };
                string[] elementName = { "Vodík", "Helium", "Lithium", "Beryllium", "Bor", "Uhlík", "Dusík", "Kyslík", "Fluor", "Neon", "Sodík", "Hořčík", "Hliník", "Křemík", "Fosfor", "Síra", "Chlor", "Argon", "Draslík", "Vápník", "Gallium", "Germanium", "Arsen", "Selen", "Brom", "Krypton", "Cín", "Antimon", "Tellur", "Jod", "Xenon", "Olovo", "Astat", "Železo", "Kobalt", "Nikl", "Měď", "Stříbro", "Zlato", };
                string usageOfOptional;
                int rnd1;
                int elementStringLenght = 0;

                do
                {
                    reset = false;
                    Console.Clear();

                    //Výběr herního režimu
                    Console.WriteLine("Vítejte v programu pro procvičování názvů prvků");
                    Console.WriteLine("vyberte herní režim");
                    Console.WriteLine(" - 1) Typování názvů");
                    Console.WriteLine(" - 2) Typování značek");

                    gameMode = Console.ReadLine();

                    if (gameMode == "1" || gameMode == "2")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Neplatný herní režim");
                        reset = true;
                        Console.ReadLine();
                    }

                    if (reset == false)
                    {
                        //Výběr základní nebo rozšířené varianty
                        Console.WriteLine("Chcete použít i pokročilé prvky? (ano/ne)");
                        usageOfOptional = Console.ReadLine();

                        if (usageOfOptional.ToLower() == "ano" || usageOfOptional.ToLower() == "a")
                        {
                            elementName = elementName.Concat(optionalElement).ToArray();
                            elementStringLenght = 56;
                            usageOfOptional = "ano";
                        }
                        else
                        {
                            elementStringLenght = 39;
                        }
                        //Použití latinských názvů
                        if (gameMode == "1" && reset == false)
                        {
                            Console.WriteLine("Chcete použít i latinské názvy? (ano/ne)");
                            usageOfLatin = Console.ReadLine();

                            if (usageOfLatin.ToLower() == "ano" || usageOfLatin.ToLower() == "a")
                            {
                                latinNames = true;
                            }
                            else
                            {
                                latinNames = false;
                            }
                        }
                        //Vybrání počtu otázek
                        Console.WriteLine("Vyberte počet otázek (zadejte pouze číslice)");
                        Console.WriteLine(" - 15");
                        Console.WriteLine(" - 25");
                        Console.WriteLine(" - 40");
                        Console.WriteLine(" - jiný počet");

                        string numberOfQuestionsString = Console.ReadLine();

                        if (int.TryParse(numberOfQuestionsString, out numberOfQuestions))
                        {
                            if (numberOfQuestions > elementStringLenght)
                            {
                                Console.WriteLine($"Počet otázek musí být menší než {elementStringLenght + 1}");
                                reset = true;
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Neplatný počet otázek");
                            reset = true;
                            Console.ReadLine();
                        }
                    }
                } while (reset == true);

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    //Výběr prvku a vypsání
                    rnd1 = rnd.Next(0, elementStringLenght - i);
                    string currentElement = elementName[rnd1];
                    answerVariant = "<.|.>";
                    string element = "<.|.>";
                    string latin = "<.|.>";

                    elementName = elementName.Where(val => val != currentElement).ToArray();

                    switch (currentElement)
                    {
                        case "Vodík":
                            element = "H";
                            answerVariant = "vodik";
                            latin = "Hydrogenium";
                            break;
                        case "Helium":
                            answerVariant = "helium";
                            element = "He";
                            latin = "Helium";
                            break;
                        case "Lithium":
                            answerVariant = "lithium";
                            element = "Li";
                            latin = "Lithium";
                            break;
                        case "Beryllium":
                            answerVariant = "berylium";
                            element = "Be";
                            latin = "Beryllium";
                            break;
                        case "Bor":
                            answerVariant = "bor";
                            element = "B";
                            latin = "Borum";
                            break;
                        case "Uhlík":
                            answerVariant = "uhlik";
                            element = "C";
                            latin = "Carboneum";
                            break;
                        case "Dusík":
                            element = "N";
                            answerVariant = "dusik";
                            latin = "Nitrogenium";
                            break;
                        case "Kyslík":
                            element = "O";
                            answerVariant = "kyslik";
                            latin = "Oxygenium";
                            break;
                        case "Fluor":
                            element = "F";
                            answerVariant = "fluor";
                            latin = "Fluorum";
                            break;
                        case "Neon":
                            element = "Ne";
                            answerVariant = "neon";
                            latin = "Neon";
                            break;
                        case "Sodík":
                            element = "Na";
                            answerVariant = "sodik";
                            latin = "Natrium";
                            break;
                        case "Hořčík":
                            element = "Mg";
                            answerVariant = "horcik";
                            latin = "Magnesium";
                            break;
                        case "Hliník":
                            element = "Al";
                            answerVariant = "hlinik";
                            latin = "Aluminium";
                            break;
                        case "Křemík":
                            element = "Si";
                            answerVariant = "kremik";
                            latin = "Silicium";
                            break;
                        case "Fosfor":
                            element = "P";
                            answerVariant = "fosfor";
                            latin = "Phosphorus";
                            break;
                        case "Síra":
                            element = "S";
                            answerVariant = "sira";
                            latin = "Sulphur";
                            break;
                        case "Chlor":
                            element = "Cl";
                            answerVariant = "chlor";
                            latin = "Chlorum";
                            break;
                        case "Argon":
                            element = "Ar";
                            answerVariant = "argon";
                            latin = "Argon";
                            break;
                        case "Draslík":
                            element = "K";
                            answerVariant = "draslik";
                            latin = "Kalium";
                            break;
                        case "Vápník":
                            element = "Ca";
                            answerVariant = "vapnik";
                            latin = "Calcium";
                            break;
                        case "Gallium":
                            element = "Ga";
                            answerVariant = "gallium";
                            latin = "Gallium";
                            break;
                        case "Germanium":
                            element = "Ge";
                            answerVariant = "germanium";
                            latin = "Germanium";
                            break;
                        case "Arsen":
                            element = "As";
                            answerVariant = "arsen";
                            latin = "Arsenicum";
                            break;
                        case "Selen":
                            element = "Se";
                            answerVariant = "selen";
                            latin = "Selenium";
                            break;
                        case "Brom":
                            element = "Br";
                            answerVariant = "brom";
                            latin = "Bromum";
                            break;
                        case "Krypton":
                            element = "Kr";
                            answerVariant = "krypton";
                            latin = "Krypton";
                            break;
                        case "Rubidium":
                            element = "Rb";
                            answerVariant = "rubidium";
                            latin = "Rubidium";
                            break;
                        case "Stroncium":
                            element = "Sr";
                            answerVariant = "stroncium";
                            latin = "Strontium";
                            break;
                        case "Indium":
                            element = "In";
                            answerVariant = "indium";
                            latin = "Indium";
                            break;
                        case "Cín":
                            element = "Sn";
                            answerVariant = "cin";
                            latin = "Stannum";
                            break;
                        case "Antimon":
                            element = "Sb";
                            answerVariant = "antimon";
                            latin = "Stibium";
                            break;
                        case "Tellur":
                            element = "Te";
                            answerVariant = "tellur";
                            latin = "Tellurium";
                            break;
                        case "Jod":
                            element = "I";
                            answerVariant = "jod";
                            latin = "Iodium";
                            break;
                        case "Xenon":
                            element = "Xe";
                            answerVariant = "xenon";
                            latin = "Xenon";
                            break;
                        case "Cesium":
                            element = "Cs";
                            answerVariant = "cesium";
                            latin = "Caesium";
                            break;
                        case "Baryum":
                            element = "Ba";
                            answerVariant = "baryum";
                            latin = "Barium";
                            break;
                        case "Thallium":
                            element = "Tl";
                            answerVariant = "thallium";
                            latin = "Thallium";
                            break;
                        case "Olovo":
                            element = "Pb";
                            answerVariant = "olovo";
                            latin = "Plumbum";
                            break;
                        case "Bismut":
                            element = "Bi";
                            answerVariant = "bismut";
                            latin = "Bismutum";
                            break;
                        case "Polonium":
                            element = "Po";
                            answerVariant = "polonium";
                            latin = "Polonium";
                            break;
                        case "Astat":
                            element = "At";
                            answerVariant = "astat";
                            latin = "Astatium";
                            break;
                        case "Radon":
                            element = "Rn";
                            answerVariant = "radon";
                            latin = "Radon";
                            break;
                        case "Francium":
                            element = "Fr";
                            answerVariant = "francium";
                            latin = "Francium";
                            break;
                        case "Radium":
                            element = "Ra";
                            answerVariant = "radium";
                            latin = "Radium";
                            break;
                        case "Nihonium":
                            element = "Nh";
                            answerVariant = "nihonium";
                            latin = "Nihonium";
                            break;
                        case "Flerovium":
                            element = "Fl";
                            answerVariant = "flerovium";
                            latin = "Flerovium";
                            break;
                        case "Moscovium":
                            element = "Mc";
                            answerVariant = "moscovium";
                            latin = "Moscovium";
                            break;
                        case "Livermorium":
                            element = "Lv";
                            answerVariant = "livermorium";
                            latin = "Livermorium";
                            break;
                        case "Tennessin":
                            element = "Ts";
                            answerVariant = "tennessin";
                            latin = "Tennessin";
                            break;
                        case "Oganesson":
                            element = "Og";
                            answerVariant = "oganesson";
                            latin = "Oganesson";
                            break;
                        case "Železo":
                            element = "Fe";
                            answerVariant = "zelezo";
                            latin = "Ferrum";
                            break;
                        case "Kobalt":
                            element = "Co";
                            answerVariant = "kobalt";
                            latin = "Cobaltum";
                            break;
                        case "Nikl":
                            element = "Ni";
                            answerVariant = "nikl";
                            latin = "Niccolum";
                            break;
                        case "Měď":
                            element = "Cu";
                            answerVariant = "med";
                            latin = "Cuprum";
                            break;
                        case "Stříbro":
                            element = "Ag";
                            answerVariant = "stribro";
                            latin = "Argentum";
                            break;
                        case "Zlato":
                            element = "Au";
                            answerVariant = "zlato";
                            latin = "Aurum";
                            break;
                    }

                    if (latinNames == false)
                    {
                        latin = "<.|.>";
                    }

                    if (gameMode == "1")
                    {
                        Console.WriteLine($"Zadejte název prvku {element}");
                        //Kontrola odpovědi
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == currentElement.ToLower() || answer.ToLower() == answerVariant || answer.ToLower() == latin.ToLower())
                        {
                            Console.WriteLine("Správně!");
                            correctAnsweredQuestions++;
                        }
                        else if (answer == "stop")
                        {
                            Console.WriteLine("Hra ukončena");
                            Console.WriteLine("Chcete zpět do výběru? (ano/ne)");

                            string returnToLobby = Console.ReadLine();
                            if (returnToLobby.ToLower() == "ano" || returnToLobby.ToLower() == "a")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hra ukončena");
                                Console.ReadLine();
                                end = true;
                                return;
                            }
                        }
                        else if (latinNames == true)
                        {
                            Console.WriteLine($"Špatně, byl to {currentElement}, latinsky {latin}");
                        }
                        else
                        {
                            Console.WriteLine($"Špatně, byl to {currentElement}");
                        }
                    }
                    else if (gameMode == "2")
                    {
                        Console.WriteLine($"Zadejte značku prvku {currentElement}");
                        //Kontrola odpovědi
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == element.ToLower())
                        {
                            Console.WriteLine("Správně!");
                            correctAnsweredQuestions++;
                        }
                        else if (answer == "stop")
                        {
                            Console.WriteLine("Hra ukončena");
                            Console.WriteLine("Chcete zpět do výběru? (ano/ne)");

                            string returnToLobby = Console.ReadLine();
                            if(returnToLobby.ToLower() == "ano" || returnToLobby.ToLower() == "a")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hra ukončena");
                                Console.ReadLine();
                                end = true;
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Špatně, byl to {element}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Neplatný herní režim");
                        Console.ReadLine();
                        return;
                    }
                }
                //Počet správných odpovědí
                Console.WriteLine($"Správné odpovědi {correctAnsweredQuestions}/{numberOfQuestions}");
                Console.ReadLine();

                //Hrát znovu
                Console.WriteLine("Chcete hrát znovu? (ano/ne)");
                string playAgain = Console.ReadLine();
                if(playAgain.ToLower() == "ano" || playAgain.ToLower() == "a")
                {
                    end = false;
                }
                else
                {
                    end = true;
                }

            } while (end == false);
        }
    }
}
