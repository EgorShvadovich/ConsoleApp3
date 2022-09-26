using System;

namespace ConsoleApp3
{
    internal class Student
    {
        private string name;
        private int age;
        private string surname;

        private int dateDay;
        private int dateYear;
        private int dateMonth;
        private string address;
        private int phoneNumber;

        private int[] dzArr = new int[10];
        private int[] ekzArr = new int[5];

        public Student()
        {
            name = "andrey";
            age = 18;
            surname = "andreev";
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string surname, string name)
        {
            this.name = name;
            this.surname = surname;
        }
        public Student(string surname, string name, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
