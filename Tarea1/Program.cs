using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{ }

    class Program
    {
        static void Main(string[] args)
        {
            int tipoempleado;
            double salxhr;
            double hrslab;
            double aumento = 0.0;
            string nombre;
            int numced;

            while (true)
            {    
            Console.WriteLine("Numero de cedula del empleado");
            numced = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Tipo de empleado 1-Operario 2-Técnico 3-Profesional");
            tipoempleado = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario por hora");
            salxhr = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de horas laboradas");
            hrslab = int.Parse(Console.ReadLine());
            double ordinario = hrslab * salxhr;

            switch (tipoempleado)
            {
                case 1:
                    aumento = ordinario * 0.15;
                    break;

                case 2:
                    aumento = ordinario * 0.10;
                    break;

                case 3:
                    aumento = ordinario * 0.05;
                    break;   

            }

            double salbruto = ordinario + aumento;
            double seguro = salbruto * 0.0917;
            double salneto = salbruto - seguro;
            Console.WriteLine($"Número de cédula: {numced}");
            Console.WriteLine($"Nombre del empleado: {nombre}");
            Console.WriteLine($"Tipo de empleado: {tipoempleado}");
            Console.WriteLine($"Salario por hora: {salxhr}");
            Console.WriteLine($"Cantidad de horas laboradas: {hrslab}");
            Console.WriteLine($"Salario Ordinario: {ordinario}");
            Console.WriteLine($"Cantidad total del aumento: {aumento}");
            Console.WriteLine($"Salario Bruto: {salbruto}");    
            Console.WriteLine($"Deducción de CCSS 9.17%: {seguro}");
            Console.WriteLine($"Salario neto: {salneto}");


            Console.Read();


        }
    } 
}
