using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores validos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,30);

            System.Console.WriteLine($"Área: {r.ObterArea()}");




            // Pessoa P1 = new Pessoa();

            // P1.Nome = "Bob";
            // P1.Idade = 20;

            // P1.Apresentar();
            
        }

    }
}
