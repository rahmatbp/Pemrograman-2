using System;

namespace Tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Mamalia Gajah = new Mamalia();
            
            Gajah.makan();
            Console.WriteLine(Gajah.tidur());
            Gajah.bernafas();

            
        }
    }
}
