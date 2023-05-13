// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Seja bem vindo!!");

Console.WriteLine("Digite a opção desejada: \n 1-GASOLINA \n 2-ETANOL");

var opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    Console.WriteLine("Voce selecionou GASOLINA");

    Console.WriteLine("Digite a quatidade de litros desejada: \n");

    var LitrosGasolina = int.Parse(Console.ReadLine());
    double ValorUnitarioGasolina = LitrosGasolina * 4.89;

    if (LitrosGasolina <= 20)
    {
        double desconto = ValorUnitarioGasolina - ((LitrosGasolina * 4) / 100);
        Console.WriteLine("Valor total a pagar: " + ValorUnitarioGasolina);
        Console.WriteLine("Uhuul temos um descontinho de 4% para voce!! \n");
        Console.WriteLine("Valor total a pagar com desconto: " + desconto);

    }

    else if (LitrosGasolina > 20)
    {
        double desconto = ValorUnitarioGasolina - ((ValorUnitarioGasolina * 6) / 100);
        Console.WriteLine("Valor total a pagar: " + ValorUnitarioGasolina);
        Console.WriteLine("Uhuul temos um descontinho de 6% para voce!! \n");
        Console.WriteLine("Valor total a pagar com desconto: " + desconto);
    }




}
else if (opcao == 2)
{
   Console.WriteLine("Voce selecionou ETANOL");


    Console.WriteLine("Digite a quatidade de litros desejada: \n");

    var LitrosEtanol = int.Parse(Console.ReadLine());
    double ValorUnitarioEtanol = LitrosEtanol * 3.99;

    if (LitrosEtanol <= 20)
    {
        double desconto = ValorUnitarioEtanol - ((ValorUnitarioEtanol * 3) / 100);
        Console.WriteLine("Valor total a pagar: " + ValorUnitarioEtanol);
        Console.WriteLine("Uhuul temos um descontinho de 3% para voce!! \n");
        Console.WriteLine("Valor total a pagar com desconto: " + desconto);
        
    }

    else if (LitrosEtanol > 20 )
    {
        double desconto = ValorUnitarioEtanol - ((ValorUnitarioEtanol * 5) / 100);
        Console.WriteLine("Valor total a pagar: " + ValorUnitarioEtanol);
        Console.WriteLine("Uhuul temos um descontinho de 5% para voce!! \n");
        Console.WriteLine("Valor total a pagar com desconto: " + desconto);
    }

    
}
else
{
    Console.WriteLine("OPCAO INVALIDA");
}
