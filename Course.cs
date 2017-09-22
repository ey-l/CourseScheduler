using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Course
    {
        private string subject;
        private int courseID;
        private List<Lecture> lecture_sections;
        private List<Lab> lab_sections;
        private List<Tutorial> tutorial_sections;
        private int term, year;

        public Course(string sub, int id, int term, int year)
        {
            subject = sub;
            courseID = id;
            this.term = term;
            this.year = year;
            lecture_sections = new List<Lecture> { };
            lab_sections = new List<Lab> { };
            tutorial_sections = new List<Tutorial> { };
        }

        public void SetLectures(List<Lecture> lls)
        {
            this.lecture_sections = lls;
            foreach (Lecture l in lecture_sections) {
                l.SetCourseID(courseID);
                l.SetSubject(subject);
            }
        }
        public void SetLabs(List<Lab> lls)
        {
            this.lab_sections = lls;
            foreach (Lab l in lab_sections)
            {
                l.SetCourseID(courseID);
                l.SetSubject(subject);
            }
        }
        public void SetTutorials(List<Tutorial> tls)
        {
            this.tutorial_sections = tls;
            foreach (Tutorial t in tutorial_sections)
            {
                t.SetCourseID(courseID);
                t.SetSubject(subject);
            }
        }
        public List<Lecture> GetLectures() { return lecture_sections; }
        public List<Lab> GetLabs() { return lab_sections; }
        public List<Tutorial> GetTutorials() { return tutorial_sections; }
        public int GetID() { return courseID; }
        public string GetSub() { return subject; }
        public int GetTerm() { return term; }
        public int GetYear() { return year; }
    }
}
