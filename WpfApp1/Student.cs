using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Student
    {
        string fullName;
        int age;
        float score;
       
        public Student(string fullName, int age, float score)
        {
            this.fullName = fullName;
            this.age = age;
            this.score = score;
        }

        public string FullName => fullName;
        public int Age => age;
        public float Score => score;

        public bool IsStudy { get;  set; }

        public override string ToString()
        {
            return $"{fullName}; {age}; {score}; {(IsStudy ? "Studying" : "Not Studying")}";
        }

    }
}
