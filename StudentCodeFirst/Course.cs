using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace StudentCodeFirst
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
