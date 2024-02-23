namespace Lesson4;
class Program
{
    public static void Main()
    {
        Bits bits1 = new Bits(12);
        long num = (long)bits1;
        Console.WriteLine(num);
        num = 1233;
        Bits bits2 = num;
        Console.WriteLine(bits2.Value);

        Bits bits3 = new Bits(12);
        int num1 = (int)bits3;
        Console.WriteLine(num1);
        num1 = 1233;
        Bits bits4 = num1;
        Console.WriteLine(bits4.Value);

        Bits bits5 = new Bits(12);
        byte num2 = (byte)bits5;
        Console.WriteLine(num2);
        num2 = 123;
        Bits bits6 = num2;
        Console.WriteLine(bits6.Value);
    }
}
