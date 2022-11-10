using System;

namespace Learning
{
    class Director : Employer
    {
        public override void DisplaySalary()
        {
            Console.WriteLine($"{JobTitle}: {Name}  Зарплата ($ в месяц): {Salary * 4}");
        }
        public override void Walk()
        {
            Console.WriteLine($"Имя : {Name} Возраст: {Age} Должность: {JobTitle} - на прогулке \n" +
               "Директору доступно 2 часa прогулки \n");
        }
        public override void Lunch()
        {
            Console.WriteLine($"Имя : {Name} Возраст: {Age} Должность: {JobTitle} - на прогулке \n" +
              "Директору доступно 2 часa обеда \n");
        }
    }
}


