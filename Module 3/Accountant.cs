using System;

namespace Learning
{
    class Accountant : Employer
    {
        public override void DisplaySalary()
        {
            Console.WriteLine($"{JobTitle}: {Name}  Зарплата ($ в месяц): {Salary * 2}");
        }
        public override void Walk()
        {
            Console.WriteLine($"Имя : {Name} Возраст: {Age} Должность: {JobTitle} - на прогулке \n" +
               "Бухгалтеру доступно 1.5 часa прогулки \n");
        }
        public override void Lunch()
        {
            Console.WriteLine($"Имя : {Name} Возраст: {Age} Должность: {JobTitle} - на прогулке \n" +
               "Бухгалтеру доступно 1.5 часa обеда \n");
        }
    }
}


