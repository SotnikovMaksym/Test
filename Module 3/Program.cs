using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Company langate = new Company();
            langate.AddUser();
            int choose = 0;
            do
            {
                Console.Write("Выберите следующую функцию: \n" +
             "1. Вывести всех сорудников \n" +
             "2. Вывести сотрудников отдельного отдела \n" +
             "3. Найти сотрудника по имени \n" +
             "4. Вывести максимальную ЗП \n" +
             "5. Вывести минимальную ЗП \n" +
             "6. Вывести средний возраст сотрудников \n" +
             "7. Вывести кол-во рабочих часов в месяц \n" +
             "8. Расчитать всем зарплату с учетом всех премий \n" +
             "9. Отправить работника на перерыв \n" +
             "0. Выйти из программы \n");
                choose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Список всех сотрудников: \n");
                        langate.DisplayAllUsers();
                        break;
                    case 2:
                        langate.DisplayDepartmentUsers();
                        break;
                    case 3:
                        langate.SearchUser();
                        break;
                    case 4:
                        langate.DisplayMaxSalary();
                        break;
                    case 5:
                        langate.DisplayMinSalary();
                        break;
                    case 6:
                        langate.DisplayAverageAge();
                        break;
                    case 7:
                        langate.DisplayWorkingHours();
                        break;
                    case 8:
                        langate.DisplaySalary();
                        break;
                    case 9:
                        int rest_choose = 0;
                        Console.Write("Выберите тип перерыва: \n" +
                            "1. Обед \n" +
                            "2. Прогулка \n");
                        rest_choose = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (rest_choose)
                        {
                            case 1:
                                langate.Lunch();
                                break;
                            case 2:
                                langate.Walk();
                                break;
                        }
                        break;
                }
            }
            while (choose != 0);
            {
                Console.Clear();
                Console.WriteLine("Всегда рады возвращению :)");
            }
            Console.ReadLine();
        }   
    }
}   



