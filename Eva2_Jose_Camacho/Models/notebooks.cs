using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1_Jose_Camacho.Models
{
    class Notebooks : TecnoProductos

    {
        private string procesador;
        private int memoriaGPU;
        private int ram;
        private int almacenamiento;
        private double tamanoPantalla;
        private string sistemaOperativo;
        private bool tarjetaLAN;


        public Notebooks()
        {

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

        public int MemoriaGPU
        {
            get
            {
                return memoriaGPU;
            }

            set
            {
                memoriaGPU = value;
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

        public double TamanoPantalla
        {
            get
            {
                return tamanoPantalla;
            }

            set
            {
                tamanoPantalla = value;
            }
        }

        public string SistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }

            set
            {
                sistemaOperativo = value;
            }
        }

        public bool TarjetaLAN
        {
            get
            {
                return tarjetaLAN;
            }

            set
            {
                tarjetaLAN = value;
            }
        }
        public override string ToString()
        {
            return "Codigo del Producto: " + Codigo + "\n" + "Modelo: " + Modelo + "\n" + "Marca: " + Marca + "\n" + "Precio: " + Valor + "\n"+ "Procesador: " + Procesador + "\n" + "Memoria Grafica: " + MemoriaGPU + "GB" + "\n" +
                "Memoria Ram: " + Ram + "GB"+ "\n" + "Memoria de Almacanmiento: " + Almacenamiento + "GB" + "\n" +
                "Tamaño de Pantalla: " + TamanoPantalla + "''"+ "\n" + "Sistema Operativo: " + SistemaOperativo +
                "\n" + "Tarjeta LAN: " + TarjetaLAN + "\n";
        }



    }
}
