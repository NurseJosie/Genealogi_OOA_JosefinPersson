using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Genealogi_OOA_JosefinPersson.Utils
{
    class Menu
    {
        public void mainMenu()
        {
            FamilyTree familyTree = new();
            familyTree.StarkFamily();

            bool run = true;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                   ; ; ;");
            Console.WriteLine("                  ;        ;  ;     ;;    ;");
            Console.WriteLine("               ;                 ;         ;  ;");
            Console.WriteLine("                               ;");
            Console.WriteLine("                              ;                ;;");
            Console.WriteLine("              ;          ;            ;              ;");
            Console.WriteLine("              ;            ';,        ;               ;");
            Console.WriteLine("              ;              'o      *");
            Console.WriteLine("               ;              '$    ;;                ;;");
            Console.WriteLine("             ;    ;           $:   ;:               ;");
            Console.WriteLine("            ; ;      ;  ;;      *;  @):        ;   ; ;");
            Console.WriteLine("                         ;     :@,@):   ,;**:'   ;");
            Console.WriteLine("             ;      ;,         :@@*: ;;**'      ;   ;");
            Console.WriteLine("                      ';o;    ;:(@';@*'  ");
            Console.WriteLine("              ;  ;       'JP,;;:,@@*'   ,*      ;  ;");
            Console.WriteLine("                         , @@@@,:@)'   ;*'      ;");
            Console.WriteLine("                  ;     '  ; '@@@@*'   ;  ;");
            Console.WriteLine("                   ;  ; ;;    @@'.'    ;  ;");
            Console.WriteLine("                             :@@:.");
            Console.WriteLine("                            .:@:'.");
            Console.WriteLine("                          .::@@:.");
            Console.WriteLine();
            Console.WriteLine("                    THE STARK FAMILY TREE");
            Console.WriteLine("                      ~WINTER IS COMING~");
            Thread.Sleep(5000);
            Console.Clear();

            while (run)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1) Create: new Stark family member");
                Console.WriteLine("2) Read: list of all family members");
                Console.WriteLine("3) Read: list by first letter");
                Console.WriteLine("4) Read: list by birth year");
                Console.WriteLine("5) Update: family member");
                Console.WriteLine("6) Delete: family member");
                Console.WriteLine("7) Search for parents");
                Console.WriteLine("8) Search for children");
                Console.WriteLine("9) Search for siblings");
                Console.WriteLine("10) Exit");

                string userInput = Console.ReadLine();
                int menuInput = 0;
                int.TryParse(userInput, out menuInput);
                PersonCrud personCrud = new PersonCrud();


                switch (menuInput)
                {
                    case 1:
                        personCrud.Create();
                        Console.Clear();
                        break;
                    case 2:
                        personCrud.Read();
                        Console.Clear();
                        break;
                    case 3:
                        personCrud.ReadFirstLetter();
                        Console.Clear();
                        break;
                    case 4:
                        personCrud.ReadBirthYear();
                        Console.Clear();
                        break;
                    case 5:
                        // update
                        Console.Clear();
                        break;
                    case 6:
                        // delete
                        Console.Clear();
                        break;
                    case 7:
                        // parents
                        Console.Clear();
                        break;
                    case 8:
                        // children
                        Console.Clear();
                        break;
                    case 9:
                        //siblings
                        Console.Clear();
                        break;
                    case 10:
                        run = false;
                        break;
                  
                    default:
                        Console.WriteLine("Input a number between 1-10.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
