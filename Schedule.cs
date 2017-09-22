using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Schedule
    {
        private int[][] schedule;
        private string sectionID;
        private int rowNum = 5;
        private int colnNum = 30;
        private TimeSpan start_time_bound = new TimeSpan(7, 0, 0);
        private TimeSpan end_time_bound = new TimeSpan(22, 0, 0);
        public Schedule()
        {   // initialize a 2-D array with 5 rows (weekdays) and 30 columns
            this.schedule = new int[rowNum][];
            for (int i = 0; i < rowNum; i++)
                this.schedule[i] = new int[colnNum];
        }

        public Schedule(TimeSpan start, TimeSpan end, int[] days)
        {   // map time info onto 2-D array
            this.schedule = new int[rowNum][];
            int startIndex = Math.Abs((int)(start.TotalMinutes - start_time_bound.TotalMinutes) / 30);
            int endIndex = Math.Abs((int)(end.TotalMinutes - start_time_bound.TotalMinutes) / 30);
            //Console.WriteLine(startIndex);
            //Console.WriteLine(endIndex);
            for (int i = 0; i < rowNum; i++)
            {
                this.schedule[i] = new int[colnNum];
                if (days[i] == 1)
                    for (int j = startIndex; j < endIndex; j++)
                        schedule[i][j] = 1;
            }
        }

        public int[][] GetScheduleArray() { return schedule; }
        public string GetSectionID() { return sectionID; }
        public void SetSectionID(string id) { sectionID = id; }

        public bool IsValid()
        {   // return false when conflicts
            for (int row = 0; row < rowNum; row++)
            {
                for (int coln = 0; coln < colnNum; coln++)
                    if (schedule[row][coln] > 1)
                        return false;
            }
            return true;
        }

        public Schedule CombineWith(Schedule sch1)
        {   // combine two schedules, return the combination
            Schedule newSchedule = new Schedule();
            for (int row = 0; row < rowNum; row++)
            {
                for (int coln = 0; coln < colnNum; coln++)
                    newSchedule.GetScheduleArray()[row][coln] = schedule[row][coln] + sch1.GetScheduleArray()[row][coln];
            }
            return newSchedule;
        }

        public void PrintSchedule()
        {
            for (int row = 0; row < rowNum; row++)
            {
                for (int coln = 0; coln < colnNum; coln++)
                    Console.Write(schedule[row][coln]);
                Console.WriteLine();
            }
        }

        public bool TimeRangeFilterChecker(List<TimeSpan> froms, List<TimeSpan> tos)
        {
            TimeRangeFilter filter = new TimeRangeFilter(froms, tos);
            Schedule filter_schedule = filter.GetSchedule();

            for (int i = 0; i < rowNum; i++)
                for (int j = 0; j < colnNum; j++)
                    if (schedule[i][j] != 0 && filter_schedule.schedule[i][j] == 0)
                        return false;

            return true;
        }
        public bool LunchBreakFilterChecker(List<TimeSpan> froms, List<TimeSpan> tos)
        {
            LunchBreakFilter filter = new LunchBreakFilter(froms, tos);
            Schedule filter_schedule = filter.GetSchedule();

            for (int i = 0; i < rowNum; i++)
                for (int j = 0; j < colnNum; j++)
                    if (schedule[i][j] != 0 && filter_schedule.schedule[i][j] != 0)
                        return false;

            return true;
        }
    }
}
