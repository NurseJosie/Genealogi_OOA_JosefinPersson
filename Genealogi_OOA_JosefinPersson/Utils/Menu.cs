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
            bool run = true;

            while (run)
            {
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

                Console.WriteLine("Meny");
                Console.WriteLine("1) Create");
                Console.WriteLine("2) Read(Find)");
                Console.WriteLine("3) Update");
                Console.WriteLine("4) Delete");
                Console.WriteLine("5) Namnlista på viss bokstav eller födelseår");
                Console.WriteLine("6) Visa mor- och farföräldrar");
                Console.WriteLine("7) Visa barn(spec. persons barn?, +husdjur)");
                Console.WriteLine("8) Exit");


                string userInput = Console.ReadLine();
                int input = 0;
                int.TryParse(userInput, out input);


                switch (input)
                {
                    case 1:
                     
                        break;
                    case 2:
                        // input bokstav -> visa
                        //input årtal -> visa
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                       
                        break;
                    case 6:
                      
                        break;
                    case 7:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Ange en siffra mellan 1-8.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
