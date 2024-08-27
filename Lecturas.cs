using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Prueba
{
    public class Lecturas : IDisposable
    {
        StreamReader Prueba;
        StreamWriter log;
        public Lecturas()
        {
            Console.WriteLine("Constructor 1");
            Prueba = new StreamReader("prueba.cpp");
            log     = new StreamWriter("prueba.log");
        }
        public Lecturas(string nombre)
        {
            Console.WriteLine("****");
            Prueba = new StreamReader(nombre);
            log     = new StreamWriter("prueba.log");
        }
        
        public void Dispose()
        {
            Console.WriteLine("****");
            Prueba.Close();
            log.Close();
        }
        public void Copy()
        {
        while (!Prueba.EndOfStream)
    {
       log.Write((char)Prueba.Read()); 
    }
        }
         public void Encrypt()
        {
            char c;
        while (!Prueba.EndOfStream)
    {
        c = (char)Prueba.Read();
        if (char.IsLetter(c))
        {
        log.Write((char)(c+2));
        }
        else
        {
        log.Write(c);
        }
    
        }
        }
        public void DesEncrypt()
        {
            char c;
        while (!Prueba.EndOfStream)
    {
        c = (char)Prueba.Read();
        if (char.IsLetter(c))
        {
        log.Write((char)(c-2));
        }
        else
        {
        log.Write(c);
        }
    
        }
        }
        public void Encrypt2()
        {
        char c;
        while (!Prueba.EndOfStream)
        {
        c = (char)Prueba.Read();
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
        log.Write((char)('a'));
        }
        else
        {
        log.Write(c);
        }
        }
        }
        public int ContarLetras(){

            int contador = 0;
            char c;
            while (!Prueba.EndOfStream)
            {
                c = (char)Prueba.Read();
                if (char.IsLetter(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        public int ContarEspacios(){

            int contador=0;
            char c;
            while (!Prueba.EndOfStream)
            {
                c = (char)Prueba.Read();
                if (char.IsWhiteSpace(c))
                {
                    contador++;
                }
            }
            return contador;

        }

        /*public char primerCaracter(){
            char c; 

        }*/
    }
}