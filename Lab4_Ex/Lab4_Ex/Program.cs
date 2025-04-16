using System.Text;
class Gadget
{
    public string Name { get; set; }
    public string Diagonal { get; set; }
    public string Type { get; set; }
    public string Hertz { get; set; }
    public int Price { get; set; }
    public bool MultiMedia { get; set; }
    public bool Bluetooth { get; set; }

    public Gadget(string name, string diagonal, string type, string hertz, int price, bool multiMedia, bool bluetooth)
    {
        Name = name;
        Diagonal = diagonal;
        Type = type;
        Hertz = hertz;
        Price = price;
        MultiMedia = multiMedia;
        Bluetooth = bluetooth;
    }

    public void DisplayInfo()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine($"Введіть назву телевізора: {Name}");
        Console.WriteLine($"Введіть діагональ: {Diagonal}");
        Console.WriteLine($"Введіть тип екрану: {Type}");
        Console.WriteLine($"Введіть герцовку екрану: {Hertz}");
        Console.WriteLine($"Введіть вартість: {Price}");
        Console.WriteLine($"Мултімедіа: {(MultiMedia ? "Є" : "Ні")}");
        Console.WriteLine($"Bluetooth: {(Bluetooth ? "Є" : "Ні")}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Введіть дані телевізора:");

            Console.Write("Назва: ");
            string name = Console.ReadLine();

            Console.Write("Діагональ: ");
            string diagonal = Console.ReadLine();

            Console.Write("Тип екрану: ");
            string type = Console.ReadLine();

            Console.Write("Герцовка екрану: ");
            string hertz = Console.ReadLine();

            Console.Write("Вартість: ");
            int price = int.Parse(Console.ReadLine());

            Console.Write("Мультімедіа (да/нет): ");
            bool multiMedia = Console.ReadLine().ToLower() == "да";


            Console.Write("Есть блютуз? (да/нет): ");
            bool bluetooth = Console.ReadLine().ToLower() == "да";

            Gadget gadget = new Gadget(name, diagonal, type, hertz, price, multiMedia, bluetooth);
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("\nІнформація про телевізор:");
            gadget.DisplayInfo();
        }
    }
}