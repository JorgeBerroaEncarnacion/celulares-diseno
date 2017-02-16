using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace celularesDiseno
{
    class main 
    {
        static void Main(string[] args)
        {

            celular mycel = new PersonalCel(new configColor("rojo"), new camara10MP());
        

       

            Console.WriteLine(string.Format("El costo es  de {0} y color {1} ",mycel.costo(), mycel.descripcion()));

           
            

            Console.ReadKey();
           
        }

        



    }
}