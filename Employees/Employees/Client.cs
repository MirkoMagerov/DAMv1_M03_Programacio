using System;

namespace Employees
{
    public class Client : Persona, IInteraccio
    {
        private int CodiClient { get; set; }
        private int TipusClient { get; set; }

        public Client(string cognom, string nom, int codi, int codiClient, int tipusClient) : base(cognom, nom, codi)
        {
            this.CodiClient = codiClient;
            this.TipusClient = tipusClient;
        }

        public override string Saludar(string cognom, string nom)
        {
            return $"Hola {cognom}, {nom}";
        }

        public string Notificar()
        {
            return "Hey Client";
        }

        public int GenerarCodi()
        {
            return Codi + 1;
        }

        public double CalcularDescompte()
        {
            return TipusClient switch
            {
                0 => 0,
                1 => 10,
                2 => 20,
                3 => 50,
                _ => 0
            };
        }
    }
}