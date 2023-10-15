using CotacaoDolar;

Console.Write("QUAL É A COTAÇÃO DO DOLAR? ");
ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());

Console.Write("QUANTOS DOLARES VOCÊ VAI COMPRAR? ");
ConversorDeMoeda.QuatidadeDolares = double.Parse(Console.ReadLine());

Console.Write("VALOR A SER PAGO EM REAIS: ");
Console.WriteLine(ConversorDeMoeda.ValorASerPago());