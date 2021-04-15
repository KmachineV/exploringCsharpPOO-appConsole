using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1_Jose_Camacho.Models
{
    class Impresoras : TecnoProductos
    {
        private string tipo;
        private int cantImpresiones;
        private string modeloTinta;
        private bool tintaContinua;
        

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int CantImpresiones
        {
            get
            {
                return cantImpresiones;
            }

            set
            {
                cantImpresiones = value;
            }
        }

        public string ModeloTinta
        {
            get
            {
                return modeloTinta;
            }

            set
            {
                modeloTinta = value;
            }
        }

        public bool TintaContinua
        {
            get
            {
                return tintaContinua;
            }

            set
            {
                tintaContinua = value;
            }
        }

        public Impresoras()
        {

        }

        public override string ToString()
        {
            return "Codigo del Producto: " + Codigo + "\n" + "Modelo: " + Modelo + "\n" + "Marca: " + Marca + "\n" + "Precio: " + Valor + "\n"+ "Tipo de Impresora: " + Tipo + "\n" + "Cantidad de Impresiones: " + CantImpresiones + "\n" +
                "Tipo de Tinta: " + ModeloTinta + "\n" + "Tinta Continua: " + TintaContinua + "\n";
        }

    }
}
