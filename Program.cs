using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto do tipo Nokia
            Smartphone nokia = new Nokia("987654321", "Nokia 1100", "123456789012345", 32);
            // Chamando métodos da classe Nokia
            Console.WriteLine("Teste com o Nokia:");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n---------------------------------\n");

            // Criando um objeto do tipo Iphone
            Smartphone iphone = new Iphone("123456789", "iPhone 13", "987654321098765", 128);
            // Chamando métodos da classe Iphone
            Console.WriteLine("Teste com o Iphone:");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            // Para garantir que a execução terminou corretamente
            Console.ReadLine();
        }
    }
}
