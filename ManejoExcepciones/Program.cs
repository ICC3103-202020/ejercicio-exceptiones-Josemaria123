using System;
using System.Collections.Generic;
using ManejoExcepciones.Properties;

namespace ManejoExcepciones
{
    class MainClass
    {
        public static List<string> lista_consumibles = new List<string>() { "Fertilizante", "Herbicida", "Fungicida" };

        public static void Main(string[] args)
        {
            chequearLista();
        }

        public static void chequearLista()
        {
            Console.WriteLine("Ingrese un consumible para buscar");
            string choice = Console.ReadLine();

            if (lista_consumibles.Contains(choice))
            {
                Console.WriteLine("Si existe el consumible en la lista");
            }

            else
            {
                throw new ExcepcionPersonalizada("El consumible no existe");
            }
        }
    }
}
