namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.Write("Birinci Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İşlem Seçiniz (+) (-) (*) (/) (%): ");
            string islem = Console.ReadLine();

            Console.Write("İkinci Sayıyı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (islem)
            {
                case "+":
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case "-":
                    Console.WriteLine(sayi1 - sayi2);
                    break;

            }

        }
    }
}