using System.Text.RegularExpressions;
using Cadastro_Pessoas_PBE11.Interfaces;

namespace Cadastro_Pessoas_PBE11.Classes
{   
    //classe PessoaJuridica que herda da classe abstrata e de sua interface
    public class PessoasJuridica : Pessoa, IPessoaJuridica
    {   
        //atributos
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }

        //método herdado como sobescrita da classe abstrata
        public override float PagarImposto(float rendimento)
        {
            if(rendimento <= 3000){
                return rendimento * 0.03f;
            }else if(rendimento > 3000 && rendimento <= 6000){
                return rendimento * 0.05f;
            }else if(rendimento > 6000 && rendimento <= 10000){
                return rendimento * 0.07f;
            }else{
                return rendimento * 0.09f;
            }
        }

        //método herdado da interface IPessoaJuridica
        //verificar 2 jeitos de CNPJ
        // 58.566.555/0001-55 = 18 caracteres
        //58566555000155 = 14 caracteres
        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")){
                if(cnpj.Length == 18){
                    if(cnpj.Substring(11, 4) == "0001"){
                        return true;
                    }
                }else if (cnpj.Length == 14){
                    if(cnpj.Substring(8, 4) == "0001"){
                        return true;
                    }
                }
            }return false;
        }


    }
}