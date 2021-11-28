using System;
namespace OOPExamPle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =3,b =4;
            a=++a;
            b=b++;
            //(a)
            Console.WriteLine("a");
            Console.WriteLine(a*b);
            //(b)
            //If we replace ++a =b++ by int al =3,bl =4;
            b =++b;
            a =++a;
            Console.WriteLine("b");
            Console.WriteLine(a*b);

            //(c)
            Console.WriteLine("c");
            a=a+1;
            b=b+1;
            Console.WriteLine(a*b);
            }

    }
}
