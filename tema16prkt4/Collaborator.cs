using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema16prkt4
{
    class Collaborator
    {
        int Num { get; set; }
        string Fio { get; set; }
        DateTime data { get; set; }
        string Position { get; set; }
        int Salary { get; set; }

        public Collaborator() { }
        public Collaborator(int Num,string Fio,DateTime data,string Position,int Salary)
        {
            this.Num = Num;
            this.Fio = Fio;
            this.data = data;
            this.Position = Position;
            this.Salary = Salary;
        }
        public void Voz()
        {
            int age = DateTime.Now.Year - data.Year;
            if (DateTime.Now < data.AddYears(age)) age--;
            Console.WriteLine($" Возраст сотрудника - {age} лет");
        }
        public void Pringles()
        {
            Write($"Введите табельный номер сотрудника: ");
            Num = int.Parse(ReadLine());
            Write("Введите ФИО сотрудника: ");
            Fio = ReadLine();
            Write("Введите дату рождения: ");
            data = DateTime.Parse(ReadLine());
            Write("Введите должность сотрудника: ");
            Position = ReadLine();
            Write("Введите зарплату сотрудника: ");
            Salary = int.Parse(ReadLine());
        }
        //string a = "Таб.номер",b = "ФИО", v = "Дата рождени" +
        //    "я", g = "Должность", z = "Зарплата";
        public void Print()
        {
            //WriteLine($"\t|  {a}    |    {b}    |      {v}     |   {g}    |   {z}  |");

            WriteLine($"\t| {Num}   |   {Fio}   |    {data.ToString("dd MM yyyy")}    |{Position}|{Salary}|");
        }
    }
}
