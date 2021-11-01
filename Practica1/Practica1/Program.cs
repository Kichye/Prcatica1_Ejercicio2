using System;

namespace Practica1
{
    class Program
    {


        static void Main(string[] args)
        {
            
            ListAl list = new ListAl();
            Nodo nd = new Nodo();
            Console.WriteLine("Ingrese cantidad de numeros aleatoreos");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            list.EnlistarAleatorio(cantidad);
            Console.WriteLine("Lista generada aleatoreamente");
            ml();
            Console.WriteLine("Lista ordenada");
            oi(list.Inicio);
            Console.ReadKey();
           
            void ml()
            {
                ml2(list.Inicio);
            }
            void ml2(Nodo nodo)
            {
                Console.WriteLine(nodo.Valor.ToString());
                if (nodo.next != null)
                { ml2(nodo.next); }
            
            }

            void oi (Nodo nodo)
            {
                if (nodo != null)
                {
                    int modulo = nodo.Valor % 2;

                    if (modulo == 0)
                    {
                        Console.WriteLine("Estos son pares " + nodo.Valor.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Estos son impares "+nodo.Valor.ToString());
                    }
                    oi(nodo.next);
                }
            }



        }









    }




}


    

  

    

    