internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("-----CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 1-----");
       double a, b;
        double x;
        Console.Write("Nhập vào số a đi nè : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nNhập vào số b đi nè : ");
        b = Convert.ToInt32(Console.ReadLine());
        /*Console.WriteLine("Bạn vừa nhập phương trình {0}x + {1} = 0", a, b);*/
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }    
        else
        {
            x = (double)-b / a;
            Console.WriteLine("Phương trình có nghiệm là : " +x);
        }

    }
}
