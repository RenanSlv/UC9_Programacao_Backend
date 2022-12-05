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
        public bool ValidarCnpj(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}