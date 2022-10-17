using System;
using System.Collections.Generic;

namespace Obuch
{
    class Program
    {
        enum Education
        {
            Specialist,
            Bachelor,
            SecondEducational
        }
        public class Person
        {
            private string name;
            private string secondname;
            private DateTime birthday;


            public Person(string name, string secondname, DateTime birthday)
            {
                this.name = name;
                this.secondname = secondname;
                this.birthday = birthday;
            }
            public Person()
            {
                this.name = "Иван";
                this.secondname = "Иванов";
                this.birthday = new DateTime(1999, 01, 01);
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Secondname
            {
                get { return secondname; }
                set { secondname = value; }
            }
            public DateTime Birthday
            {
                get { return birthday; }
                set { birthday = value; }
            }
            public int year
            {
                get { return year; }
                set { year = value; }
            }
            public string ToFullString()
            {
                return $"Имя: {name}, фамилия: {secondname}, дата рождения: {birthday}";
            }
            public string ToShortString(string name, string secondname)
            {
                return $"Имя: {name}, фамилия: {secondname}";
            }

        }

        class Exam
        {
            public string dicipline;
            public int score;
            public DateTime ExamDate;

            public Exam(string dicipline, int score, DateTime ExamDate)
            {
                this.dicipline = dicipline;
                this.score = score;
                this.ExamDate = ExamDate;
            }
            public Exam()
            {

                this.dicipline = "";
                this.score = 0;
                this.ExamDate = new DateTime(1999, 01, 01);
            }
            public string ToFullString()
            {
                return $"Наименование: {dicipline}, оценка: {score}, дата экзамена: {ExamDate}";
            }

        }
        class Student
        {
            private Person info;
            private Education form;
            private int group;
            private Exam[] sdal;


            public Student(Person info, Education form, int group)
            {
                this.info = info;
                this.form = form;
                this.group = group;
            }

            public Student()
            {
                this.info = new Person();
                this.group = 0;
                this.form = Education.Bachelor;
            }

            public Person Info
            {
                get { return info; }
                set { info = value; }
            }
            public Education Form
            {
                get { return form; }
                set { form = value; }
            }
            public int Group
            {
                get { return group; }
                set { group = value; }
            }
            public Exam[] Sdal
            {
                get { return sdal; }
                set
                {
                    sdal = value;
                }
            }
            public double AvarageRate
            {
                get
                {
                    return AvarageRate;
                }
                set
                {
                    AvarageRate = new Exam().score / sdal.Length;
                }
            }
            public void addExams(params Exam[] exam)
            {

            }
            public string ToFullString()
            {
                return $"студент: {info.Name} {info.Secondname} {info.Birthday}, форма обучения:{form}, группа {group}, результат экзамена: {sdal}";
            }
            public string ToShortString(string _name, string _secondname)
            {
                return $"студент: {info.Name} {info.Secondname} {info.Birthday},  форма обучения:{form}, группа {group}, средний балл {AvarageRate}";
            }
        }
        static void Main()
        {
            Person p1 = new Person();
            p1.Name = "John";
            p1.Secondname = "wwwww";
            p1.Birthday = DateTime.Parse("01.02.99");
            Exam e1 = new Exam();
            e1.dicipline = "math";
            e1.score = 4;
            e1.ExamDate = DateTime.Parse("04.02.19.12:22");
            Student s1 = new Student();
            s1.Info = p1;
            s1.Form = Education.Specialist;
            s1.Group = 2101;
            Console.WriteLine(p1.ToFullString());
            Console.WriteLine(e1.ToFullString());
            Console.WriteLine(s1.ToFullString());

        }
    }
}
