using System;
using System.Collections.Generic;
using System.Text;
using static Finaly_4_Balan_Anastasiia.Program;

namespace Finaly_4_Balan_Anastasiia
{

    class Student : Person, IRoleStuding
    {
        /// <summary>
        /// 
        /// </summary>
        public event MyDelegate1 Notify;
        /// <summary>
        /// 
        /// </summary>
        public Subject subject;

        int course;
        string group;
        bool form_study;
        int min_course = 1;
        static int count_student=0;
        /// <summary>
        /// The method receives and gives the student a cource. 
        /// </summary>
        public int Course
        {
            set
            {
                if (value > 0)
                {
                    course = value;
                }
                else
                {
                    course = min_course;
                }
            }
            get { return course; }
        }
        /// <summary>
        /// The method receives and gives the student a group. 
        /// </summary>
        public string Group
        {
            set { group = value; }
            get { return group; }
        }
        /// <summary>
        /// The method receives and gives the student a form_study. 
        /// </summary>
        public bool FormStudy
        {
            set { form_study = value; }
            get { return form_study; }
        }
        /// <summary>
        /// This is a constructor which assigns the first_name, last_name, age, gender, university, faculty,course,group,form_study of the student.
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="last_name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="university"></param>
        /// <param name="faculty"></param>
        /// <param name="course"></param>
        /// <param name="group"></param>
        /// <param name="form_study"></param>
        public Student(string first_name, string last_name, int age, string gender, string university, string faculty, int course, string group, bool form_study) : base(first_name, last_name, age, gender, university, faculty)
        {
            Course = course;
            Group = group;
            FormStudy = form_study;
            count_student++;
        }
        /// <summary>
        /// The method receives and gives the student a cource. 
        /// </summary>
        public void RoleStuding()
        {
            Console.WriteLine("A student is a person who is enrolled in a higher education institution and is studying in order to obtain certain educational levels");
        }
        /// <summary>
        /// The method writes the role of the student at the university.
        /// </summary>
        /// <param name="grade1"></param>
        /// <param name="grade2"></param>
        public void AVG(double grade1, double grade2)
        {
            double avg_grade = (grade1 + grade2) / 2.0;
            Console.WriteLine($"Student {FirstName}{LastName}, subject1 = {grade1}, subject2 = {grade2}, AVG = {avg_grade}");
        }

        /// <summary>
        /// The method which additionally all personal data in one variable "inform"
        /// </summary>
        /// <returns>Return the all information about student.</returns>
        public override string ReturnPerson()
        {
            string inform = first_name + "\t" + last_name + "\t" + age + "\t" + gender + "\t" + university + "\t" + faculty + "\t" + course + "\t" + group + "\t" + form_study;
            return inform;
        }
        /// <summary>
        /// The method which calculates which scholarship get the student or which salary student must pay.
        /// </summary>
        public override void Pay()
        {
            int salary = 12000 * course;
            if (form_study)
            {
                Console.WriteLine($"Student {first_name} {last_name} received a scholarship = {salary} grn for 1 year");
            }
            else
            {
                Console.WriteLine($"Student {first_name} {last_name} paid = {salary} grn for 1 year");
            }
        }
        /// <summary>
        /// The method write number of student.
        /// </summary>
        public override void AddPerson()
        {
            Notify?.Invoke($"Count student={count_student}");
        }

    }
}
