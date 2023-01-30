//instanciar um objeto da classe PessoaFisica
using System.Globalization;
using System.Text.RegularExpressions;
using Cadastro_Pessoas_PBE11.Classes;

Console.WriteLine(@$"
=============================================

        Bem vindo ao sistema de cadastro
    de Pessoas Físicas e Pessoas Jurídicas

=============================================
");
/*
Console.BackgroundColor = ConsoleColor.Green;
//barra de carregamento
Console.Write($"Iniciando");

for(var i = 0; i < 7; i++){
    Console.Write($".");
    Thread.Sleep(300);
}
Console.ResetColor();
*/
Utils.BarraDeLoading("Iniciando", 350, 7);
string? opcao;
do{
Console.Clear();
Console.WriteLine(@$"
=============================================

        Escolha uma das opções abaixo:

        1. Pessoa Física
        2. Pessoa Jurídica

        0. Sair

=============================================
");

opcao = Console.ReadLine();
switch (opcao){
    case "1":
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

        Console.Clear();
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
        Console.WriteLine($"Aperte a tecla ENTER para continuar");
        Console.ReadLine();
        break;
    case "2":
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

        Console.Clear();
        Console.WriteLine(@$"
        ========================================

                    Pessoa Jurídica

        ========================================
           Razão Social : {novaPj.RazaoSocial}
           CNPJ : {novaPj.Cnpj}
           CNPJ válido : {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Cnpj válido" : "Cnpj Invalido")}
           Rendimento : {novaPj.Rendimento.ToString("C", new CultureInfo("pt-br"))}
           Imposto a pagar : {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C", new CultureInfo("pt-br"))}
           Endereço : {novaPj.Endereco.Logradouro}. {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}, {novaPj.Endereco.Comercial}
        ");
        Console.WriteLine($"Aperte a tecla ENTER para continuar");
        Console.ReadLine();
        break;
    case "0":
        Console.Clear();
        Console.WriteLine("Obrigado por utilizar o nosso Sistema.");
        Thread.Sleep(500);
        break;
    default:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opção inválida, escolha uma opção válida.");
        Console.ResetColor();
        Thread.Sleep(500);
        break;
}
}while(opcao != "0");

Utils.BarraDeLoading("Finalizando", 300, 7);

// exemplo de expressão regular (regex) para validar um formato de data
// validação de um formato de data: DD/MM/AAAA
/*string data = "01/11/2022";
bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
Console.WriteLine(valido);

// exemplo de substring
string texto = "Ferrari";
string substring = texto.Substring(0, 4);
Console.WriteLine(substring);
*/
