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

            decimal sum = leggSammen(heltall, desimaltallM);
            Console.WriteLine(tekst);

            testConsoleWriteRead();

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
                if (i == args.Length - 1)
                {
                    Console.WriteLine("Det er " + (i + 1) + " argumenter");
                }
            }
            int sammenlingningstall = 2;
            int brukertall = Console.Read();
            sammenlign(sammenlingningstall, brukertall);
            mattelign(sammenlingningstall, brukertall);
            check30(sammenlingningstall, brukertall);
        }

        private static bool check30(int sammenlingningstall, int brukertall)
        {
            if (sammenlingningstall + brukertall == 30 || brukertall == 30 || sammenlingningstall == 30)
            {
                return true;
            }
            else return false;
        }

        private static void testConsoleWriteRead()
        {
            Console.WriteLine("Hvem er det som tramper på min bro?");
            var svar = Console.ReadLine();
            Console.WriteLine("Javel da, " + svar + ", du kan gå denne gangen");
        }

        private static int mattelign(int sammenlingningstall, int brukertall)
        {
            if (sammenlingningstall == brukertall)
            {
                return sammenlingningstall * brukertall;
            }
            else return sammenlingningstall + brukertall;
        }

        private static decimal leggSammen(int heltall, decimal desimaltallM)
        {
            return heltall + desimaltallM;
        }
        private static bool sammenlign(int sammenligningstall, int brukertall)
        {
            if (sammenligningstall == brukertall)
            {
                return true;
            }else return false;
        }
    }
}