using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE11.Classes
{
    static class Utils{
        public static void BarraDeLoading(string texto, int tempo, int quantidade){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(texto);
            for(var i = 0; i < quantidade; i++){
            Console.Write($".");
            Thread.Sleep(tempo);
            }
        Console.ResetColor();
        }
    }
}