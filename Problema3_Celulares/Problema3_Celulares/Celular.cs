using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3_Celulares
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SO { get; set; }
        public string RAM { get; set; }
        public string Almacenamiento { get; set; }

        public virtual void mostrarCelular() { 
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Sistema Operativo: " + SO);
            Console.WriteLine("RAM: " + RAM);
            Console.WriteLine("Almacenamiento: " + Almacenamiento);
        }
    }
}
