using Cadastro_Pessoas_PBE11.Interfaces;

namespace Cadastro_Pessoas_PBE11.Classes
{   
    //classe PessoaFisica que herda da classe abstrata e de sua interface
    public class PessoaFisica : Pessoa, IPessoaFisica
    {   
        //atributos
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        //método herdado como sobescrita da classe abstrata
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        //método herdado da interface IPessoaFisica
        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
    }
}