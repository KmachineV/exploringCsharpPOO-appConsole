using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1_Jose_Camacho.Models
{
    class TecnoProductos
    {
        private string codigo;
        private string modelo;
        private string marca;
        private long valor;

        public TecnoProductos()
        {

        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public long Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
      

       
    }
}
