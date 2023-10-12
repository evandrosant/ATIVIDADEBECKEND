using ATIVIDADEBECKEND.classes;

Console.Clear();
Console.WriteLine(@"
   1 - Cadastrar pj
   2 - Sair do Sistema
");

string? opcao = Console.ReadLine();
PessoaJuridica metodosPJ = new PessoaJuridica();

if(opcao == "1" )
{

    // Cadastro
    PessoaJuridica pj = new PessoaJuridica();

    // Perguntar para o usuário
    Console.WriteLine("Informe o nome da PJ: ");
    pj.Nome = Console.ReadLine();

    Console.WriteLine("Informe o rendimento do PJ: ");
    pj.Rendimento = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe o CNPJ da PJ: ");
    pj.CNPJ = Console.ReadLine();

    metodosPJ.Inserir(pj);

    Console.WriteLine("\n\nPessoa Juridica cadastrada com sucesso!!");

}
else if (opcao == "2")
{
    // Sair do Sistema
    Console.Clear();

    Console.WriteLine("Obrigado por usar nosso sitema!");

}
else{
    Console.Clear();

    Console.WriteLine("Opçao invalida, por favor tente novamente.");
    
}
