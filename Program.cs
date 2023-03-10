namespace Variabeltilordning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heltall = 32;
            long langtall = 64;
            float desimaltallf = 32.64f;
            decimal desimaltallM = 3.264M;
            double desimaltall = 4.63;
            string tekst = "Denne metoden returnerer ingenting";
            char bokstav = 'A';
            bool truefalse = false;

            //decimal sum = leggSammen(heltall, desimaltallM);
            //Console.WriteLine(tekst);
            Console.WriteLine("Hvem er det som tramper på min bro?");
            var svar = Console.ReadLine();
            Console.WriteLine("Javel da, " + svar + ", du kan gå denne gangen");

        }

        private static decimal leggSammen(int heltall, decimal desimaltallM)
        {
            return heltall + desimaltallM;
        }
    }
}