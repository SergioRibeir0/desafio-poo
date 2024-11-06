using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades de acordo com o diagrama
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor com todos os parâmetros
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método para ligar o smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para instalar aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
