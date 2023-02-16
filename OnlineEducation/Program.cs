using OnlineEducation.InitStaticData;
using OnlineEducation.Models;

namespace OnlineEducation
{
    internal class Program
    {
        public static void Menyu()
        {
            Console.WriteLine("Welcome to Online Education");
            Console.WriteLine("1) Login to Student account");
            Console.WriteLine("2) Login to Teacher account");
            Console.WriteLine("3) List of courses");
            Console.WriteLine("4) Exit");
            Console.Write("Tanlang : ");
        }
        static void Main(string[] args)
        {
            string name, phone;

            Menyu();
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 4)
            {
                Console.Clear();
                Menyu();
            }

            switch (n)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Name : ");
                    name = Console.ReadLine();
                    Console.Write("Phone : ");
                    phone = Console.ReadLine();
                    Student student = new Student()
                    {
                        Account = Account.AddAccount("["),
                        Name = name,
                        Phone = phone,
                        Status = States.StudentStatus.Beginner
                    };
                    Console.WriteLine("1) List of courses");
                    Console.WriteLine("2) Return to menu : ");
                    Console.WriteLine("3) Exit");
                    Console.Write("Tanlang : ");
                    int c;
                    while (!int.TryParse(Console.ReadLine(), out c) || c < 1 || c > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("qayta kiriting : ");
                    }
                    switch (c)
                    {
                        case 1:Console.Clear();
                            Console.WriteLine("Kurslar ro`yxati:");
                            List<CourseDetails> courses = new();
                            InitData.InitCourses(ref courses);
                            foreach (var item in courses)
                            {
                               item.GetDetails();
                            }
                            Console.Write("Sotib olish uchun kurs nomini kiriting : ");
                            string s = Console.ReadLine();
                            Console.WriteLine($"Bizning {s} kursimizni soib oldingiz!");
                            break;
                        case 2: Console.Clear(); Menyu(); break;
                        case 3: break;
                        default:
                            break;
                    }
                    break;



                default:
                    break;
            }




            //Console.WriteLine("Kurslar ro`yxati:");
            //List<CourseDetails> courses = new();
            //InitData.InitCourses(ref courses);

            //foreach (var item in courses)
            //{
            //    item.GetDetails();
            //}


        }
    }
}