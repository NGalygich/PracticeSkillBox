using System;

namespace project{
    public class Program{
        static public void Main(){
            string fullname = "Galyga Nikita Aleksandrovich";
            int age = 26;
            string email = "NGalygich@yandex.ru";
            float points_program = 3.5F;
            float points_math = 2.2F;
            float points_physics = 3.1F;
            FormatOutput(fullname, age, email, points_program, points_math, points_physics);
        }
        static public void FormatOutput(string fullname, int age, string email, float points_program, float points_math, float points_physics){
            Console.WriteLine($"Ф.И.О: {fullname}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Баллы по программированию {points_program,5}");
            Console.WriteLine($"Баллы по математике {points_math,11}");
            Console.WriteLine($"Баллы по физике {points_physics,15}");
        }
    }
}