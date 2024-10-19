namespace CarpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplam = 0;
            Console.WriteLine("***********ÇARPIM TABLOSU*************");
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i + "*" + j + " : ");
                    toplam = i * j;
                    Console.WriteLine(toplam);
                }
             Console.WriteLine("*****************************************");
            }
        }

            
    }
}
