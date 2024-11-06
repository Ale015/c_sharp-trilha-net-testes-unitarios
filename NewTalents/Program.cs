using System;
using System.Collections.Generic;
using NewTalents;

Calculadora calc1 = new Calculadora();

int num1 = 0;
int num2 = 0;

while (true)
{
    System.Console.WriteLine("Calculadora Simples para TDD");
    System.Console.WriteLine("Informe o primeiro valor:");
    string strNum1 = Console.ReadLine();
    try
    {
        num1 = int.Parse(strNum1);
    }
    catch
    {
        System.Console.WriteLine("Impossibilitado de armazenar o número fornecido, tente novamente.");
        continue;
    }

    System.Console.WriteLine("Informe o segundo valor:");
    string strNum2 = Console.ReadLine();
    try
    {
        num2 = int.Parse(strNum2);
    }
    catch
    {
        System.Console.WriteLine("Impossibilitado de armazenar o número fornecido, tente novamente.");
        continue;
    }

    while (true)
    {
        System.Console.WriteLine("(Para sair digite 'exit')");
        System.Console.WriteLine("Escolha uma das operações abaixo:");
        System.Console.WriteLine("1 - Soma");
        System.Console.WriteLine("2 - Subtrair");
        System.Console.WriteLine("3 - Multiplicar");
        System.Console.WriteLine("4 - Dividir");
        System.Console.WriteLine("5 - Histórico");

        string inputEscolha = Console.ReadLine();

        if (inputEscolha.Trim().ToUpper() == "EXIT")
        {
            break;
        }

        if (inputEscolha == "1" || inputEscolha.Trim().ToUpper() == "SOMA")
        {
            int resultadoSoma = calc1.Somar(num1, num2);
            System.Console.WriteLine($"O resultado da Soma foi: {resultadoSoma}");
        }
        else if (inputEscolha == "2" || inputEscolha.Trim().ToUpper() == "SUBTRAIR")
        {
            int resultadoSub = calc1.Subtrair(num1, num2);
            System.Console.WriteLine($"O resultado da Subtração foi: {resultadoSub}");
        }
        else if (inputEscolha == "3" || inputEscolha.Trim().ToUpper() == "MULTIPLICAR")
        {
            int resultadoMulti = calc1.Multiplicar(num1, num2);
            System.Console.WriteLine($"O resultado da Multiplicação foi: {resultadoMulti}");
        }
        else if (inputEscolha == "4" || inputEscolha.Trim().ToUpper() == "DIVIDIR")
        {
            if (num2 == 0)
            {
                System.Console.WriteLine("Divisão por zero não é permitida.");
            }
            else
            {
                int resultadoDiv = calc1.Dividir(num1, num2);
                System.Console.WriteLine($"O resultado da Divisão foi: {resultadoDiv}");
            }
        }
        else if (inputEscolha == "5" || inputEscolha.Trim().ToUpper() == "HISTORICO")
        {
            System.Console.WriteLine("Histórico de Operações:");
            List<string> historicoCalcs = calc1.Historico();

            for (int i = 0; i < historicoCalcs.Count; i++)
            {
                System.Console.WriteLine($"Operação n°{i + 1}: {historicoCalcs[i]}");
            }
        }
        else
        {
            System.Console.WriteLine("Escolha uma opção válida.");
            continue;
        }

        System.Console.WriteLine("\nGostaria de calcular novamente?");
        System.Console.WriteLine("S - Sim ou N - Não");

        string strDecisao = Console.ReadLine();
        if (strDecisao.Trim().ToUpper() == "S" || strDecisao.Trim().ToUpper() == "SIM")
        {
            break;
        }
        else if (strDecisao.Trim().ToUpper() == "N" || strDecisao.Trim().ToUpper() == "NAO")
        {
            System.Console.WriteLine("Programa Finalizado!");
            return;
        }
        else
        {
            System.Console.WriteLine("Por favor, selecione uma opção válida.");
        }
    }
}
