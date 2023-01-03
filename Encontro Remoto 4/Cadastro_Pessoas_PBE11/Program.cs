//instanciar um objeto da classe PessoaFisica
using System.Globalization;
using Cadastro_Pessoas_PBE11.Classes;

//Instanciar um objeto da classe PessoaFisica
PessoaFisica novaPf = new PessoaFisica();

//atribuindo valores papra os atributos do objeto
novaPf.Nome = "Renan";
novaPf.Cpf = "01331328209";
novaPf.DataNascimento = new DateTime(2000, 01, 21);
novaPf.Rendimento = 25004.54f;

Endereco endPf = new Endereco();
endPf.Logradouro = "Avenida Goias";
endPf.Numero = 1020;
endPf.Complemento = "Casa";
endPf.Comercial = false;

novaPf.Endereco = endPf;

PessoaFisica metodosPf = new PessoaFisica();

//imprimindo no console os valores desses atributos
Console.WriteLine(@$"
========================================

            Pessoa Física

========================================
    Nome : {novaPf.Nome}
    CPF : {novaPf.Cpf}
    Data de Nascimento : {novaPf.DataNascimento}
    Maior de idade : {(metodosPf.ValidarDataNascimento(novaPf.DataNascimento) ? "Sim, maior de idade" : "Não, é menor de idade") }
    maior de idade(string) : {(metodosPf.ValidarDataNascimento("05/12/2000") ? "Sim" : "Não")}
    Rendimento : {novaPf.Rendimento.ToString("C", new CultureInfo("pt-br"))}
    Imposto a pagar : {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C", new CultureInfo("pt-br"))}
    Endereço : {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}, {novaPf.Endereco.Comercial}
");


//Instanciar um objeto da classe PessoaJuridica
PessoasJuridica novaPj = new PessoasJuridica();
//atribuimos valores para os atributos do objeto
novaPj.RazaoSocial = "Senai Informática";

novaPj.Cnpj = "18.021.496/0001-45";
novaPj.Rendimento = 1000000.99f;

Endereco endPj = new Endereco();
endPj.Logradouro = "Rua Niteroi";
endPj.Numero = 188;
endPj.Complemento = "Senai Informática";
endPj.Comercial = true;

novaPj.Endereco = endPj;

PessoasJuridica metodosPj = new PessoasJuridica();

Console.WriteLine(@$"
========================================

            Pessoa Jurídica

========================================
    Razão Social : {novaPj.RazaoSocial}
    CNPJ : {novaPj.Cnpj}
    Rendimento : {novaPj.Rendimento.ToString("C", new CultureInfo("pt-br"))}
    Imposto a pagar : {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C", new CultureInfo("pt-br"))}
    Endereço : {novaPj.Endereco.Logradouro}. {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}, {novaPj.Endereco.Comercial}
");