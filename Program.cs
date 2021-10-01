using System;

namespace week1
{
    class Unitconverter
    {
        int ratio;

        public Unitconverter (int Unitratio)
        { ratio = Unitratio; }
        public int Convert (int Unit)
        { return Unit * ratio; }


    }
    class Panda
    {
        public string name;
        private int poppulation;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Unitconverter feettoInchesConverter = new Unitconverter(12);
            Unitconverter miletoInchesConverter = new Unitconverter(5200);

            Console.WriteLine(feettoInchesConverter.Convert(30));
            Console.WriteLine(feettoInchesConverter.Convert(100));
            Console.WriteLine(feettoInchesConverter.Convert(miletoInchesConverter.Convert(1)));



        }
    }
}
