using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katherine_program
{
    class Program
    {
       
        }
        static void Main(string[] args
          
        
        {
            int a = 0, b = 0, c = 0, i=0;
    
                i=20;
                    do{cout<<i<<end1;
                        i++;
                



    while(i<20);



        Console.Write("ESCRIBA LA CANTIDAD DE PERSONA EN LA SECCION ZONA NORTE" );
                a= int.Parse(Console.ReadLine());
            
            Console.Write("ESCRIBA LA CANTIDAD DE PERSONA EN LA SECCION ZONA SUR" );
                b=int.Parse(Console.ReadLine());
            
            Console.Write("ESCRIBA LA CANTIDAD DE PERSONA EN LA SECCION CENTRAL" );
                c=int.Parse(Console.ReadLine());

                if (a > b)
                    if (a > c)
                        Console.WriteLine("LA MAYOR CANTIDAD DE PERSONA ASISTIDA ESTA EN LA SECCION NORTE  {0}", a);
                    
                    else 
                        if (c > b)
                        Console.WriteLine("LA MAYOR CANTIDAD DE PERSONA ASISTIDA ESTA EN LA SECCION CENTRAL  {0}", c);
                    else 
                        Console.WriteLine("LA CANTIDAD DE PERSONA ASISTIDA ESTA EN LA ZONA SUR  {0}", b);

                else

         if (b > c) Console.WriteLine("LA MAYOR CANTIDAD DE PERSONA ASISTIDA ESTA EN LA SECCION SUR  {0}", b);

                else 
             Console.WriteLine("LA CANTIDAD DE PERSONA ASISTIDA ESTA EN LA SECCION CENTRAL  {0}",c);


            

                
                   


                }
             



                Console.ReadKey();










        }
    }
}
