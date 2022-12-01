//instanciar um objeto da classe PessoaFisica
using Cadastro_Pessoas_PBE11.Classes;

//Instanciar um objeto da classe PessoaFisica
PessoaFisica novaPf = new PessoaFisica();

//atribuindo valores papra os atributos do objeto
novaPf.Nome = "Renan";
novaPf.Rendimento = 50000.58f;

//imprimindo no console os valores desses atributos
Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.Rendimento);

//Instanciar um objeto da classe PessoaJuridica
PessoasJuridica novaPj = new PessoasJuridica();
//atribuimos valores para os atributos do objeto
novaPj.RazaoSocial = "Senai Informática";

//Imprimindo no console os valores desses atributos
Console.WriteLine("Razão Social Pj : " + novaPj.RazaoSocial );
Console.WriteLine($"Razão Social Pj : {novaPj.RazaoSocial} ");