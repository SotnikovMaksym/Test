using System;
using System.Collections.Generic;

namespace Learning
{
    class ListOfEmployees<T>
        where T : Employer
    {
        public List<Employer> employees;
        //public static void FillUserDate(Employer employer)
        //{
        //    do
        //    {
        //        Console.Write("Введите имя сотрудника: \n");
        //        employer.Name = Console.ReadLine();
        //        if (string.IsNullOrEmpty(employer.Name))
        //        {
        //            Console.WriteLine("Строка не может быть пустой");
        //        }
        //    }
        //    while (string.IsNullOrEmpty(employer.Name));
        //    Console.Clear();
        //    do
        //    {
        //        try
        //        {
        //            Console.Write("Введите возраст сотрудника: \n");
        //            employer.Age = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Необходимо ввести число");
        //        }
        //    }
        //    while (true);
        //    Console.Clear();
        //    do
        //    {
        //        try
        //        {
        //            Console.Write("Введите зарплату сотрудника (Ставка  $ в час ): \n");
        //            employer.Salary = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Необходимо ввести число");
        //        }
        //    }
        //    while (true);
        //    Console.Clear();
        //    do
        //    {
        //        Console.Write("Введите отдел сотрудника: \n");

        //        employer.Department = Console.ReadLine();
        //        if (string.IsNullOrEmpty(employer.Department))
        //        {
        //            Console.WriteLine("Строка не может быть пустой");
        //        }
        //    }
        //    while (string.IsNullOrEmpty(employer.Department));
        //    Console.Clear();
        //    do
        //    {
        //        try
        //        {
        //            Console.Write("Введите кол-во рабочих часов в неделю: \n");
        //            employer.WorkingHours = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Необходимо ввести число");
        //        }
        //    }   
        //    while (true);
        //    Console.Clear();
        //}
        public void AddUser()
        {
            employees = new List<Employer>();
            employees.Capacity = 10;
            Employer employer1 = new Employer()
            { Name = "Maks", Age = 26, Department = "QA", JobTitle = "Директор", Salary = 5000, WorkingHours = 40 };
            employees.Add(employer1);
            Employer employer2 = new Employer()
            { Name = "Vlad", Age = 36, Department = "SMM", JobTitle = "Бухгалтер", Salary = 2000, WorkingHours = 40 };
            employees.Add(employer2);
            Employer employer3 = new Employer()
            { Name = "Olya", Age = 19, Department = "DEV", JobTitle = "Работник", Salary = 1000, WorkingHours = 40 };
            employees.Add(employer3);
            Employer employer4 = new Employer()
            { Name = "Oleg", Age = 26, Department = "HR", JobTitle = "Бухгалтер", Salary = 2000, WorkingHours = 40 };
            employees.Add(employer4);
            Employer employer5 = new Employer()
            { Name = "Dima", Age = 26, Department = "Sale", JobTitle = "Работник", Salary = 1000, WorkingHours = 40 };
            employees.Add(employer5);
            Employer employer6 = new Employer()
            { Name = "Katya", Age = 26, Department = "Rec", JobTitle = "Бухгалтер", Salary = 2000, WorkingHours = 40 };
            employees.Add(employer6);
            Employer employer7 = new Employer()
            { Name = "Vika", Age = 26, Department = "CCO", JobTitle = "Работник", Salary = 1000, WorkingHours = 40 };
            employees.Add(employer7);
            Employer employer8 = new Employer()
            { Name = "Misha", Age = 26, Department = "AQA", JobTitle = "Работник", Salary = 1000, WorkingHours = 40 };
            employees.Add(employer8);
            Employer employer9 = new Employer()
            { Name = "Victor", Age = 26, Department = "Sec", JobTitle = "Работник", Salary = 1000, WorkingHours = 40 };
            employees.Add(employer9);
            Employer employer10 = new Employer()
            { Name = "Vlada", Age = 26, Department = "Test", JobTitle = "Директор", Salary = 5000, WorkingHours = 40 };
            employees.Add(employer10);
            //int number = 0;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите необходимое для добавления количество сотрудников");

            //        number = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch (FormatException)
            //    {
            //        Console.Write("Ошибка: введите целое число \n");
            //    }
            //}
            //while (number <= 0);
            //Console.Clear();
            //employees = new List<Employer>();
            //employees.Capacity = number;
            //Employer employer = new Employer();
            //do
            //{
            //    employees.Add(employer);
            //    do
            //    {
            //        Console.Write("\nВыберите должность сотрудника (1/2/3): \n" +
            //                "1. Директор \n" +
            //                "2. Бухгалтер \n" +
            //                "3. Работник \n");
            //        var A = Console.ReadLine();
            //        switch (A)
            //        {
            //            case "1":
            //                employer = new Director();
            //                employer.JobTitle = "Директор";
            //                break;
            //            case "2":
            //                employer = new Accountant();
            //                employer.JobTitle = "Бухгалтер";
            //                break;
            //            case "3":
            //                employer = new Employer();
            //                employer.JobTitle = "Работник";
            //                break;
            //           default: 
            //                Console.Write("Введите целое число \n");
            //                break;
            //        }
            //    }
            //    while (employer.JobTitle != "Директор" ^ employer.JobTitle != "Бухгалтер" ^ employer.JobTitle != "Работник");
            //    Console.Clear();
            //    FillUserDate(employer);
            //    employer.input(employer.Name, employer.Age, employer.Salary, employer.Department, employer.WorkingHours, employer.JobTitle);
            //    employees[employees.Count - 1] = employer;
            //}
            //while (employees.Capacity != employees.Count);
        }
        public void DisplayAllUsers()
        {
            var AllPeople = from i in employees
                            orderby i.Name
                            select i;
            foreach (Employer i in AllPeople)
                Console.WriteLine($"{i.Name} - {i.Age} - {i.Department} - {i.JobTitle} - {i.Salary} \n");

            //foreach (Employer user in employees)
            //{
            //    user.DIsplayInfo();
            //}
            //AllPeople.Sort();
            //foreach (Employer user in AllPeople)
            //    Console.WriteLine(user);
        }
        public void SearchUser(string search)
        {
            var search1 = from p in employees
                         where p.Name == search
                         orderby p
                         select p;
            foreach (Employer p in search1)
                Console.WriteLine($"{p.Name} - {p.Age} - {p.Department} \n");
                //if (user.Name == search)
                //    Console.WriteLine($"Возраст: {user.Age} Должность: {user.JobTitle} \n");
        }
        public void DisplayDepartmentUsers(string search_department)
        {
            var department = from p in employees
                             where p.Department == search_department
                             orderby p
                             select p;
            foreach (Employer p in department)
                Console.WriteLine($"{p.Name} - {p.Age} - {p.Department} \n");
            //{ 
            //    if (user.Department == search_department)
            //        Console.WriteLine($"{user.Name} Возраст: {user.Age} Должность: {user.JobTitle} \n");
            //}
        }
        public void DisplayMaxSalary()
        {
            double MaxSalary = employees.Max(p => p.Salary);
            Console.WriteLine($"Максимальная зарплата в месяц составляет: {MaxSalary} y.o \n");
        }
        public void DisplayMinSalary()
        {
            double MinSalary = employees.Min(p => p.Salary);
            Console.WriteLine($"Минимальная зарплата в месяц составляет: {MinSalary} y.o \n");
        }
        public void DisplayAverageAge()
        {
            int average = employees.Sum(p => p.Age) / employees.Count;
            Console.WriteLine($"Средний возраст составляет: {average}  \n");
        }
        public void DisplayWorkingHours()
        {
            foreach (Employer user in employees)
            {
                user.DisplayWorkingHours();
            }
        }
        public void DisplaySalary()
        {
            foreach (Employer salary in employees)
            {
                salary.DisplaySalary();
            }
        }
        public void Walk()
        {
            Console.Write("Введите имя сотрудника которому необходима прогулка: \n");
            string search = Console.ReadLine();
            if (string.IsNullOrEmpty(search))
            {
                Console.WriteLine("Строка не может быть пустой");
            }
            foreach (Employer user in employees)
                if (user.Name == search)
                  user.Walk();
        }
        public void Lunch()
        {
            Console.Write("Введите имя сотрудника которому необходим обед: \n");
            string search = Console.ReadLine();
            if (string.IsNullOrEmpty(search))
            {
                Console.WriteLine("Строка не может быть пустой");
            }
            foreach (Employer user in employees)
                if (user.Name == search)
                    user.Lunch();
        }
    }
}


