using System;

namespace Tugas1
{
    public class Mamalia : Hewan
    {
        //constructor

        public Mamalia()
        {

        }
        // property
        string nama;

        //function

        public void makan()
        {
            Console.WriteLine("sedang makan daun");
        }

        public string tidur()
        {
            return "tidur dikandang";
        }
    }
}