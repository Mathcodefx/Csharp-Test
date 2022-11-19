/*Testando stacks */

using System;
using System.Collections.Generic;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Stack<int> pilha = new Stack<int>(); //criando a stack


        pilha.Push(1);  //elementos da stack
        pilha.Push(2);
        pilha.Push(3);
        pilha.Push(4);
        pilha.Push(5);
        pilha.Push(6);

        Console.Write("Total de numeros na stack: ");
        Console.WriteLine(pilha.Count); //contagem dos elementos

        foreach (int str in pilha)  // exibir elementos da stack
        {
            Console.WriteLine(str);
        }


        Stack<int> pilha2 = new Stack<int>(pilha.ToArray()); // copiando a stack1 para uma nova pilha em uma array
        Console.Write("Total de numeros na stack2: ");
        Console.WriteLine(pilha2.Count);

        foreach (int str in pilha2)
        {
            Console.WriteLine(str);
        }

    }
}