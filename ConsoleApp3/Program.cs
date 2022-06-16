using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   internal class Program
   {
      static void Main(string[] args)
      {


         string mesExtenso = null;
         int dia, mes, ano;
         DateTime DataConvertida;
         Console.Clear();
         Console.WriteLine("Ditige uma data:");
         var DataAtual = Console.ReadLine();
         if (DateTime.TryParse(DataAtual, out DataConvertida))
         {
            do { 
               mes = DataConvertida.Month;
               dia = DataConvertida.Day;
               ano = DataConvertida.Year;

               switch (mes)
               {
                  case 1:
                     mesExtenso = "Janeiro";
                     break;
                  case 6:
                     mesExtenso = "Junho";
                     break;
               }
               Console.WriteLine(dia + " de " + mesExtenso + " de " + ano + ".");
               Console.ReadKey();
               Console.Clear();
               Console.WriteLine("Ditige uma data:");
               DataAtual = Console.ReadLine();
            } while (DateTime.TryParse(DataAtual, out DataConvertida));
            Console.WriteLine("Final.");
            Console.ReadKey();
         }
         else
         {
            Console.WriteLine("Data inválida");
            Console.ReadKey();
         }
      }
   }
}

