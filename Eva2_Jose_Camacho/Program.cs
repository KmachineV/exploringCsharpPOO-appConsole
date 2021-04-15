using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eva1_Jose_Camacho.Models;

namespace Eva1_Jose_Camacho.Models
{
    class Program
    {
        /* 
            
            Exploring C # applying POO (APP CONSOLE),
            through the use of Classes (Objects), Constructors, Instances, Encapsulation and Inheritance.  

        Requested:
        1. Classes that support the entry of securities according to the proposed scheme.
        2. Constructors that allow the creation of instances in the Main class (Program.cs)
        3. Attribute encapsulation through GET and SET methods.
        4. Inheritance of Classes as appropriate.
        5. Override string method, for displaying the data of the proposed classes.
        6. Create at least 3 instances of each class with their respective information.
        7. Display all the data in an orderly manner, using line breaks and titles.
        8. Show the data of the Smartphone with the best front camera.
        9. Show the number of notebooks with a LAN card (network cable).
        10. Show the data of the printer with the smallest capacity in number of impressions. 

         */
        static void Main(string[] args)
        {
            int i = 0;
            //Variables for SmartPhone data 
            double bestCamare = 0;
            string codig = "";
            string model = "";
            string marc = "";
            long val = 0 ;

            //Variables for Notebook data 
            int lan = 0;
            //Variables for Printer data 
            float cantidadMenor =1000000000;
            string cod = "";
            string mod = "";
            string mar = "";
            long value = 0;

            //Instances 
            Smartphones samsung = new Smartphones();
            Smartphones apple = new Smartphones();
            Smartphones huawei = new Smartphones();



            //Smartphones Samsung

            //Inheritance from the Father 
            samsung.Codigo = "CL 698574";
            samsung.Modelo = "A50";
            samsung.Marca = "Samsung";
            samsung.Valor = 350000;
            // 
            samsung.Sistema = "Android V10";
            samsung.Procesador = "Exynos 9610";
            samsung.MpxCamaraFrontal = 45.8;
            samsung.MpxCamaraTrasera = 54.2;
            samsung.Ram = 8;
            samsung.Almacenamiento = 64;
            samsung.DualSIM = true;

            //Smartphones Apple

            //Inheritance from the Father 
            apple.Codigo = "CL 45487";
            apple.Modelo = "11";
            apple.Marca = "Apple";
            apple.Valor = 850000;
            //Unique data
            apple.Sistema = "IOS 13";
            apple.Procesador = "A13 Bionic Chip";
            apple.MpxCamaraFrontal = 24;
            apple.MpxCamaraTrasera = 18.5;
            apple.Ram = 4;
            apple.Almacenamiento = 64;
            apple.DualSIM = false;

            //Smartphones Huawei

            //Inheritance from the Father 
            huawei.Codigo = "CL 458474";
            huawei.Modelo = "P30";
            huawei.Marca = "Huawei";
            huawei.Valor = 500000;

            //Unique data
            huawei.Sistema = "Android V10";
            huawei.Procesador = "Kirin 980";
            huawei.MpxCamaraFrontal = 69.5;
            huawei.MpxCamaraTrasera = 18.5;
            huawei.Ram = 2;
            huawei.Almacenamiento = 32;
            huawei.DualSIM = true;

            List<Smartphones> mejorCamara = new List<Smartphones>()
            {
                samsung, apple, huawei
            };

            for(i = 0; i<mejorCamara.Count; i++)
            {
                if(mejorCamara[i].MpxCamaraFrontal > bestCamare)
                {
                    bestCamare = mejorCamara[i].MpxCamaraFrontal;
                    codig = mejorCamara[i].Codigo;
                    model = mejorCamara[i].Modelo;
                    marc = mejorCamara[i].Marca;
                    val = mejorCamara[i].Valor;
                    
                }
                   


            }
          
            // ****NOTEBOOKS****
            Notebooks dell = new Notebooks();
            Notebooks hp = new Notebooks();
            Notebooks mac = new Notebooks();


            //Notebook Dell

            //Inheritance from the Father 
            dell.Codigo = "Cl484548";
            dell.Modelo = "Inspiron 5000";
            dell.Marca = "Dell";
            dell.Valor = 500000;

            //Unique data 
            dell.Procesador = "Intel i7-1065G7";
            dell.MemoriaGPU = 4;
            dell.Ram = 8;
            dell.Almacenamiento = 512;
            dell.TamanoPantalla = 15.6;
            dell.SistemaOperativo = "Windows 10";
            dell.TarjetaLAN = true;

            //Notebook HP

            //Inheritance from the Father 
            hp.Codigo = "CL548945";
            hp.Modelo = " Elite Dragonfly";
            hp.Marca = "HP";
            hp.Valor = 510000;
            //Unique data  
            hp.Procesador = "i5-8365U ";
            hp.MemoriaGPU = 2;
            hp.Ram = 16;
            hp.Almacenamiento = 512;
            hp.TamanoPantalla = 13.3;
            hp.SistemaOperativo = "Linux";
            hp.TarjetaLAN = false;

            //Notebook Mac

            //Inheritance from the Father 
            mac.Codigo = "CL78784548";
            mac.Modelo = "MacBook Pro 2020";
            mac.Marca = "Apple";
            mac.Valor = 1256985;

            //Unique data 
            mac.Procesador = "Intel Core i5 de 4 núcleos ";
            mac.MemoriaGPU = 2;
            mac.Ram = 16;
            mac.Almacenamiento = 1000;
            mac.TamanoPantalla = 13.3;
            mac.SistemaOperativo = "MacOs Catalina";
            mac.TarjetaLAN = true;

            List<Notebooks> cantidadLan = new List<Notebooks>
            {
                dell, hp , mac
            };

            for (i = 0; i < cantidadLan.Count; i++)
            {
                if(cantidadLan[i].TarjetaLAN == true)
                {
                    lan++;
                }
            }          

            //****IMPRESORAS****
            Impresoras epson = new Impresoras();
            Impresoras canon = new Impresoras();
            Impresoras brother = new Impresoras();
            //Impresora Epson
            epson.Codigo = "CL125774";
            epson.Modelo = "Workforce WF-2630WF";
            epson.Marca = "EPSON";
            epson.Valor = 587453;

            epson.Tipo = "Laser";
            epson.CantImpresiones = 200000;
            epson.ModeloTinta = "LaserJet";
            epson.TintaContinua = false;

            //Impresora Canon
            canon.Codigo = "CL659956";
            canon.Modelo = "Pixma pro-100";
            canon.Marca = "CANON";
            canon.Valor = 258741;

            canon.Tipo = "Solida";
            canon.CantImpresiones = 2500000;
            canon.ModeloTinta = "Tanque de Tinta";
            canon.TintaContinua = true;

            // Impresora Brother

            brother.Codigo = "CL785484S";
            brother.Modelo = "MFCJ5330DW";
            brother.Marca = "Brother";
            brother.Valor = 169852;

            brother.Tipo = "Latex";
            brother.CantImpresiones = 659632;
            brother.ModeloTinta = "DeskJet";
            brother.TintaContinua = false;

            List<Impresoras> menorCant = new List<Impresoras>
            {
                epson , canon, brother 
                
            };


            for (i = 0; i < menorCant.Count; i++)
            {
                if (menorCant[i].CantImpresiones < cantidadMenor)
                {
                    cantidadMenor = menorCant[i].CantImpresiones;
                     cod = menorCant[i].Codigo;
                     mod = menorCant[i].Modelo;
                     mar = menorCant[i].Marca;
                     value = menorCant[i].Valor;
                }
            }

           


            Console.WriteLine("..::SMARTPHONES::..");

            Console.WriteLine(samsung + "\n" + huawei + "\n" + apple + "\n");

            Console.WriteLine("..::NOTEBOOKS::..");

            Console.WriteLine( dell + "\n" + hp + "\n" + mac + "\n");

            Console.WriteLine("..::IMPRESORAS::..");

            Console.WriteLine(epson + "\n" + canon + "\n" + brother + "\n");

            

            Console.WriteLine("..:::Datos del Telefono con mejor Camara:::..");
            Console.WriteLine("Camara :" + bestCamare + "MPX");
            Console.WriteLine("Codigo del Producto: "+ codig);
            Console.WriteLine("Modelo: " + model);
            Console.WriteLine("Marca: " + marc);
            Console.WriteLine("Valor: " + val+ "$");

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("...::Cantidad de notebooks con tarjetas LAN::... ");
            Console.WriteLine("La cantidad de Notebook con tarjeta LAN: "+ lan);
            Console.WriteLine("__________________________________________________");



            Console.WriteLine("...::Datos de la impresora con menor cantidad de Impresiones: ");
            Console.WriteLine("Cantidad de Impresiones:" + cantidadMenor);
            Console.WriteLine("Codigo del Producto: " + cod);
            Console.WriteLine("Modelo: " + mod);
            Console.WriteLine("Marca: " + mar);
            Console.WriteLine("Valor: " + value + "$");
            


            Console.ReadKey();



        }
    }
}
