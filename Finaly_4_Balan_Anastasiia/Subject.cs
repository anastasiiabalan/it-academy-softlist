using System;
using System.Collections.Generic;
using System.Text;
using static Finaly_4_Balan_Anastasiia.Program;

namespace Finaly_4_Balan_Anastasiia
{
    class Subject:IRoleStuding
    {
        string name1;
        int grade1;
        int min_grade=50;
        /// <summary>
        ///     The method receives and returns the grade of the subject.
        /// </summary>
        public int Grade1
        {
            set
            {
                if (value > 0)
                {
                    grade1 = value;
                }
                else
                {
                    grade1 = min_grade;
                }
            }
            get { return grade1; }
        }
        /// <summary>
        /// The method receives and returns the name of the subject.
        /// </summary>
        public string Name1
        {
            set { name1 = value; }
            get { return name1; }
        }
        /// <summary>
        /// This is a constructor which assigns the name and grade of the subject.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="grade1"></param>
        public Subject(string name1, int grade1)
        {
            Name1 = name1;
            Grade1 = grade1;
        }
        /// <summary>
        /// The method writes the name and grade of the subject.
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"{name1}\t{grade1}");
        }
        /// <summary>
        /// The method writes the role of the subject at the university.
        /// </summary>
        public void RoleStuding()
        {
            Console.WriteLine("A discipline is a field of knowledge that is taught and researched at the college or university level");
        }    
    }
}
