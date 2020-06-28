using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoApp4
{
    class Persona
    {
        //Propiedades
        public int Id { set; get; }

        public string Nombre { set; get; }

        public string Apellido { set; get; }

        public int Edad { set; get; }

        public Impresora Impresora { get; set; }

        public Laptop Laptop { get; set; }

        public Coche Coche { get; set; }

        //Metodos
        public string Presentar()
        {
            return $"Hola me llamo {Nombre} {Apellido} y tengo {Edad} años.";
        }

        public string PresentarImpresora()
        {
            return $"Tengo una impresora {Impresora.Marca} de color {Impresora.Color} en la que consumo en materiales unos {Impresora.ConsumoMaterial}$ con un tamaño {Impresora.Tamaño} y de energia unos {Impresora.ConsumoEnergia}$ por dia.";
        }

        public string PresentarLaptop()
        {
            return $"Ademas tengo una laptop, su modelo es {Laptop.Modelo} de color {Laptop.Color} con un procesador {Laptop.Procesador} y gasto en internet unos {Laptop.ConsumoInternet}$ al mes.";
        }

        public string PresentarCoche()
        {
            return $"Por ultimo tengo un coche de la compañia {Coche.Compañia}, es una {Coche.Tipo} de color {Coche.Color} en le que solo usa {Coche.TipoCombustible} como combustible, en combustible gasto {Coche.ConsumoCombustible}$ y repuestos gasto {Coche.ConsumoRepuestos}$ al mes.";
        }


    }
}
