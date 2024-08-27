using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args) 
        {
            using (Lecturas L = new Lecturas("prueba.cpp"))
            {
                //L.Encrypt2();
                Console.WriteLine($"Numero de letras: {(L.ContarLetras())}");
                Console.WriteLine($"Numero de espacios: {(L.ContarEspacios())}");       
             }
            
        }
    }
}
