using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Entities
{
    class Lata
    {
        private String codigo;
        private String nombre;
        private String sabor;
        private Double precio;
        private Double volumen;
        private int cantidad;

        public Lata(String codigo, String nombre, String sabor, Double precio, Double volumen, int cantidad)
        {
            if(codigo == null || nombre == null || sabor == null || precio == null || volumen == null || cantidad == null)
            {
                throw new ArgumentException("Ingrese todos los atributos necesarios");
            }

            this.codigo = codigo;
            this.nombre = nombre;
            this.sabor = sabor;
            this.precio = precio;
            this.volumen = volumen;
            this.cantidad = cantidad;
        } 

        public String getNombre()
        {
            return this.nombre;
        }

        public String getCantidad()
        {   
            return this.cantidad.ToString();
        }
  


    }
}
