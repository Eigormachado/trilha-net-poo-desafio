using System;
using DesafioPOO.Models;
namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Teste com a classe Iphone
            Iphone iphone = new Iphone("123456789", "iPhone 12", "IMEI123", 128);
            RealizarTestes(iphone);

            Console.WriteLine();

            // Teste com a classe Nokia
            Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI456", 16);
            RealizarTestes(nokia);
        }

        // Método para realizar os testes com um smartphone genérico
        static void RealizarTestes(Smartphone smartphone)
        {
            Console.WriteLine($"Testes com {smartphone}:");
            
            smartphone.Ligar();
            smartphone.ReceberLigacao();
            smartphone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();
        }
    }
}
