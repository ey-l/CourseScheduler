using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Subject
    {
        private string name;
        private List<Course> course_list;

        // constructor w & w/o course_list
        public Subject(string name)
        {
            this.name = name;
            course_list = new List<Course> { };
        }
        public Subject(string name, List<Course> cls)
        {
            this.name = name;
            course_list = cls;
        }
        // append one course to course_list
        public void AddCourse(Course c) { course_list.Add(c); }
        // a bunch of getters and setters
        public string GetName() { return name; }
        public List<Course> GetCourseList() { return course_list; }
        public void SetCourseList(List<Course> cl) { course_list = cl; }
    }
}
