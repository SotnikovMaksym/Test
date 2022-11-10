using System;

namespace Learning
{
    class Employer : Human, IRest
    {
        private double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        private string department;
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        private int workingHours;
        public int WorkingHours
        {
            get
            {
                return workingHours;
            }
            set
            {
                workingHours = value;
            }
        }
        private string jobTitle;
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        public void create(string name,int age, double salary, string department, int workingHours, string jobTitle)
        {
            Name = name;
            Age = age;
            Salary = (salary * workingHours) * 4;
            this.department = department;
            this.workingHours = workingHours;
            this.jobTitle = jobTitle;
        }
        //public void DIsplayInfo()
        //{
        //   Console.WriteLine($"{JobTitle}: {Name}  Возраст: {Age} Ставка ($ в месяц): {Salary} Отдел: {department} Часов в месяц: {workingHours * 4} \n");
        //}
        public void DisplayWorkingHours()
        {
            Console.WriteLine($"{JobTitle}: {Name} Отработанных часов в месяц: {workingHours * 4} \n");
        }
        public virtual void DisplaySalary()
        {
            Console.WriteLine($"{JobTitle}: {Name}  Зарплата ($ в месяц): {Salary} \n");
        }
        public virtual void Walk()
        {
            Console.WriteLine($"Имя : {Name} Возраст: {Age} Должность: {JobTitle} - на прогулке \n" +
                $"Работнику доступно 1 час прогулки \n");
        }
        public virtual void Lunch()
        {
            Console.WriteLine($"Имя : {Name} Возраст: {Age} Должность: {JobTitle} - на обеде \n" +
                $"Работнику доступно 1 час обеда \n");
        }
    }
}


