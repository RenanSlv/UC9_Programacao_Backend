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
List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoasJuridica> listaPj = new List<PessoasJuridica>();
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
switch(opcao){
    //Opção Pessoa Física
    case "1":
        String? opcaoPF = "3";

        do{

            Console.Clear();
            Console.WriteLine(@$"
=============================================

    Escolha uma das opções abaixo:

    1. Cadastrar Pessoa Física
    2. Listar Pessoa Física

    0. Voltar ao menu anterior

=============================================
            ");
        
            opcaoPF = Console.ReadLine();

            PessoaFisica metodosPf = new PessoaFisica();

            switch(opcaoPF){
                //Cadastrando Pessoa Física
                case "1":
                    //Instanciar um objeto da classe PessoaFisica
                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco endPf = new Endereco();

                    //atribuindo valores papra os atributos do objeto
                    //novaPf.Nome = "Renan";
                    Console.WriteLine(@$"Digite o nome:");
                    novaPf.Nome = Console.ReadLine();

                    Console.WriteLine(@$"Digite o CPF:");
                    novaPf.Cpf = Console.ReadLine();

                    bool dataValida = false;
                    do{
                        Console.WriteLine(@$"Digite a data de nascimento EX:DD/MM/AAAA :");
                        string? dataNasc = Console.ReadLine();

                        dataValida = metodosPf.ValidarDataNascimento(dataNasc);

                        if(dataValida){
                            DateTime dataConvertida;

                            DateTime.TryParse(dataNasc, out dataConvertida);
                            novaPf.DataNascimento = dataConvertida;
                        }else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Data inválida! Favor digitar uma data válida: ");
                            Console.ResetColor();
                        }
                    }while(dataValida == false);

                    Console.WriteLine($"Digite o rendimento: ");
                    novaPf.Rendimento = float.Parse(Console.ReadLine());

                    //endPf.Logradouro = "Avenida Goias";
                    Console.WriteLine($"Digite o logradouro: ");
                    endPf.Logradouro = Console.ReadLine();
                
                    Console.WriteLine($"Digite o numero: ");
                    endPf.Numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o complemento: ");
                    endPf.Complemento = Console.ReadLine();

                    Console.WriteLine($"Este endereço é comercial ? Digite 'S' para sim ou 'N' para não:");
                    string? endComercial = Console.ReadLine().ToUpper();

                    if(endComercial == "S"){
                        endPf.Comercial = true;
                    }else {
                        endPf.Comercial = false;
                    }

                    novaPf.Endereco = endPf;
                
                    listaPf.Add(novaPf);

                    //Instanciado objeto StreamWriter para gerar um arquivo txt
                    //Escrevemos dentro desse arquivo o nome do objeto de pessoa física
                    //StreamWriter SW = new StreamWriter($"{novaPf.Nome}.txt"); // salvando arquivos txt com o nome da pessoa
                    //SW.WriteLine(novaPf.Nome);
                    //SW.Close();  //encerrar objeto com o StreamWriter (sem o using)

                    //Recurso de gravação com o StreamWriter
                    using(StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt")){
                        sw.WriteLine(novaPf.Nome);
                    }

                    Console.WriteLine($"Cadastro realizado com sucesso!");
                    Thread.Sleep(2500);

                break;
            
                //Listando Pessoa Física
                case "2":
                    
                    /*if(listaPf.Count > 0){
                        foreach (PessoaFisica cadaPessoa in listaPf){
                             Console.Clear();

                            //imprimindo no console os valores desses atributos
                           Console.WriteLine(@$"
                            Nome : {cadaPessoa.Nome}
                            CPF : {cadaPessoa.Cpf}
                            Data de Nascimento : {cadaPessoa.DataNascimento}
                            Maior de idade : {(metodosPf.ValidarDataNascimento(cadaPessoa.DataNascimento) ? "Sim, maior de idade" : "Não, é menor de idade") }
                            maior de idade(string) : {(metodosPf.ValidarDataNascimento("05/12/2000") ? "Sim" : "Não")}
                            Rendimento : {cadaPessoa.Rendimento.ToString("C", new CultureInfo("pt-br"))}
                            Imposto a pagar : {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C", new CultureInfo("pt-br"))}
                            Endereço : {cadaPessoa.Endereco.Logradouro}, {cadaPessoa.Endereco.Numero}, {cadaPessoa.Endereco.Complemento}, {cadaPessoa.Endereco.Comercial}
                            ");
                        }
                        Console.WriteLine($"Digite 'ENTER' para continuar...");
                        Console.ReadLine();
                    }else {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Lista Vazia!");
                        Console.ResetColor();
                        Console.WriteLine($"Digite 'ENTER' para continuar...");
                        Console.ReadLine();
                    }*/

                    //Recurso de leitura com o StreamReader
                    using(StreamReader sr = new StreamReader("Renan.txt")){
                        string? linha;

                        while((linha = sr.ReadLine()) != null){
                            Console.WriteLine($"{linha}");
                        }
                    }
                    Console.Write($"Digite ENTER para continuar...");
                    Console.ReadLine();

                break;
            
                //Saindo da opção Pessoa Física
                case "0":
                break;

                //Opção invalida
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opção inválida, por favor digite outra opção");
                    Console.ResetColor();
                    Thread.Sleep(2500);
                break;
            }
        
        }while(opcaoPF != "0");


        Console.WriteLine($"Aperte a tecla ENTER para continuar");
        Console.ReadLine();
        break;

    //Opção Pessoa Jurídica
    case "2":
        string? opcaoPJ = "3";

        //Instanciar um objeto da classe PessoaJuridica
        PessoasJuridica metodosPj = new PessoasJuridica();

            do{

                Console.Clear();
                Console.WriteLine(@$"
=============================================

    Escolha uma das opções abaixo:

    1. Cadastrar Pessoa Jurídica
    2. Listar Pessoa Jurídica

    0. Voltar ao menu anterior

=============================================
                ");

                opcaoPJ = Console.ReadLine();

                switch(opcaoPJ){
                    //Cadastrando Pessoa Jurídica
                    case "1":
                        PessoasJuridica novaPj = new PessoasJuridica();
                        Endereco endPj = new Endereco();

                        //atribuimos valores para os atributos do objeto
                        Console.WriteLine($"Digite a razão social: ");
                        novaPj.RazaoSocial = Console.ReadLine();

                        bool cnpjValido = false;
                        do{
                            Console.WriteLine(@$"Digite o CNPJ EX:XX.XXX.XXX/XXXX-XX ou XXXXXXXXXXXXXX :");
                            string? cnpjDig = Console.ReadLine();

                            cnpjValido = metodosPj.ValidarCnpj(cnpjDig);

                            if(cnpjValido){

                                novaPj.Cnpj = cnpjDig;
                            }else{
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"CNPJ invalido! Favor digitar um CNPJ válido: ");
                                Console.ResetColor();
                            }
                        }while(cnpjValido == false);

                        Console.WriteLine($"Digite o rendimento: ");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro: ");
                        endPj.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero: ");
                        endPj.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento: ");
                        endPj.Complemento = Console.ReadLine();
                        

                        endPj.Comercial = true;

                        novaPj.Endereco = endPj;

                        metodosPj.Inserir(novaPj);
                        Console.WriteLine($"Cadastro realizado com sucesso! Aperte ENTER para continuar");
                        Console.ReadLine();

                        /*List<PessoasJuridica> listaPju = metodosPj.LerArquivo();

                        foreach(PessoasJuridica cadaItem in listaPju){
                            Console.WriteLine(@$"
                            Nome Fantasia : {cadaItem.Nome}
                            Cnpj : {cadaItem.Cnpj}
                            Razão Social : {cadaItem.RazaoSocial}
                            ");
                            Console.WriteLine($"Aperte ENTER para continuar");
                            Console.ReadLine();                            
                        }*/

                    break;

                    //Listando Pessoa Jurídica
                    case "2":

                        List<PessoasJuridica> listaPju = metodosPj.LerArquivo();
                        foreach(PessoasJuridica cadaItem in listaPju){
                            Console.WriteLine(@$"
                            Razão Social : {cadaItem.RazaoSocial}
                            Cnpj: {cadaItem.Cnpj}
                            Rendimento : {cadaItem.Rendimento}
                            ");
                            Console.WriteLine("Aperte ENTER para continuar.");
                            Console.ReadLine();

                        }
                        /*if(listaPj.Count > 0){
                            foreach (PessoasJuridica cadaRz in listaPj){
                                Console.Clear();
                                //imprimindo no console os valores desses atributos
                                Console.WriteLine(@$"
                                Razão Social : {cadaRz.RazaoSocial}
                                CNPJ : {cadaRz.Cnpj}
                                CNPJ válido : {(metodosPj.ValidarCnpj(cadaRz.Cnpj) ? "Cnpj válido" : "Cnpj Invalido")}
                                Rendimento : {cadaRz.Rendimento.ToString("C", new CultureInfo("pt-br"))}
                                Imposto a pagar : {metodosPj.PagarImposto(cadaRz.Rendimento).ToString("C", new CultureInfo("pt-br"))}
                                Endereço : {cadaRz.Endereco.Logradouro}. {cadaRz.Endereco.Numero}, {cadaRz.Endereco.Complemento}, {cadaRz.Endereco.Comercial}
                                ");
                                Console.WriteLine($"Aperte a tecla ENTER para continuar");
                                Console.ReadLine();
                            }
                        }else{
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Lista Vazia!");
                            Console.ResetColor();
                            Console.WriteLine($"Digite 'ENTER' para continuar...");
                            Console.ReadLine();
                        }*/





                    break;

                    //Saindo da Opção Pessoa Jurídica
                    case "0":

                    break;

                    //Opção invalida
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção inválida, por favor digite outra opção");
                        Console.ResetColor();
                        Thread.Sleep(2500);
                    break;
                }
                
            }while(opcaoPJ != "0");
        
        break;

    //saindo do programa
    case "0":
        Console.Clear();
        Console.WriteLine("Obrigado por utilizar o nosso Sistema.");
        Thread.Sleep(500);
        break;

    //opção invalida
    default:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opção inválida, escolha uma opção válida.");
        Console.ResetColor();
        Thread.Sleep(500);
        break;
}
}while(opcao != "0");

StreamWriter StreamWriter(string v)
{
    throw new NotImplementedException();
}

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
