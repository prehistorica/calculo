
using System;
using System.Security;
using System.Windows;


namespace calculodias_da_vida_no_console
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.Title = "Calcule Quantos Dias Você Têm de Vida";
            int idade;
            string nome;
            string resp;
            int op; 

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Menu Principal");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Dias da Vida");
                Console.WriteLine("2 - Sair");
                Console.WriteLine(" ");
                Console.WriteLine("Escolha uma Opção");
                op = int.Parse(Console.ReadLine());



                switch (op) {

                    case 1:
                        Console.Clear();
                        
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Qual o seu nome?");
                        Console.WriteLine(" ");
                        nome = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("Olá " + nome);
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite a sua Idade");
                        Console.WriteLine(" ");
                        try
                        {
                            idade = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {

                            throw new Exception(ex.Message);
                        }


                       
                        Console.WriteLine(" ");
                        Console.WriteLine("A sua idade em segundos, até o momento digitado é de: " + idade * 31622400 + " segundos");
                        Console.WriteLine(" ");
                        Console.WriteLine(+idade * 525600 + " minutos");
                        Console.WriteLine(" ");
                        Console.WriteLine(+idade * 8760 + " horas");
                        Console.WriteLine(" ");
                        Console.WriteLine(+idade * 365 + " dias");
                        Console.WriteLine(" ");
                        Console.WriteLine(+idade * 52 + " semanas");
                        Console.WriteLine(" ");
                        Console.WriteLine("e " + idade * 12 + " meses");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("Deseja Pesquisar Novamente?");
                        Console.WriteLine("Aperte qualquer tecla para pesquisar novamente ou a tecla 'N' para Sair");
                        Console.WriteLine(" ");
                        resp = Console.ReadLine(); 
                        
                           
                        if (resp == "n" || resp == "N") 
                        {
                            Console.WriteLine("Até breve");
                            Environment.Exit(0);
                            

                        }

                        else
                        {
                            Console.WriteLine("Tente Novamente");
                            Console.Clear();
                            
                        }
                       
                        break;

                    case 2:

                        Console.WriteLine("Até breve");
                        break;

                    default:
                        
                        Console.WriteLine("Algo deu Errado. Repita a Ação");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        break; 
                }

                } while (op != 2) ;

            }

       
        }
    }

   



    
 

