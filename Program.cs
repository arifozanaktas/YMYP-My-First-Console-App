namespace My_First_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //OOP => Object Oriented Programing => Nesne Yönelimli Programlama
            //Java,PHP,C#,VB,TypeScript
            //Class
            //string,int,boolean,date,object=> Primitive tip=> ilkel tip
            // değişken oluşturma
            //state
            //İsimlendirme Kuralları
            //values=> değişkenler
            //22:23 ders başlıyor.

            string name = "Arif";
            int age = 32;
            DateTime now = DateTime.Now;
            bool isTrue = true;
            object user = new { };
            //memory'de tutulma diyoruz.

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(now);
            Console.WriteLine(isTrue);
        
        }
    }
}