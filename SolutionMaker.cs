using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class SolutionMaker
    {
        // user inputs
        // grab the courses from sql according to the input subject, course id, section id (if available)
        public static List<Course> course_list = new List<Course> { };
        // should check the validity of inputs; if invalid, throw exception

        public static List<TimeSpan> time_range_froms;
        public static List<TimeSpan> time_range_tos;
        public static List<TimeSpan> lunch_break_froms;
        public static List<TimeSpan> lunch_break_tos;
        public static bool leave_out_labs;
        public static bool leave_out_tutorials;

        public static List<Course> course_w_labs = new List<Course> { };
        public static Queue solution_q = new Queue();
        public static int count;

        static void MakeSolutionDel(List<Section> section_list)
        {
            if (section_list.Count != 0)
            {
                int soln_num = solution_q.Count;
                for (int i = 0; i < soln_num; i++)
                {
                    TimeTableSolution pop_soln = (TimeTableSolution)solution_q.Dequeue();
                    List<Section> soln_sections = pop_soln.GetSectionList();
                    List<Section> course_sections = section_list;

                    foreach (Section sec in course_sections)
                    {
                        //soln_sections.Add(sec);
                        List<Section> temp_list = new List<Section> { };
                        foreach (Section sect in soln_sections)
                            temp_list.Add(sect);
                        TimeTableSolution new_soln = new TimeTableSolution(count, temp_list);
                        new_soln.AddSection(sec);

                        new_soln.BuildTempSolution();
                        if (new_soln.IsValid() && new_soln.GetTempSchedule().TimeRangeFilterChecker(time_range_froms, time_range_tos)
                        && new_soln.GetTempSchedule().LunchBreakFilterChecker(lunch_break_froms, lunch_break_tos))
                        {
                            solution_q.Enqueue(new_soln);
                            count++;
                        }
                    }
                }
            }
        }
        public static void MakeSolution()
        {
            count = 0;
            foreach (Course c in course_list)
            {
                if (count == 0)
                {
                    foreach (Section s in c.GetLectures())
                    {
                        TimeTableSolution soln = new TimeTableSolution(count, s);
                        count++;
                        solution_q.Enqueue(soln);
                    }
                    if (!leave_out_labs)
                        MakeSolutionDel(c.GetLabs().Cast<Section>().ToList());
                    if (!leave_out_tutorials)
                        MakeSolutionDel(c.GetTutorials().Cast<Section>().ToList());
                }
                else
                {
                    MakeSolutionDel(c.GetLectures().Cast<Section>().ToList());
                    if (!leave_out_labs)
                        MakeSolutionDel(c.GetLabs().Cast<Section>().ToList());
                    if (!leave_out_tutorials)
                        MakeSolutionDel(c.GetTutorials().Cast<Section>().ToList());
                }
            }
        }
    }
}
