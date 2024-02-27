using System;

namespace OOP
{
    public class Furniture
    {
        private const string DEF_NAME = "Default furniture", DEF_MATERIAL = "Default material", DEF_COLOUR = "Default colour";
        public float Weight { get; set; }
        public double Price { get; set; }
        public bool Set { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Colour { get; set; }

        public Furniture(float weight, double price, bool set, string name, string material, string colour)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Colour = colour;
        }

        public Furniture(float weight) : this(weight,0.0, false, DEF_NAME, DEF_MATERIAL, DEF_COLOUR)
        {
            Weight = weight;
        }

        public Furniture() : this(0.0f, 0.0, false, DEF_NAME, DEF_MATERIAL, DEF_COLOUR)
        {

        }



        // ******************* Ejecucion *******************

        public virtual string DisplayInfoCompilation()
        {
            return $"Nombre: {Name} | Peso: {Weight}";
        }

        // Clase Silla derivada de Furniture que contiene:
        //public override string DisplayInfoCompilation()
        //{
        //    return "Abada kedavra";
        //}



        // ******************* Compilacion *******************

        public string DisplayInfoExecution()
        {
            return $"Nombre: {Name} | Peso: {Weight}";
        }

        public string DisplayInfoExecution(string info)
        {
            return $"Nombre: {Name} | Peso: {Weight} | Info: {info}";
        }
    }
}
