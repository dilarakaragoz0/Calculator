namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.Write("Birinci Sayıyı Giriniz: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.Write("İşlem Seçiniz (+) (-) (*) (/) (%): ");
            string islem = Console.ReadLine();

            Console.Write("İkinci Sayıyı Giriniz: ");
            double sayi2 = double.Parse(Console.ReadLine());

            double sonuc = 0;
            switch (islem)
            {
                case "+":sonuc = sayi1 + sayi2;break;     
                case "-":sonuc = sayi1 - sayi2;break;    
                case "*":sonuc = sayi1 * sayi2;break;    
                case "/":sonuc = sayi1 / sayi2;break;
                case "%":sonuc = sayi1 % sayi2;break;        
            }
            

            Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " = " + sonuc);
        }
    }
}