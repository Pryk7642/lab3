using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WinFormsApp7777
{
    internal class Class1
    {

        public string Name
        {
            get;set;
        }

        public string Student_id
        {
            get; set;
        }

        public string Year_of_birth
        {
            get; set;
        }

        public string Height
        {
            get; set;
        }

        public double Grade
        {
            get; set;
        }

        public string Branch
        {
            get; set;
        }

        

        public Class1(string name, string student_id, string year, string height,double grade, string branch) 
        {
            Name = name;
            Student_id = student_id;
            Year_of_birth = year;
            Height = height;
            Grade = grade;
            Branch = branch;

        }
    }
}
