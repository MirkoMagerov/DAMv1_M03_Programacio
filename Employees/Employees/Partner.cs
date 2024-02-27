using System;

namespace Employees
{
    public class Partner : Persona, IInteraccio
    {
        private int CodiPartner { get; set; }
        private int IndexReliability { get; set; }

        public Partner (string cognom, string nom, int codi, int codiPartner, int indexReliability) : base(cognom, nom, codi)
        {
            this.CodiPartner = codiPartner;
            this.IndexReliability = indexReliability;
        }

        public override string Saludar(string cognom, string nom)
        {
            return $"Hola {cognom}, {nom}";
        }

        public string Notificar()
        {
            return "Hey Partner";
        }

        public int GenerarCodi()
        {
            return Codi + 1;
        }

        public string MostrarRisc()
        {
            return $"El índice de riesgo es: {IndexReliability}.";
        }
    }
}