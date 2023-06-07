using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeaula005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cupom10;
            string nome;
            string pergunta;



            Console.WriteLine("digite seu nome"); nome = Console.ReadLine();
            Console.WriteLine("\nDigite seu cupom de desconto:"); 
           cupom10 = Console.ReadLine();

            if (cupom10 == "Zak10")
            {
                Console.WriteLine("Parabéns você receu 10% de desconto na sua próxima viagem");
            }
            else 
            {
                Console.WriteLine("esse cupom não existe");
            
            }
            Console.WriteLine("\nVocê gostaria de receber promoções no seu e-mail?");
            pergunta = Console.ReadLine();
            if (pergunta == "sim")
           {
                Console.WriteLine($"Obrigado {nome} por se registrar você receberá novos e-mails em breve.");
                            
            }
            else
            {
                Console.WriteLine("Ok, você não receberá e-mails de promoções.");
            }
            Console.WriteLine("Obrigado e volte sempre");


            Console.ReadKey();

            
            
            








        }
    }
}
