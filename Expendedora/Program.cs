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
            /*
             * (OBS00): solo se puede hacer una accion, ejemplo no puedo ver las latas disponibles y luego insertar lata.
             * Hay que contemplar que el usuario pueda volver a ingrear una opcion.
             * 
             * (OBS01): estas pasando 2 parametros al constructor de Maquina pero no impactan en la instancia de Maquina. Ver comentarios
             */
            Maquina expendedora = new Maquina(10, "PEPSICO");
            Console.Write("0) Encender maquina" + "\n" + "1) Ver latas disponibles" + "\n" + "2) Insertar lata" + "\n" + "3) Comprar lata" + "\n" + "4) balance de maquina" + "\n" + "5) ver info de latas" + "\n");
            Console.Write("Seleccione una opción: ");
            switch (Console.Read())
            {
                case '0':
                    expendedora.encenderMaquina();
                    break;
                case '1'                    /*
                     * (OBA02): el metodo armarInformacionLatas devuelve un String con el detalle de la expendedero
                     * pero nunca se utilza ese string para mostrar la informacion al usuario. Deberías de escribir 
                     * en consola la resputa del metodo armarInformacionLatas
                     * 
                     * (OBA03): no se contempla el escenario donde la maquina no tenga ninguna lata. Debería de 
                     * mostrar una leyenda que diga "No hay latas". Ver comentarios en el metodo armarInformacionLatas
                     */
                    armarInformacionLatas(expendedora);
                    break;
                case '2':
                    ;
                    break;

                    /*
                     * (OBA04): agregar el case para las demas opciones
                     */

            }
            Console.ReadKey();
        }


        static String armarInformacionLatas(Maquina maq)
        {
            String infoLatas = "";
            List<Lata> latas = new List<Lata>();
            latas = maq.getLatas();

            /*
             * (OBS03): validacion de que haya latas en la expendedora
             */
            if (latas.Count == 0)
            {
                return infoLatas = "No hay latas";
            }

            foreach (Lata lata in latas)
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

