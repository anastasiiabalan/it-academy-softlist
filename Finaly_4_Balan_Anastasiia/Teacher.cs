using System;
using System.Collections.Generic;
using System.Text;
using static Finaly_4_Balan_Anastasiia.Program;

namespace Finaly_4_Balan_Anastasiia
{
    class Teacher : Person
    {
        /// <summary>
        /// The method which creates a new event handler.
        /// </summary>
        public event MyDelegate1 Notify;

        int experience;
        bool vacation_year;
        string name_subject;

        int min_experience = 1;
        static int count_teacher = 0;
        /// <summary>
        /// The method receives and gives the name of the subject taught by the teacher.
        /// </summary>
        public int Experience
        {
            set
            {
                if (value > 0)
                {
                    experience = value;
                }
                else
                {
                    experience = min_experience;
                }
            }
            get { return experience; }
        }
        /// <summary>
        /// The method receives and gives the name of the teacher
        /// </summary>
        public bool VacationYear
        {
            set { vacation_year = value; }
            get { return vacation_year; }
        }
        /// <summary>
        /// The method receives and gives the name of the subject taught by the teacher.
        /// </summary>
        public string NameSubject
        {
            set { name_subject = value; }
            get { return name_subject; }
        }
        /// <summary>
        /// This is a constructor which assigns the first_name, last_name, age, gender, university, faculty,experience,vacation_year,name_subject of the teacher.
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="last_name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="university"></param>
        /// <param name="faculty"></param>
        /// <param name="experience"></param>
        /// <param name="vacation_year"></param>
        /// <param name="name_subject"></param>
        public Teacher(string first_name, string last_name, int age, string gender,string university, string faculty,int experience,  bool vacation_year, string name_subject) :base(first_name,last_name,age,gender, university,faculty)
        {
            Experience = experience;
            VacationYear = vacation_year;
            NameSubject = name_subject;
            count_teacher++;
        }
        /// <summary>
        /// The method writes the role of the teacher at the university.
        /// </summary>
        public void RoleStuding()
        {
            Console.WriteLine("A teacher is a person who conducts educational, methodical scientific activities");
        }
        /// <summary>
        /// The method which additionally all personal data in one variable "inform"
        /// </summary>
        /// <returns>Return the all information about teacher.</returns>
        public override string ReturnPerson()
        {
            string inform = first_name + "\t" + last_name + "\t" + age + "\t" + gender + "\t" + university + "\t" + faculty + "\t" + experience + "\t" + vacation_year + "\t" + name_subject;
            return inform;
        }
        /// <summary>
        /// The method which calculates which salary get the teacher.
        /// </summary>
        public override void Pay()
        {
            double salary = 2000 * experience*0.3;
            if (vacation_year)
            {
                Console.WriteLine($"Teacher {FirstName} {LastName} received a salary = {salary} grn. The teacher was already on vacation this year");
            }
            else
            {
                Console.WriteLine($"Teacher {FirstName} {LastName} received a salary= {salary} grn. The teacher has not been on vacation this year");
            }
        }
        /// <summary>
        /// The method write number of teacher.
        /// </summary>
        public override void AddPerson()
        {
            Notify?.Invoke($"Count teacher={count_teacher}");
        }
    }
}
