using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises_1
{
        internal class Program
        {
            static void Main(string[] args)
            {
                ex01();
                ex02();
                ex03();
                ex04();
                ex05();
                ex06();
                ex07();
                ex08();
                ex09();
                ex10();

            }
            // 1. to Add / Sum Two Numbers.
            static void ex01()
            {
                Console.OutputEncoding = Encoding.UTF8;
                int a, b, tong;
                Console.WriteLine("Mời bạn nhập vào số nguyên a ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập vào số nguyên b ");
                b = int.Parse(Console.ReadLine());
                tong = a + b;
                Console.WriteLine($"{a}+{b} = {tong}");
                Console.ReadLine();
            }
            // 2. to Swap Values of Two Variables.
            static void ex02()
            {
                Console.OutputEncoding = Encoding.UTF8;
                int a, b;
                Console.WriteLine("Mời bạn nhập vào giá trị a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập vào giá trị b: ");
                b = int.Parse(Console.ReadLine());
                int doi = a;
                a = b;
                b = doi;
                Console.WriteLine($"Gía trị sau đổi {a} ");
                Console.WriteLine($"Gía trị sau đổi {b}");
                Console.ReadLine();
            }
            // 3. to Multiply two Floating Point Numbers
            static void ex03()
            {
                Console.OutputEncoding = Encoding.UTF8;
                double a, b, tich;
                Console.WriteLine("Mời bạn nhập vào số a: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập vào số b: ");
                b = double.Parse(Console.ReadLine());
                tich = a * b;
                Console.WriteLine($"{a} * {b} = {tich} ");
                Console.ReadLine();
            }
            // 4. to convert feet to meter
            static void ex04()
            {
                Console.OutputEncoding = Encoding.UTF8;
                double feet;
                Console.WriteLine("Mời bạn nhập vào số đo: ");
                feet = double.Parse(Console.ReadLine());
                double met = feet * 0.3048;
                Console.WriteLine($" {feet} feet = {met} m ");
                Console.ReadLine();
            }
            //  5. to convert Celsius to Fahrenheit and vice versa
            static void ex05()
            {
                Console.OutputEncoding = Encoding.UTF8;
                double c, f;
                Console.WriteLine("Mời bạn chọn 1 trong hai lựa chọn sau đây: ");
                Console.WriteLine("1. Chuyển từ độ C sang độ F");
                Console.WriteLine("2. Chuyển từ độ F sang độ C");
                int luachon = int.Parse(Console.ReadLine());
                if (luachon == 1)
                {
                    Console.WriteLine("Mời bạn nhập độ C: ");
                    c = double.Parse(Console.ReadLine());
                    double doic = (c * 9 / 5) + 32;
                    Console.WriteLine($"{c} độ C = {doic} độ F");
                    Console.ReadLine();
                }
                else if (luachon == 2)
                {
                    Console.WriteLine("Mời bạn nhập độ F: ");
                    f = double.Parse(Console.ReadLine());
                    double doif = (f - 32) * 5 / 9;
                    Console.WriteLine($"{f} độ F = {doif} độ C");
                    Console.ReadLine();
                }
                else { Console.WriteLine("Không có lựa chọn bạn mong muốn"); }
            }
            //  6. to find the Size of data types
            static void ex06()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine($"Kích thước của kiểu dữ liệu int là {sizeof(int)} byte");
                Console.WriteLine($"Kích thước của kiểu dữ liệu double là {sizeof(double)} byte");
                Console.ReadLine();
            }
            // 7. to Print ASCII Value (tip: read character, print number of this char)
            static void ex07()
            {
                Console.OutputEncoding = Encoding.UTF8;
                char ch;
                Console.WriteLine("Mời bạn nhập vào kí tự");
                ch = Console.ReadKey().KeyChar;
                int codeofchar = (int)ch;
                Console.WriteLine($"Mã ASCII Của {ch} là {codeofchar}");
                Console.ReadLine();
            }
            // 8. to Calculate Area of Circle
            static void ex08()
            {
                Console.OutputEncoding = Encoding.UTF8;
                double r, dientich;
                Console.WriteLine("Mời bạn nhập vào bán kính ");
                r = double.Parse(Console.ReadLine());
                dientich = 3.14 * Math.Pow(r, 2);
                Console.WriteLine($"Diện tích hình tròn bán kính {r}={dientich}");
            }
            // 9. to Calculate Area of Square
            static void ex09()
            {
                Console.OutputEncoding = Encoding.UTF8;
                double canh, dientich;
                Console.WriteLine("Mời bạn nhập chiều dài cạnh hình vuông: ");
                canh = double.Parse(Console.ReadLine());
                dientich = Math.Pow(canh, 2);
                Console.WriteLine($"Diện tích hình vuông là {dientich}");
                Console.ReadKey();
            }
            //  10. to convert days to years, weeks and days
            static void ex10()
            {
                Console.OutputEncoding = Encoding.UTF8;
                int songay;
                Console.WriteLine("Mời bạn nhập số ngày: ");
                songay = int.Parse(Console.ReadLine());
                int years = songay / 365;
                int ngaydu = songay % 365;
                int weeks = ngaydu / 7;
                int days = ngaydu % 7;
                Console.WriteLine($"{songay} ngày = {years} năm, {weeks} tuần, {days} ngày");
                Console.ReadKey();
            }
        }
    }



