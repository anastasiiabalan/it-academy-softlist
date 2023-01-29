using System;
using System.Collections.Generic;
using System.Text;

namespace Finaly_4_Balan_Anastasiia
{
    abstract class Person
    {
        protected string first_name;
        protected string last_name;
        protected int age;
        protected string gender;
        protected string university;
        protected string faculty;

        int min_age = 18;
        /// <summary>
        /// The method receives and returns the name of the person.
        /// </summary>
        public string FirstName
        {
            set { first_name = value; }
            get { return first_name; }
        }
        /// <summary>
        /// The method receives and returns the surname of the person.
        /// </summary>
        public string LastName
        {
            set { last_name = value; }
            get { return last_name; }
        }
        /// <summary>
        /// The method receives and returns the age of the person.
        /// </summary>
        public int Age
        {
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = min_age;
                }
            }
            get { return age; }
        }
        /// <summary>
        /// The method receives and returns the gender of the person.
        /// </summary>
        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        /// <summary>
        /// The method receives and returns the university of the person.
        /// </summary>
        public string University
        {
            set { university = value; }
            get { return university; }
        }
        /// <summary>
        /// The method receives and returns the faculty of the person.
        /// </summary>
        public string Faculty
        {
            set { faculty = value; }
            get { return faculty; }
        }
        /// <summary>
        /// This is a constructor which assigns the first_name, last_name, age, gender, university, faculty of the person.
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="last_name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="university"></param>
        /// <param name="faculty"></param>
        public Person(string first_name, string last_name, int age, string gender, string university, string faculty)
        {
            FirstName = first_name;
            LastName = last_name;
            Age = age;
            Gender = gender;
            University = university;
            Faculty = faculty;
        }
        /// <summary>
        /// The method which additionally all personal data in one variable "inform"
        /// </summary>
        /// <returns>Return the all information about person.</returns>
        public abstract string ReturnPerson();
        /// <summary>
        /// The method which calculates what amount a person receives or pays during training.
        /// </summary>
        public abstract void Pay();
       /// <summary>
       /// The method write number of person.
       /// </summary>
        public abstract void AddPerson();


    }
}
