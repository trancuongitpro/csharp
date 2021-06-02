using System;
using System.Text;

namespace ConsoleApplication5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n, fact = 1, i=1;
            Console.Write("Nhập vào số tính giai thừa 1 -20:");
            //Sử dụng phương thức ReadLine() để đọc 1 chuỗi vào từ bàn phím
            //Dùng phương thức Parse() của đốit ượng Int32 để chuyển đổi số sang dạng chuỗi
            n = Int32.Parse(Console.ReadLine());
            //Chạy vòng lặp for và nhân dồn vào giá trị fact
            //fact = 1*2*3... (n-1)*n
            for(i=1; i<=n;i++)
                fact = fact *i;
            Console.WriteLine("Kết quả tính giai thừa là: " + fact);
        }
    }
}