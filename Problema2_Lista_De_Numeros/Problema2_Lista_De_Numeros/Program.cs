namespace Problema2_Lista_De_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////
            //Entrada de datos
            Console.WriteLine("¿Cuantos números desea añadir?");
            uint tamanho = UInt32.Parse(System.Console.ReadLine());
            Console.WriteLine("Añada " + tamanho + " números: ");
            List<int> numeros = new List<int>();
            for (int i = 0; i < tamanho; i++)
            {
                numeros.Add(Int32.Parse(System.Console.ReadLine()));
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////
            var multiplosDe2 = numeros.Where(x => x % 2 == 0).OrderBy(x=>x);
            var numerosPrimos = numeros.Where(x => verificarSiPrimo(x) == true).OrderBy(x => x);
            var multiplosDe5 = numeros.Where(x => x % 5 == 0).OrderBy(x => x);
            var numerosPerfectos = numeros.Where(x => verificarSiNumeroPerfecto(x) == true).OrderBy(x => x);
            Console.WriteLine("Lista 1: " + string.Join(", ", multiplosDe2.Distinct()) + " (Múltiplos de 2)"); 
            Console.WriteLine("Lista 2: " + string.Join(", ", numerosPrimos.Distinct()) + " (Primos)");
            Console.WriteLine("Lista 3: " + string.Join(", ", multiplosDe5.Distinct()) + " (Múltiplos de 5)");
            Console.WriteLine("Lista 4: " + string.Join(", ", numerosPerfectos.Distinct()) + " (Perfectos)");
        }
        static bool verificarSiPrimo(int numero)
        {
            int divisores = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores++;
                }
            }
            if (divisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool verificarSiNumeroPerfecto(int numero)
        {
            if (numero < 0)
                return false;
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                    suma += i;
            }
            if (suma == numero)
                return true;
            else
                return false;
        }
    }
}