using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DataSource
    {
        private IEnumerable<Student> students;
        public DataSource()
        {
            students = new List<Student> { new Student("Dmitriy",20,11.9f),
                new Student("Javid", 18, 11.999f) { IsStudy = true},
                new Student("Kanan", 19, 11f) { IsStudy = true}
            };
        }

        public IEnumerable<Student> Students => students;

    }
}
