using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Entities
{
    /*
    * (OBS01) El constructor que hiciste recibe dos parametros (capacidad y provedor)
    * pero ninguna afectar al estado de la instancia
    */
    class Maquina
    {
        private int capacidad;
        private String proveedor;
        private double dinero;
        private bool encendida;
        private List<Lata> latas;


        public Maquina(int capacidad, String proveedor)
        {
            this.latas = new List<Lata>();
            this.encendida = false;
        }

        public void encenderMaquina() {
            this.encendida = true;
        }

        public List<Lata> getLatas()
        {
            return latas;
        }

        public void agregarLata(Lata lata)
        {
            if(this.encendida == true && this.latas.Count < this.capacidad)
            {
                latas.Add(lata);
            } else
            {
                throw new Exception("Primero tenes que encender la maquina");
            }
        }

        public String getBalance()
        {
            if(this.encendida)
            {
                return "Dinero: " + this.dinero + " /n Cantidad de latas" + this.latas.Count;

            } else
            {
                throw new Exception("Maquina apagada");
            }
        }
    }
}
