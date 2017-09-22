using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class ScheduleFilter
    {
        private List<TimeSpan> froms;
        private List<TimeSpan> tos;
        private int list_len = 5;

        private Schedule schedule_filter;

        public ScheduleFilter(List<TimeSpan> tls_from, List<TimeSpan> tls_to)
        {
            froms = tls_from;
            tos = tls_to;
            // build the schedule
            schedule_filter = new Schedule();
            BuildFilter();
        }

        public List<TimeSpan> GetFromTimeSpans() { return froms; }
        public List<TimeSpan> GetToTimeSpans() { return tos; }
        public Schedule GetSchedule() { return schedule_filter; }
        protected void BuildFilter()
        {
            if (froms.Count != tos.Count && froms.Count != list_len) throw new Exception("Invalid time list");

            for (int i = 0; i < froms.Count; i++)
            {
                Schedule temp = new Schedule(froms[i], tos[i], BuildDayList(i));
                schedule_filter = schedule_filter.CombineWith(temp);
            }
        }
        protected int[] BuildDayList(int i)
        {
            int[] temp = new int[5];
            temp[i] = 1;
            return temp;
        }
    }
}
