using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1_Clase_Estatica
{
    internal static class NumeroLiteral
    {
        static double numero;
        static public void IngresarNumero()
        {
            bool entradaValida = false;

            do
            {
                Console.Write("Numero: ");
                if (double.TryParse(Console.ReadLine(), out numero) && numero >= 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número double positivo válido.");
                }
            } while (!entradaValida);
        }
        static public void MostrarNumeroLiteral()
        {
            Console.Write(dezglozarNumero());
        }
        static public string dezglozarNumero()
        {
            string numeroCadena = numero.ToString();
            string resultadoFinal, agregarDecimal = "";
            Int64 parteEntera;
            int parteDecimal;
            double nro;

            try
            {
                nro = Convert.ToDouble(numeroCadena);
            }
            catch
            {
                return "";
            }

            parteEntera = Convert.ToInt64(Math.Truncate(nro));
            parteDecimal = Convert.ToInt32(Math.Round((nro - parteEntera) * 100, 2));
            if (parteDecimal > 0)
            {
                agregarDecimal = " con " + parteDecimal.ToString() + "/100";
            }

            resultadoFinal = conversion_a_Literal(Convert.ToDouble(parteEntera)) + agregarDecimal;
            return resultadoFinal;
        }
        static private string conversion_a_Literal(double parteEntera2)
        {
            string aLiteral = "";
            parteEntera2 = Math.Truncate(parteEntera2);
            if (parteEntera2 == 0) aLiteral = "Cero";
            else if (parteEntera2 == 1) aLiteral = "Uno";
            else if (parteEntera2 == 2) aLiteral = "Dos";
            else if (parteEntera2 == 3) aLiteral = "Tres";
            else if (parteEntera2 == 4) aLiteral = "Cuatro";
            else if (parteEntera2 == 5) aLiteral = "Cinco";
            else if (parteEntera2 == 6) aLiteral = "Seis";
            else if (parteEntera2 == 7) aLiteral = "Siete";
            else if (parteEntera2 == 8) aLiteral = "Ocho";
            else if (parteEntera2 == 9) aLiteral = "Nueve";
            else if (parteEntera2 == 10) aLiteral = "Diez";
            else if (parteEntera2 == 11) aLiteral = "Once";
            else if (parteEntera2 == 12) aLiteral = "Doce";
            else if (parteEntera2 == 13) aLiteral = "Trece";
            else if (parteEntera2 == 14) aLiteral = "Catorce";
            else if (parteEntera2 == 15) aLiteral = "Quince";
            else if (parteEntera2 < 20) aLiteral = "Dieci" + conversion_a_Literal(parteEntera2 - 10).ToLower();
            else if (parteEntera2 == 20) aLiteral = "Veinte";
            else if (parteEntera2 < 30) aLiteral = "Veinti" + conversion_a_Literal(parteEntera2 - 20).ToLower();
            else if (parteEntera2 == 30) aLiteral = "Treinta";
            else if (parteEntera2 == 40) aLiteral = "Cuarenta";
            else if (parteEntera2 == 50) aLiteral = "Cincuenta";
            else if (parteEntera2 == 60) aLiteral = "Sesenta";
            else if (parteEntera2 == 70) aLiteral = "Setenta";
            else if (parteEntera2 == 80) aLiteral = "Ochenta";
            else if (parteEntera2 == 90) aLiteral = "Noventa";
            else if (parteEntera2 < 100) aLiteral = conversion_a_Literal(Math.Truncate(parteEntera2 / 10) * 10) + " y " + conversion_a_Literal(parteEntera2 % 10).ToLower();
            else if (parteEntera2 == 100) aLiteral = "Cien";
            else if (parteEntera2 < 200) aLiteral = "Ciento " + conversion_a_Literal(parteEntera2 - 100).ToLower();
            else if ((parteEntera2 == 200) || (parteEntera2 == 300) || (parteEntera2 == 400) || (parteEntera2 == 600) || (parteEntera2 == 800)) aLiteral = conversion_a_Literal(Math.Truncate(parteEntera2 / 100)) + "cientos";
            else if (parteEntera2 == 500) aLiteral = "Quinientos";
            else if (parteEntera2 == 700) aLiteral = "Setecientos";
            else if (parteEntera2 == 900) aLiteral = "Novecientos";
            else if (parteEntera2 < 1000) aLiteral = conversion_a_Literal(Math.Truncate(parteEntera2 / 100) * 100) + " " + conversion_a_Literal(parteEntera2 % 100).ToLower();
            else if (parteEntera2 == 1000) aLiteral = "Mil";
            else if (parteEntera2 < 2000) aLiteral = "Mil " + conversion_a_Literal(parteEntera2 % 1000).ToLower();
            else if (parteEntera2 < 1000000)
            {
                aLiteral = conversion_a_Literal(Math.Truncate(parteEntera2 / 1000)) + " mil";
                if ((parteEntera2 % 1000) > 0) aLiteral = aLiteral + " " + conversion_a_Literal(parteEntera2 % 1000).ToLower();
            }

            else if (parteEntera2 == 1000000) aLiteral = "Un millon";
            else if (parteEntera2 < 2000000) aLiteral = "Un millon " + conversion_a_Literal(parteEntera2 % 1000000).ToLower();
            else if (parteEntera2 < 1000000000000)
            {
                aLiteral = conversion_a_Literal(Math.Truncate(parteEntera2 / 1000000)) + " millones ";
                if ((parteEntera2 - Math.Truncate(parteEntera2 / 1000000) * 1000000) > 0) aLiteral = aLiteral + " " + conversion_a_Literal(parteEntera2 - Math.Truncate(parteEntera2 / 1000000) * 1000000).ToLower();
            }

            else if (parteEntera2 == 1000000000000) aLiteral = "Un billon ";
            else if (parteEntera2 < 2000000000000) aLiteral = "Un billon " + conversion_a_Literal(parteEntera2 - Math.Truncate(parteEntera2 / 1000000000000) * 1000000000000).ToLower();

            else
            {
                aLiteral = conversion_a_Literal(Math.Truncate(parteEntera2 / 1000000000000)) + " billones";
                if ((parteEntera2 - Math.Truncate(parteEntera2 / 1000000000000) * 1000000000000) > 0) aLiteral = aLiteral + " " + conversion_a_Literal(parteEntera2 - Math.Truncate(parteEntera2 / 1000000000000) * 1000000000000).ToLower();
            }
            return aLiteral;

        }

    }
}
