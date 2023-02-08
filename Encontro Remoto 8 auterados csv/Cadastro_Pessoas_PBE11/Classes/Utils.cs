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

        
        //metodo que verifica se o caminho exite : "Database/PessoaJuridica.csv"
        public static void VerificarPastaArquivo(string caminho){
            //varivel que vai receber a posição 0 do meu caminho (Database)
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminho)){
                File.Create(caminho);
            }

        }


    }
}