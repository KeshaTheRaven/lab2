﻿using System.Linq;
using static Obuch.Program;


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
            public string name;
            public string secondname;
            public DateTime birthday;


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
            public int Grade;
            public DateTime ExamDate;

            public Exam(string dicipline, int score, DateTime ExamDate)
            {
                this.dicipline = dicipline;
                this.Grade = score;
                this.ExamDate = ExamDate;
            }
            public Exam() : this("Default", 5, new DateTime(2008, 6, 1))
            {
            }

            public string ToFullString()
            {
                return $"Наименование: {dicipline}, оценка: {Grade}, дата экзамена: {ExamDate}";
            }

        }
        class Student
        {
            public Person info;
            public Education form;
            public int group;
            public Exam[] _passedExams;


            public Student(Person info, Education form, int group)
            {
                this.info = info;
                this.form = form;
                this.group = group;
                this._passedExams = new Exam[0];


            }

            public Student()
            {
                this.info = new Person();
                this.group = 0;
                this.form = Education.Bachelor;
                this._passedExams = new Exam[0];

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

            public double AvarageRate => _passedExams.Average(ex => ex.Grade);


            public void AddExams(Exam[] examen)
            {
                int _OldSize = _passedExams.Length;
                Array.Resize<Exam>(ref _passedExams, _OldSize + examen.Length);
                examen.CopyTo(_passedExams, _OldSize);



            }
            public void ToFullString()
            {
                Console.WriteLine($"студент: {info.Name} {info.Secondname} {info.Birthday}, форма обучения:{form}, группа {group}, результат экзамена:");



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

            Student s1 = new Student();
            Exam[] examen = new Exam[5];
            examen[0] = new Exam("math", 4, new DateTime(2008, 6, 1));
            examen[1] = new Exam("phys", 4, new DateTime(2006, 6, 1));
            examen[2] = new Exam("inf", 4, new DateTime(2001, 6, 1));
            examen[3] = new Exam("inf", 3, new DateTime(2002, 6, 1));
            examen[4] = new Exam("inf", 3, new DateTime(2003, 6, 1));
            Student stud = new Student(p1, Education.Bachelor, 109);
            stud.AddExams(examen);



            Console.WriteLine(value: stud.AvarageRate);
            Console.WriteLine(p1.ToFullString());
            s1.ToFullString();






        }

    }
}

