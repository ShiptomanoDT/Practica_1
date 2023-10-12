using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3_Celulares
{
    internal class Celular_Defectuoso : Celular
    {
        public DateTime Fecha_Defecto { get; set; }
        public string Motivo { get; set; }
        public override void mostrarCelular()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo); 
            Console.WriteLine("Sistema Operativo: " + SO);
            Console.WriteLine("RAM: " + RAM);
            Console.WriteLine("Almacenamiento: " + Almacenamiento);
            Console.WriteLine("Fecha de Defecto: " + Fecha_Defecto);
            Console.WriteLine("Motivo: " + Motivo);
        }
    }
}
