using System;
using System.Collections.Generic;
using System.IO;

namespace Finaly_4_Balan_Anastasiia
{
    interface IRoleStuding
    {
        //The method writes the role at the university has a specific object or person.
        public abstract void RoleStuding();
    }
    class Program
    {
        delegate void CreateFile(string s);
        delegate void Message();
        delegate void MessageCount();
        /// <summary>
        /// The method determines the name of the delegate.
        /// </summary>
        /// <param name="s"></param>
        public delegate void MyDelegate1(string s);

        static void Main()
        {
            Console.Clear();
            Message mes;
            Student stud1 = new Student("Nastia", "Balan", 18, "female", "IFNTUNG", "IIT", 2, "IP-20-2", true);
            Student stud2 = new Student("Maks", "Gnatiuk", 18, "male", "LNU", "EK", 2, "EK-20-1", false);
            Student stud3 = new Student("Ann", "Gakal", 19, "female", "LPU", "IIT", 3, "IP-19-1", false);
            Student stud4 = new Student("Tony", "Biluk", 22, "female", "KPU", "IIT", 4, "IP-18-2", true);

            Teacher teach1 = new Teacher("Pethro", "Petriv", 38, "male", "IFNTUNG", "MT", 15, true, "Math");
            Teacher teach2 = new Teacher("Ivanov", "Ivan", 48, "male", "LNU", "IIT", 25, true, "Biology");
            Teacher teach3 = new Teacher("Anna", "Petnoy", 28, "female", "LPU", "IIT", 35, true, "UNIX");
            Teacher teach4 = new Teacher("Liubov", "Sakura", 44, "female", "KPU", "IIT", 17, false, "Java");

            Subject sub1 = new Subject("Math",80);
            Subject sub2 = new Subject("PE", 100);
            Subject sub3 = new Subject("UNIX", 92);
            Subject sub4 = new Subject("Java", 88);
            Subject sub5 = new Subject("C++", 66);
            Subject sub6 = new Subject("C", 71);
            Subject sub7 = new Subject("Physics", 92);
            Subject sub8 = new Subject("Biology", 96);

            stud1.subject = sub1;
            stud1.subject = sub2;
            stud2.subject = sub3;
            stud2.subject = sub4;
            stud3.subject = sub5;
            stud3.subject = sub6;
            stud4.subject = sub7;
            stud4.subject = sub8;

            List<Student> student_list = new List<Student>();
            List<Teacher> teacher_list = new List<Teacher>();
            List<Subject> subject_list = new List<Subject>();

            student_list.Add(stud1);
            student_list.Add(stud2);
            student_list.Add(stud3);
            student_list.Add(stud4);
            teacher_list.Add(teach1);
            teacher_list.Add(teach2);
            teacher_list.Add(teach3);
            teacher_list.Add(teach4);
            subject_list.Add(sub1);
            subject_list.Add(sub2);
            subject_list.Add(sub3);
            subject_list.Add(sub4);
            subject_list.Add(sub5);
            subject_list.Add(sub6);
            subject_list.Add(sub7);
            subject_list.Add(sub8);

            string file_stud="Student.txt";
            string file_teach = "Teacher.txt";
            StreamWriter txt_student = new StreamWriter(file_stud);
            StreamWriter txt_teacher = new StreamWriter(file_teach);
            mes = () => AddFile(file_stud);
            mes();
            mes = () => AddFile(file_teach);
            mes();
            Console.WriteLine("This program allows you to add data about students, their grades of two subjects. You can also add teachers\n and data about them.You can use the menu to get certain values");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Options for this program :");
                Console.WriteLine("1 - Add student");
                Console.WriteLine("2 - Add teacher");
                Console.WriteLine("3 - Show student");
                Console.WriteLine("4 - Show teacher");
                Console.WriteLine("5 - Show subject");
                Console.WriteLine("6 - Role Student (Also clear menu) ");
                Console.WriteLine("7 - Role Teacher (Also clear menu)");
                Console.WriteLine("8 - Role Subject (Also clear menu)");
                Console.WriteLine("9 - Pay students");
                Console.WriteLine("10 - Pay teacher");
                Console.WriteLine("11 - Exit");


                Console.Write("Your choice: ");
                int k_swich = int.Parse(Console.ReadLine());
                if (k_swich < 13)
                {
                    switch (k_swich)
                    {
                        case 1:
                            student_list.Add(AddStudent(student_list, subject_list));
                            mes = AddStudent;
                            mes();
                            break;
                        case 2:
                            teacher_list.Add(AddTeacher(teacher_list));
                            mes = AddTeacher;
                            mes();
                            break;
                        case 3:
                            ShowStudent(student_list);
                            break;
                        case 4:
                            ShowTeacher(teacher_list);
                            break;
                        case 5:
                            ShowSubject(subject_list);
                            break;
                        case 6:
                            Console.Clear();
                            student_list[0].RoleStuding();
                            break;
                        case 7:
                            Console.Clear();
                            teacher_list[0].RoleStuding();
                            break;
                        case 8:
                            Console.Clear();
                            subject_list[0].RoleStuding();
                            break;
                        case 9:
                            foreach (Student stud in student_list)
                            {
                                stud.Pay();
                            }
                            break;
                        case 10:
                            foreach (Teacher teach in teacher_list)
                            {
                                teach.Pay();
                            }
                            break;
                        case 11:
                            foreach (Teacher teach in teacher_list)
                            {
                                txt_teacher.WriteLine(teach.ReturnPerson());
                            }
                            foreach (Student stud in student_list)
                            {
                                txt_student.WriteLine(stud.ReturnPerson());
                            }
                            txt_teacher.Close();
                            txt_student.Close();
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("You enntered an incorrect value. Plese, try again");
                            Main();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You enntered an incorrect value. Plese, try again");
                    Main();
                }
            } while (true);
        }


        static void AddFile(string file_name)
        {
            Console.WriteLine($"Add File {file_name}");
        }
        static void AddStudent()
        {
            Console.WriteLine("Add Student is succesfull");
        }
        static void AddTeacher()
        {
            Console.WriteLine("Add Teacher is succesfull");
        }
        /// <summary>
        /// The method write the value that was defined earlier.
        /// </summary>
        /// <param name="s"></param>
        static public void Print(string s)
        {
            Console.WriteLine(s);
        }
        
        static Student AddStudent(List<Student> student_list, List<Subject> subject_list)
        {
            string first_name = "", last_name = "", gender = "", faculty = "", university = "", group = "";
            int age = 0, course = 0;
            bool form_study = false;
            try
            {
                Console.Write("First name :");
                first_name = Convert.ToString(Console.ReadLine());
                Console.Write("Last name :");
                last_name = Convert.ToString(Console.ReadLine());
                Console.Write("Age :");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Gender (male, female) :");
                gender = Convert.ToString(Console.ReadLine());
                Console.Write("University :");
                university = Convert.ToString(Console.ReadLine());
                Console.Write("Faculty :");
                faculty = Convert.ToString(Console.ReadLine());
                Console.Write("Course :");
                course = Convert.ToInt32(Console.ReadLine());
                Console.Write("Group :");
                group = Convert.ToString(Console.ReadLine());
                Console.Write("Form study (true-state, false-pay) :");
                form_study = Convert.ToBoolean(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("Ви ввели не коректне значення");
                Main();
            }
            Student stud = new Student(first_name, last_name, age, gender, university, faculty, course, group, form_study);

            Console.WriteLine("Add 2 subjects for student");
            int k_sub = 1;
            int grade1 = 0;
            int grade2 = 0;
            while (k_sub < 3)
            {
                Console.WriteLine($"Subject {k_sub}");
                AddSubject(subject_list);
                foreach(Subject sub in subject_list)
                {
                    stud.subject= sub;
                    if (k_sub==1) {
                        grade1 =sub.Grade1;
                    }
                    else if(k_sub==2)
                    {
                        grade2 = sub.Grade1;
                    }
                }
                k_sub++;
            }
            stud.AVG(grade1,grade2);
            stud.Notify += Print;
            stud.AddPerson();
            return stud;
        }        
        static Teacher AddTeacher(List<Teacher> teacher_list)
        {
            string first_name = "", last_name = "", gender = "", faculty = "", university = "", name_subject = "";
            int age = 0, experience = 0;
            bool vacation_year = false;
            try
            {
                Console.Write("First name :");
                first_name = Convert.ToString(Console.ReadLine());
                Console.Write("Last name :");
                last_name = Convert.ToString(Console.ReadLine());
                Console.Write("Age :");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Gender (male, female) :");
                gender = Convert.ToString(Console.ReadLine());
                Console.Write("University :");
                university = Convert.ToString(Console.ReadLine());
                Console.Write("Faculty :");
                faculty = Convert.ToString(Console.ReadLine());
                Console.Write("Experience in years :");
                experience = Convert.ToInt32(Console.ReadLine());
                Console.Write("Vacation year (true, false) :");
                vacation_year = Convert.ToBoolean(Console.ReadLine());
                Console.Write("Name subject :");
                name_subject = Convert.ToString(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("Ви ввели не коректне значення");
                Main();
            }
            Teacher teach = new Teacher(first_name, last_name, age, gender, university, faculty, experience, vacation_year, name_subject);
            teach.Notify += Print;
            teach.AddPerson();
            return teach;
        }
        static Subject AddSubject(List<Subject> subject_list)
        {
            string name = "";
            int grade = 0;
            try
            {
            Console.Write("Name :");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Grade :");
            grade = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("You entered an incorrect value");
                Main();
            }
            Subject sub1 = new Subject(name, grade);
            subject_list.Add(sub1);
            return sub1;
        }
        static void ShowStudent(List<Student> student_list)
        {
            Console.WriteLine("First|\tLast name|Age|\tGender|\tFaculty|Course|\tGroup|\tForm study(true-state, false-pay");
            foreach (Student stud in student_list)
            {
                Console.WriteLine(stud.ReturnPerson());
            }
        }
        static void ShowTeacher(List<Teacher> teacher_list)
        {
            Console.WriteLine("First|\tLast name|Age|\tGender|\tFaculty|Experience|Vacation|Name subject");
            foreach (Teacher teach in teacher_list)
            {
                Console.WriteLine(teach.ReturnPerson());
            }
        }
        static void ShowSubject(List<Subject> subject_list)
        {
            Console.WriteLine("Name|Grade");
            foreach (Subject item in subject_list)
            {
                item.Info();
            }
        }
    }
}
