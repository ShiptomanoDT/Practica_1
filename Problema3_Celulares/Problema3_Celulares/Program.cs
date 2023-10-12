namespace Problema3_Celulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Celular_Nuevo> celulares = new List<Celular_Nuevo>();
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxy S10",
                SO = "Android",
                RAM = "8GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("10/10/2019"),
                Precio = 1000
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 15",
                SO = "iOS",
                RAM = "6GB",
                Almacenamiento = "256GB",
                Fecha_Ingreso = DateTime.Parse("07/02/2005"),
                Precio = 1489
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Huawei",
                Modelo = "P30",
                SO = "Android",
                RAM = "6GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("05/10/2019"),
                Precio = 800
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Motorola",
                Modelo = "Moto G7",
                SO = "Android",
                RAM = "4GB",
                Almacenamiento = "64GB",
                Fecha_Ingreso = DateTime.Parse("12/10/2019"),
                Precio = 500
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Xiaomi",
                Modelo = "Mi 9",
                SO = "Android",
                RAM = "6GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("07/02/2005"),
                Precio = 600
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxy S10",
                SO = "Android",
                RAM = "8GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("11/10/2019"),
                Precio = 1000
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 11",
                SO = "iOS",
                RAM = "4GB",
                Almacenamiento = "64GB",
                Fecha_Ingreso = DateTime.Parse("07/02/2005"),
                Precio = 1200
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Huawei",
                Modelo = "P30",
                SO = "Android",
                RAM = "8GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("10/10/2019"),
                Precio = 800
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Motorola",
                Modelo = "Moto G7",
                SO = "Android",
                RAM = "4GB",
                Almacenamiento = "64GB",
                Fecha_Ingreso = DateTime.Parse("08/10/2019"),
                Precio = 500
            });
            celulares.Add(new Celular_Nuevo()
            {
                Marca = "Xiaomi",
                Modelo = "Mi 9",
                SO = "Android",
                RAM = "6GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("08/10/2019"),
                Precio = 600
            });
            Prom_Celular();
            Cel_MarcaSO();
            Celular_RSA();
            Celular_Ingreso();
            Celulares_Apple_Lambda();
            Celulares_Apple_LINQ();

            void Prom_Celular()
            {
                Console.WriteLine("Promedio de precio de los celulares");
                var promedio = celulares.Average(c => c.Precio);
                Console.WriteLine("El promedio de precio de los celulares es: " + promedio);
            }
            void Cel_MarcaSO()
            {
                Console.WriteLine("\nCelulares de la marca Samsung");
                var celularesMarcaSO = celulares.Where(c => c.Marca == "Samsung");
                foreach (var celular in celularesMarcaSO)
                {
                    celular.mostrarCelular();
                }
            }
            void Celular_RSA() {
                Console.WriteLine("\nCelulares con 8GB de RAM, Android y 128GB de almacenamiento");
                var celularesRSA = from celularNuevo in celulares
                                   where celularNuevo.RAM == "8GB" && celularNuevo.SO == "Android" && celularNuevo.Almacenamiento == "128GB"
                                   select celularNuevo;
                foreach (var celular in celularesRSA)
                {
                    celular.mostrarCelular();
                }
            }
            void Celular_Ingreso()
            {
                Console.WriteLine("\nCelulares ingresados en el año 2005");
                var celularesIngreso = from celularNuevo in celulares
                                       where celularNuevo.Fecha_Ingreso.Year == 2005
                                       select celularNuevo;
                foreach (var celular in celularesIngreso)
                {
                    celular.mostrarCelular();
                }
            }
            void Celulares_Apple_Lambda()
            {
                Console.WriteLine("\nCelulares Apple | Lambda");
                var celularesApple = celulares.Where(c => c.Marca == "Apple");
                foreach (var celular in celularesApple)
                {
                    Console.WriteLine("\nModelo: " + celular.Modelo);
                    Console.WriteLine("Precio: " + celular.Precio);
                }
            }
            void Celulares_Apple_LINQ()
            {
                Console.WriteLine("\nCelulares Apple | LINQ");
                var celularesApple = from celularNuevo in celulares
                                     where celularNuevo.Marca == "Apple"
                                     select celularNuevo;
                foreach (var celular in celularesApple)
                {
                    Console.WriteLine("\nModelo: " + celular.Modelo);
                    Console.WriteLine("Precio: " + celular.Precio);
                }
            }
        }
    }
}