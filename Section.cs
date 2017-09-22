using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Section
    {
        protected string sectionID;
        protected int courseID;
        protected string subject;
        protected TimeSpan startTime, endTime;
        protected int[] days;
        protected Schedule schedule;

        public Section(string id, TimeSpan start, TimeSpan end, List<Day> days)
        {
            this.sectionID = id;
            this.startTime = start;
            this.endTime = end;
            SectionDaysSetter(days);
            this.schedule = new Schedule(start, end, this.days);
            schedule.SetSectionID(id);
        }

        // transfer Days to int array to indicate days
        protected void SectionDaysSetter(List<Day> days)
        {
            int i = 0, j = 0;
            int len = days.Count;

            this.days = new int[5];
            foreach (Day day in Enum.GetValues(typeof(Day)))
            {
                if (day == days[i])
                {
                    this.days[j] = 1;
                    i++;
                }
                j++;
                if (i >= len) break;
            }
        }

        public Schedule GetSchedule() { return schedule; }
        public string GetSectionID() { return sectionID; }
        public void SetCourseID(int id) { courseID = id; }
        public void SetSubject(string sub) { subject = sub; }
        public int GetCourseID() { return courseID; }
        public int[] GetIntDays() { return days; }
        public string GetSub() { return subject; }
    }
}
