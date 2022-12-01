using Cadastro_Pessoas_PBE11.Interfaces;

namespace Cadastro_Pessoas_PBE11.Classes
{   
    //classe abstrata que herda de sua interface 
    public abstract class Pessoa : IPessoa
    {   
        //atributos
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public float Rendimento { get; set;}

        //método abstrato herdado da inteface
        public abstract float PagarImposto(float rendimento);

    }
}