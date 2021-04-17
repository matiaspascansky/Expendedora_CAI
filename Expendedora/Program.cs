using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Entities;

namespace Expendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquina expendedora = new Maquina(10, "PEPSICO");
            Console.Write("0) Encender maquina" + "\n" + "1) Ver latas disponibles" + "\n" + "2) Insertar lata" + "\n" + "3) Comprar lata" + "\n" + "4) balance de maquina" + "\n" + "5) ver info de latas" + "\n");
            Console.Write("Seleccione una opción: ");
            switch (Console.Read())
            {
                case '0':
                    expendedora.encenderMaquina();
                    break;
                case '1':
                    armarInformacionLatas(expendedora);
                    break;
                case '2':
                    ;
                    break;

            }
            Console.ReadKey();
        }


        static String armarInformacionLatas(Maquina maq)
        {
            String infoLatas = "";
            List<Lata> latas = new List<Lata>();
            latas = maq.getLatas();
            
            foreach(Lata lata in latas)
            {
                infoLatas += lata.getNombre() + "[]" + lata.getCantidad() + " /n";
            }
            return infoLatas;
        }

        static void ingresarLata(Maquina maq)
        {
            Console.WriteLine("ingrese codigo");
            String codigo = Console.ReadLine();
            Console.WriteLine("ingrese nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("ingrese sabor");
            String sabor = Console.ReadLine();
            Console.WriteLine("ingrese precio");
            Double precio;
            if (!double.TryParse(Console.ReadLine(), out precio))
            {
                throw new ArgumentException("no es un double");
            }
            Double volumen;
            if (!double.TryParse(Console.ReadLine(), out volumen))
            {
                throw new ArgumentException("no es un double");
            }
            int cantidad;
            if (!int.TryParse(Console.ReadLine(), out cantidad))
            {
                throw new ArgumentException("no es un double");
            }
            Lata lata = new Lata(codigo, nombre, sabor, precio, volumen, cantidad);
            maq.agregarLata(lata);

        }
    }
}

