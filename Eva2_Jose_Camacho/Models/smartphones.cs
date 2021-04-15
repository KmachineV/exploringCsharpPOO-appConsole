using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1_Jose_Camacho.Models
{
    class Smartphones : TecnoProductos
    {
        private string sistema;
        private string procesador;
        private double mpxCamaraFrontal;
        private  double mpxCamaraTrasera;
        private int ram;
        private int almacenamiento;
        private bool dualSIM;

        public Smartphones()
        {

        }
        public string Sistema
        {
            get
            {
                return sistema;
            }

            set
            {
                sistema = value;
            }
        }

        public string Procesador
        {
            get
            {
                return procesador;
            }

            set
            {
                procesador = value;
            }
        }

        public double MpxCamaraFrontal
        {
            get
            {
                return mpxCamaraFrontal;
            }

            set
            {
                mpxCamaraFrontal = value;
            }
        }

        public double MpxCamaraTrasera
        {
            get
            {
                return mpxCamaraTrasera;
            }

            set
            {
                mpxCamaraTrasera = value;
            }
        }

        public int Ram
        {
            get
            {
                return ram;
            }

            set
            {
                ram = value;
            }
        }

        public int Almacenamiento
        {
            get
            {
                return almacenamiento;
            }

            set
            {
                almacenamiento = value;
            }
        }

        public bool DualSIM
        {
            get
            {
                return dualSIM;
            }

            set
            {
                dualSIM = value;
            }
        }

        public override string ToString()
        {
            return "Codigo del Producto: " + Codigo + "\n" + "Modelo: " + Modelo + "\n" + "Marca: " + Marca + "\n" + "Precio: " + Valor + "\n" + "Sitema Operativo: " + Sistema + "\n" + "Procesador: " + Procesador +
                "\n" + "Camara Frontal: " + MpxCamaraFrontal + "MPX" + "\n" + "Camara Trasera: " + MpxCamaraTrasera + "MPX" + "\n" +
                "Memoria Ram: " + Ram + "GB" + "\n" + "Memoria de Almacenamiento: " + Almacenamiento + "GB" + "\n" + "Dual SIM: " + DualSIM + "\n";
        }

     
    }
}
