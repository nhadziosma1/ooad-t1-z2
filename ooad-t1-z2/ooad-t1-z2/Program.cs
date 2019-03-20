using System;

namespace ooad_t1_z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli broj koji oznacava broj spratova trougla/piramide: ");
            int brojNivoa;
            while (Int32.TryParse(Console.ReadLine(), out brojNivoa) == false)
                Console.WriteLine("pogrešan unos, unesite ponovno: ");

            for(int i=0; i<brojNivoa; i++)
            {
                for(int j=0; j<2*brojNivoa-1; j++)
                {
                    if (j < brojNivoa && i+j>=brojNivoa-1)
                        Console.Write("*");
                    else if(j>=brojNivoa && j<2*brojNivoa-1 && j-i<brojNivoa)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
    }
}
