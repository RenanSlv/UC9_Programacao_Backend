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
            throw new NotImplementedException();
        }

        //método herdado da interface IPessoaJuridica
        public bool ValidarCnpj(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}