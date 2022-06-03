using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos_Practica_MtzBlanca
{
    class Program
    {
        //CLASE DATOS ALUMNO
        class DatosAlumno
        {
            //CAMPOS DE LA CLASE
            public string name, Email;
            public int Edad;

            //CONSTRUCTOR DE LA CLASE
            public DatosAlumno(string name, string Email, int Edad)
            {
                this.name = name;
                this.Email = Email;
                this.Edad = Edad;
            }

            //METODO DE CLASE
            public void desplegarDatos()
            {
                Console.WriteLine("NOMBRE: " + this.name
                    + "\nEmail: " + this.Email +
                    "\nEdad: " + this.Edad);
            }

            //CONSTRUCTOR DE LA CLASE
            ~DatosAlumno()
            {
                Console.WriteLine("MEMORIA DE LA CLASE LIBERADA");
            }
        }
        

        static void Main(string[] args)
        {
            //GENERADOR DE ARCHIVO
            TextWriter sw = new StreamWriter("CAPTURA.txt", true);
            
            //CAPTURA DE DATOS
            Console.WriteLine("Ingresa tu nombre: ");
            string texto = Console.ReadLine().ToString();
            Console.WriteLine("Ingresa tu Email: ");
            string email = Console.ReadLine().ToString();
            Console.WriteLine("Ingresa tu Edad: ");
            int edad = int.Parse(Console.ReadLine());

            //GENERADOR DE OBJETO DE CLASE
            DatosAlumno nuevoalumno = new DatosAlumno(texto, email, edad);
            nuevoalumno.desplegarDatos();

            //ESCRITURA EN EL ARCHIVO
            sw.WriteLine(texto, email, edad);

            //CERRADO DEL ARCHIVO
            sw.Close();

            //SALIDA DEL PROGRAMA
            Console.ReadKey();
        }
    }
}
