using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1.

            //float quant = 1, prec, quantTotal = 0, precTotal = 0, precTotalTotal = 0;

            //for (; quant > 0;)
            //{
            //    Console.WriteLine("Novo produto");
            //    Console.WriteLine("Digite a quantidade: ");
            //    quant = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o preço: ");
            //    prec = float.Parse(Console.ReadLine());


            //    quantTotal = quantTotal + quant;
            //    precTotal = prec * quantTotal;
            //    precTotalTotal += precTotal;
            //}
            //Console.WriteLine("Quantidade total: " + quantTotal);
            //Console.WriteLine("Preço total: " + precTotalTotal);
            //Console.ReadKey();

            //Exercício 2.

            //string nomeProdut, nomeMaior = "", nomeMenor = "";
            //float numItens, precComp, maiorValor, menorValor, cont = 2, total;

            //maiorValor = float.MinValue;
            //menorValor = float.MaxValue;

            //for (; cont != 1;)
            //{
            //    Console.WriteLine("Informe nome do produto: ");
            //    nomeProdut = Console.ReadLine();

            //    Console.WriteLine("Entre com a quantidade: ");
            //    numItens = float.Parse(Console.ReadLine());

            //    Console.WriteLine("Entre com o preço unitário: ");
            //    precComp = float.Parse(Console.ReadLine());

            //    total = numItens * precComp;

            //    if (total > maiorValor)
            //    {
            //        maiorValor = total;
            //        nomeMaior = nomeProdut;
            //    }
            //    if (total > menorValor)
            //    {
            //        menorValor = total;
            //        nomeMenor = nomeProdut;
            //    }

            //    Console.WriteLine("Digite 1 para sair ou 2 pra continuar: ");
            //    cont = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Maior quantia investida {0} no produto {1}: ", maiorValor, nomeMaior);
            //Console.WriteLine("Menor quantia investida {0} no produto {1}: ", menorValor, nomeMenor);
            //Console.ReadKey();

            //Exercício 3.

            //float numAvalia, peso, somaPeso = 0, i;

            //Console.WriteLine("Digite o número de avaliações de um bimestre: ");
            //numAvalia = int.Parse(Console.ReadLine());

            //for ( ; i > numAvalia ; )
            //{
            //    Console.WriteLine("Digite o peso da avaliação: ");
            //    peso = float.Parse(Console.ReadLine());

            //    somaPeso += peso;
            //}
            //if (somaPeso < 100)
            //    Console.WriteLine("A soma  total  dos  pesos  é insuficiente!");
            //if (somaPeso > 100)
            //    Console.WriteLine("A soma total dos pesos é excedente!");
            //else
            //    Console.WriteLine("A soma total dos pesos é adequada!");
            //Console.ReadKey();

            //Exercício 4.

            //string siglaEstado;

            //Console.WriteLine("=====MENU=====");
            //Console.WriteLine("1 - SP");
            //Console.WriteLine("1 - RJ");
            //Console.WriteLine("3 - MG");
            //Console.WriteLine("4 - ES");
            //Console.WriteLine("Digite a sigla do Estado: ");
            //siglaEstado = Console.ReadLine();

            //switch (siglaEstado)
            //{
            //     case "SP":
            //        Console.WriteLine("São Paulo");
            //        break;
            //     case "RJ":
            //        Console.WriteLine("Rio de Janeiro");
            //        break;
            //     case "MG":
            //        Console.WriteLine("Rio de Janeiro");
            //        break;
            //     case "ES":
            //        Console.WriteLine("Rio de Janeiro");
            //        break;
            //        default:
            //        Console.WriteLine("Erro: Sigla inválida");
            //        break;
            //}
            //Console.ReadKey();

            //Exercício 5.

            //int mes, dia;

            //Console.WriteLine("Digite o número relacionado ao mês: ");
            //mes = int.Parse(Console.ReadLine());

            //switch (mes)
            //{
            //    case 1:
            //        Console.WriteLine("Verão");
            //        break;
            //    case 2:
            //        Console.WriteLine("Verão");
            //        break;
            //    case 3:
            //        Console.WriteLine("Digite o dia: ");
            //        dia = int.Parse(Console.ReadLine());
            //        if (dia < 20)
            //            Console.WriteLine("Verão");
            //        else
            //            Console.WriteLine("Outono");
            //        break;
            //    case 4:
            //        Console.WriteLine("Outono");
            //        break;
            //    case 5:
            //        Console.WriteLine("Outono");
            //        break;
            //    case 6:
            //        Console.WriteLine("Digite o dia: ");
            //        dia = int.Parse(Console.ReadLine());
            //        if(dia < 21)
            //            Console.WriteLine("Outono");
            //        else
            //            Console.WriteLine("Inverno");
            //        break;
            //    case 7:
            //        Console.WriteLine("Inverno");
            //        break;
            //    case 8:
            //        Console.WriteLine("Inverno");
            //        break;
            //    case 9:
            //        Console.WriteLine("Digite o dia: ");
            //        dia = int.Parse(Console.ReadLine());
            //        if(dia < 23)
            //            Console.WriteLine("Inverno");
            //        else
            //            Console.WriteLine("Primavera");
            //        break;
            //    case 10:
            //        Console.WriteLine("Primavera");
            //        break;
            //    case 11:
            //        Console.WriteLine("Primavera");
            //        break;
            //    case 12:
            //        Console.WriteLine("digite o dia: ");
            //        dia = int.Parse(Console.ReadLine());
            //        if(dia < 21)
            //            Console.WriteLine("Primavera");
            //        else
            //            Console.WriteLine("Verão");
            //        break;
            //}
            //Console.ReadKey();

            //Exercício 6.

            //float peso, altura, imc;

            //Console.WriteLine("Digite o seu peso: ");
            //peso = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o seu altura: ");
            //altura = float.Parse(Console.ReadLine());

            //imc = peso / (altura * altura);

            //if(imc < 18.5f)
            //    Console.WriteLine("Abaixo do peso");
            //else
            //    if(imc >= 18.5f && imc <= 24.9f)
            //    Console.WriteLine("Peso normal");
            //else
            //    if(imc >= 25.0f && imc <= 29.9f)
            //    Console.WriteLine("Sobrepeso");
            //else
            //    if(imc >= 30.0f && imc <= 34.9f)
            //    Console.WriteLine("Obesidade grau 1");
            //else
            //    if(imc >= 35.0f && imc <= 39.9f)
            //    Console.WriteLine("Obesidade grau 2");
            //else
            //    if(imc > 40)
            //    Console.WriteLine("Obesidade grau 3 (Mórbida)");

            //Console.ReadKey();

            //Exercício 7.

            //    int n, i = 0;

            //    Console.WriteLine("Digite um valor: ");
            //    n = int.Parse(Console.ReadLine());

            //    for (; n > 0;)
            //    {
            //        i++;
            //        if (n % i == 0)
            //            Console.WriteLine(i);
            //    }
            //    Console.WriteLine(i);
            //    Console.ReadKey();
            //}
        }
    }
}