using System;

namespace ProyectoApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulo
            Console.WriteLine("Contaminacion ambiental y el Ser humano");
            Console.WriteLine("En esta consola vamos a demostrar las diferentes formas de contaminacion ambiental en la que realizamos en nuestra vida cotidiana");
            //persona
            var persona1 = new Persona();

            var impresora1 = new Impresora();

            var laptop1 = new Laptop();

            var coche1 = new Coche();

            coche1.id = new Random().Next();
            coche1.Compañia = "Seat";
            coche1.Tipo = "buceta";
            coche1.Color = "amarillo";
            coche1.TipoCombustible = "diesel";
            coche1.ConsumoCombustible = 5;
            coche1.ConsumoRepuestos = 8;



            laptop1.Id = new Random().Next();
            laptop1.Modelo = "HP All-in-one";
            laptop1.Color = "blanco";
            laptop1.Procesador = "intel";
            laptop1.ConsumoInternet = 20 ;

            impresora1.Id = new Random().Next();
            impresora1.Marca = "Epson";
            impresora1.Color = "negro";
            impresora1.ConsumoMaterial = 5;
            impresora1.ConsumoEnergia = 2;
            impresora1.Tamaño = "grande";



            string nombre = "Jonathan";
            string apellido = "Alvear";
            int edad = 21;

            persona1.Id = new Random().Next();
            persona1.Nombre = nombre;
            persona1.Apellido = apellido;
            persona1.Edad = edad;
            persona1.Impresora = impresora1;
            persona1.Laptop = laptop1;
            persona1.Coche = coche1;

            string presentacion = persona1.Presentar();
            string presentacionImpresora = persona1.PresentarImpresora();
            string presentacionLaptop = persona1.PresentarLaptop();
            string presentacionCoche = persona1.PresentarCoche();

            //impresora
            Console.WriteLine(presentacion);
            Console.WriteLine(presentacionImpresora);
            Console.WriteLine(presentacionLaptop);
            Console.WriteLine(presentacionCoche);
            Console.WriteLine("En conclusion podemos definir que una persona es de la vida cotidiana es responsable de la contaminacion ambientala asi que son muy necessarias medidas preventivas para la contaminacion ambiental");

            Console.ReadKey();
        }
    }
}
