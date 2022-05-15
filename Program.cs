using System;

namespace project{
    public class Program{
        public static void Main(){
            Student nikita = new Student();
            Task_1(nikita.fullname, nikita.age, nikita.email, nikita.points_program, nikita.points_math, nikita.points_physics);
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while(keyInfo.Key != ConsoleKey.Enter)
                keyInfo = Console.ReadKey();
            Task_2(nikita.points_program, nikita.points_math, nikita.points_physics);
        }

        public static void Task_1(string fullname, int age, string email, float points_program, float points_math, float points_physics){
            Console.WriteLine($"Ф.И.О: {fullname}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Баллы по программированию {points_program,5}");
            Console.WriteLine($"Баллы по математике {points_math,11}");
            Console.WriteLine($"Баллы по физике {points_physics,15}");
            Console.WriteLine("Для подсчета среднего арифметического балла нажмите 'Enter'");
        }
        public static void Task_2(float points_program, float points_math, float points_physics){
            float points_sum = points_program + points_math + points_physics;
            int mean = Convert.ToInt32(Math.Round(points_sum/3));
            Console.WriteLine($"Средний бал по всем предметам: {mean}");
        }
    }
}