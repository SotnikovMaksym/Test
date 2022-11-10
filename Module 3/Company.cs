using System;

namespace Learning
{
    class Company 
    {
        ListOfEmployees<Employer> ul = new ListOfEmployees<Employer>();
        public void AddUser()
        {
            ul.AddUser();
        }
        public void DisplayAllUsers()
        {
          ul.DisplayAllUsers();
        }
        public void SearchUser()
        {
                Console.Write("Введите имя сотрудника: \n");
                 string search_name = Console.ReadLine();
                if (string.IsNullOrEmpty(search_name))
                {
                    Console.WriteLine("Строка не может быть пустой");
                }
            Console.WriteLine($"\nИнформация по сотруднику {search_name}: \n");
            ul.SearchUser(search_name);
        }
        public void DisplayDepartmentUsers()
        {
            Console.Write("Введите нужный отдел: \n");
            string department = Console.ReadLine();
            if (string.IsNullOrEmpty(department))
            {
                Console.WriteLine("Строка не может быть пустой");
            }
            Console.WriteLine("\nСписок всех сотрудников даного отдела: \n");
            ul.DisplayDepartmentUsers(department);
        }
        public void DisplayMaxSalary()
        {
           ul.DisplayMaxSalary();
        }
        public void DisplayMinSalary()
        {
            ul.DisplayMinSalary();
        }
        public void DisplayAverageAge()
        {
           ul.DisplayAverageAge();
        }
        public void DisplayWorkingHours()
        {
            ul.DisplayWorkingHours();
        }
        public void DisplaySalary()
        {
            ul.DisplaySalary();
        }
        public void Walk()
        {
            ul.Walk();
        }
        public void Lunch()
        {
            ul.Lunch();
        }
    }
}


