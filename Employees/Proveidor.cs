using System;

namespace Employees
{
    public class Proveidor : Persona, IInteraccio
    {
        private int CodiProveidor { get; set; }
        private int TerminiPagament { get; set; }

        public Proveidor(string cognom, string nom, int codi, int codiProveidor, int terminiPagament) : base(cognom, nom, codi)
        {
            this.CodiProveidor = codiProveidor;
            this.TerminiPagament = terminiPagament;
        }

        public override string Saludar(string cognom, string nom)
        {
            return $"Hola {cognom}, {nom}";
        }

        public string Notificar()
        {
            return "Hey Proveïdor";
        }

        public int GenerarCodi()
        {
            return Codi + 1;
        }

        public string RetornarMarge()
        {
            return $"El termini del pago es: {TerminiPagament}";
        }
    }
}