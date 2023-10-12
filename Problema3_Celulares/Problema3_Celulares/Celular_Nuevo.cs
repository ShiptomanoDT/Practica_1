using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3_Celulares
{
    internal class Celular_Nuevo : Celular
    {
        public DateTime Fecha_Ingreso { get; set; }
        public decimal Precio { get; set; }
        public override void mostrarCelular()
        {
            Console.WriteLine("\nMarca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Sistema Operativo: " + SO);
            Console.WriteLine("RAM: " + RAM);
            Console.WriteLine("Almacenamiento: " + Almacenamiento);
            Console.WriteLine("Fecha de Ingreso: " + Fecha_Ingreso.ToString("d"));
            Console.WriteLine("Precio: " + Precio);
        }
    }
}
