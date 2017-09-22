using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday}

    public class ProgramTester
    {
        static void Main(string[] args)
        {
            // course0_lec0
            List<Day> day_s0 = new List<Day>{ Day.Monday, Day.Wednesday };
            Lecture s0 = new Lecture("101", new TimeSpan(16,0,0), new TimeSpan(17,30,0), day_s0);

            // course0_lec1
            List<Day> day_s1 = new List<Day> { Day.Monday, Day.Wednesday };
            Lecture s1 = new Lecture("102", new TimeSpan(10,0,0), new TimeSpan(11,30,0), day_s1);

            // course0_lec2
            List<Day> day_s2 = new List<Day> { Day.Monday, Day.Wednesday };
            Lecture s2 = new Lecture("103", new TimeSpan(11,30,0), new TimeSpan(13,0,0), day_s2);

            // test3
            //Console.WriteLine("\nTest3");

            // list of sections
            List<Lecture> lectures = new List<Lecture> { s0, s1, s2 };
            // Course0
            Course c0 = new Course("COMM", 292, 1, 2017);
            c0.SetLectures(lectures);

            // constructing course1
            // course1_lec0
            List<Day> day_s4 = new List<Day> { Day.Tuesday, Day.Thursday };
            Lecture s4 = new Lecture("101", new TimeSpan(12, 30, 0), new TimeSpan(14, 0, 0), day_s4);

            // course1_lec1
            List<Day> day_s5 = new List<Day> { Day.Tuesday, Day.Thursday };
            Lecture s5 = new Lecture("102", new TimeSpan(9, 30, 0), new TimeSpan(11, 0, 0), day_s5);

            // course1_lab0
            List<Day> day_s6 = new List<Day> { Day.Friday };
            Lab s6 = new Lab("L1A", new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0), day_s6);

            // course1_lab1
            List<Day> day_s7 = new List<Day> { Day.Wednesday };
            Lab s7 = new Lab("L1B", new TimeSpan(11, 0, 0), new TimeSpan(13, 0, 0), day_s7);

            // course1_lab2
            List<Day> day_s23 = new List<Day> { Day.Wednesday };
            Lab s23 = new Lab("L1C", new TimeSpan(15, 0, 0), new TimeSpan(17, 0, 0), day_s23);

            // course1_lab3
            List<Day> day_s24 = new List<Day> { Day.Wednesday };
            Lab s24 = new Lab("L1D", new TimeSpan(13, 0, 0), new TimeSpan(15, 0, 0), day_s24);

            // course1_lab4
            List<Day> day_s25 = new List<Day> { Day.Tuesday };
            Lab s25 = new Lab("L1E", new TimeSpan(17, 0, 0), new TimeSpan(19, 0, 0), day_s25);

            // course1_lab5
            List<Day> day_s26 = new List<Day> { Day.Thursday };
            Lab s26 = new Lab("L1F", new TimeSpan(14, 0, 0), new TimeSpan(16, 0, 0), day_s26);

            // course1_lab6
            List<Day> day_s27 = new List<Day> { Day.Thursday };
            Lab s27 = new Lab("L1G", new TimeSpan(10, 30, 0), new TimeSpan(12, 30, 0), day_s27);

            // course1_lab7
            List<Day> day_s28 = new List<Day> { Day.Wednesday };
            Lab s28 = new Lab("L1H", new TimeSpan(9, 0, 0), new TimeSpan(11, 0, 0), day_s28);

            // course1_lab8
            List<Day> day_s29 = new List<Day> { Day.Thursday };
            Lab s29 = new Lab("L1J", new TimeSpan(17, 0, 0), new TimeSpan(19, 0, 0), day_s29);

            // course1_lab9
            List<Day> day_s30 = new List<Day> { Day.Friday };
            Lab s30 = new Lab("L1K", new TimeSpan(9, 0, 0), new TimeSpan(11, 0, 0), day_s30);

            // course1_lab10
            List<Day> day_s31 = new List<Day> { Day.Friday };
            Lab s31 = new Lab("L1L", new TimeSpan(11, 0, 0), new TimeSpan(13, 0, 0), day_s31);

            // course1_lab11
            List<Day> day_s32 = new List<Day> { Day.Tuesday };
            Lab s32 = new Lab("L1M", new TimeSpan(15, 30, 0), new TimeSpan(17, 30, 0), day_s32);

            List<Lecture> lectures1 = new List<Lecture> { s4, s5 };
            List<Lab> labs1 = new List<Lab> { s6, s7, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32 };
            Course c1 = new Course("CPSC", 310, 1, 2017);
            c1.SetLabs(labs1);
            c1.SetLectures(lectures1);

            //constructing course2
            // course2_lec0
            List<Day> day_s8 = new List<Day> { Day.Monday, Day.Wednesday};
            Lecture s8 = new Lecture("101", new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0), day_s8);

            // course2_lec1
            List<Day> day_s9 = new List<Day> { Day.Monday, Day.Wednesday };
            Lecture s9 = new Lecture("102", new TimeSpan(10, 0, 0), new TimeSpan(11, 30, 0), day_s9);

            // course2_lec2
            List<Day> day_sa = new List<Day> { Day.Monday, Day.Wednesday };
            Lecture sa = new Lecture("103", new TimeSpan(11, 30, 0), new TimeSpan(13, 0, 0), day_sa);

            // course2_lec3
            List<Day> day_s11 = new List<Day> { Day.Monday, Day.Wednesday };
            Lecture s11 = new Lecture("104", new TimeSpan(13, 00, 0), new TimeSpan(14, 30, 0), day_s11);

            // lec4
            List<Day> day_s17 = new List<Day> { Day.Monday, Day.Wednesday };
            Lecture s17 = new Lecture("105", new TimeSpan(14, 30, 0), new TimeSpan(16, 0, 0), day_s17);

            // course2_lec5
            List<Day> day_s18 = new List<Day> { Day.Monday, Day.Wednesday };
            Lecture s18 = new Lecture("106", new TimeSpan(16, 0, 0), new TimeSpan(17, 30, 0), day_s18);

            // course2_lec6
            List<Day> day_s19 = new List<Day> { Day.Tuesday, Day.Thursday };
            Lecture s19 = new Lecture("107", new TimeSpan(11, 00, 0), new TimeSpan(12, 30, 0), day_s19);

            // list of sections
            List<Lecture> lectures2 = new List<Lecture> { s8, s9, sa, s11, s17, s18, s19 };
            // Course2
            Course c2 = new Course("COMM", 296, 1, 2017);
            c2.SetLectures(lectures2);

            // constructing course3
            // course3_lec0
            List<Day> day_s12 = new List<Day> { Day.Tuesday, Day.Thursday };
            Lecture s12 = new Lecture("101", new TimeSpan(9, 30, 0), new TimeSpan(11, 0, 0), day_s12);

            // course3_lab0
            List<Day> day_s13 = new List<Day> { Day.Wednesday};
            Tutorial s13 = new Tutorial("T1A", new TimeSpan(12, 0, 0), new TimeSpan(13, 0, 0), day_s13);

            // course3_lab1
            List<Day> day_s14 = new List<Day> { Day.Wednesday};
            Tutorial s14 = new Tutorial("T1B", new TimeSpan(13, 0, 0), new TimeSpan(14, 0, 0), day_s14);

            // course3_lab2
            List<Day> day_s15 = new List<Day> { Day.Tuesday };
            Tutorial s15 = new Tutorial("T1C", new TimeSpan(13, 0, 0), new TimeSpan(14, 0, 0), day_s15);

            // course3_lab3
            List<Day> day_s16 = new List<Day> { Day.Tuesday };
            Tutorial s16 = new Tutorial("T1D", new TimeSpan(14, 0, 0), new TimeSpan(15, 0, 0), day_s16);
            /*int[] s16_days = s16.GetIntDays();
            Console.WriteLine("print int array days");
            foreach (var i in s16_days)
                Console.Write(i.ToString());
            Console.WriteLine("\nprint schedule");
            s16.GetSchedule().PrintSchedule();*/

            // course3_lab4
            List<Day> day_s20 = new List<Day> { Day.Wednesday };
            Tutorial s20 = new Tutorial("T1E", new TimeSpan(16, 0, 0), new TimeSpan(17, 0, 0), day_s20);

            // course3_lab5
            List<Day> day_s21 = new List<Day> { Day.Wednesday };
            Tutorial s21 = new Tutorial("T1G", new TimeSpan(11, 0, 0), new TimeSpan(12, 0, 0), day_s21);

            // course3_lab6
            List<Day> day_s22 = new List<Day> { Day.Friday };
            Tutorial s22 = new Tutorial("T1H", new TimeSpan(12, 0, 0), new TimeSpan(13, 0, 0), day_s22);

            List<Lecture> lectures3 = new List<Lecture> { s12 };
            List<Tutorial> tutorials3 = new List<Tutorial> { s13, s14, s15, s16, s20, s21, s22 };
            Course c3 = new Course("CPSC", 304, 1, 2017);
            c3.SetTutorials(tutorials3);
            c3.SetLectures(lectures3);

            //constructing course4
            // course4_lec0
            List<Day> day_s33 = new List<Day> { Day.Monday };
            Lecture s33 = new Lecture("101", new TimeSpan(16, 0, 0), new TimeSpan(17, 0, 0), day_s33);

            // course4_lec1
            List<Day> day_s34 = new List<Day> { Day.Wednesday };
            Lecture s34 = new Lecture("102", new TimeSpan(16, 0, 0), new TimeSpan(17, 0, 0), day_s34);

            // course4_lec2
            List<Day> day_s35 = new List<Day> { Day.Friday };
            Lecture s35 = new Lecture("103", new TimeSpan(13, 0, 0), new TimeSpan(14, 0, 0), day_s35);

            // course4_lec3
            List<Day> day_s36 = new List<Day> { Day.Friday };
            Lecture s36 = new Lecture("104", new TimeSpan(14, 00, 0), new TimeSpan(15, 0, 0), day_s36);

            List<Lecture> lectures4 = new List<Lecture> { s33, s34, s35, s36 };
            //List<Lab> labs4 = new List<Lab> { s13, s14, s15, s16, s20, s21, s22 };
            Course c4 = new Course("COMM", 202, 1, 2017);
            //c4.SetLabs(labs4);
            c4.SetLectures(lectures4);

            // main test
            SolutionMaker.course_list.Add(c0);
            SolutionMaker.course_list.Add(c1);
            SolutionMaker.course_list.Add(c2);
            SolutionMaker.course_list.Add(c3);
            SolutionMaker.course_list.Add(c4);

            // set filters
            // test validity; throw exception
            SolutionMaker.time_range_froms = new List<TimeSpan> { new TimeSpan(9, 0, 0), new TimeSpan(9, 0, 0) , new TimeSpan(9, 0, 0) , new TimeSpan(9, 0, 0) , new TimeSpan(9, 0, 0) };
            SolutionMaker.time_range_tos = new List<TimeSpan> { new TimeSpan(17, 0, 0), new TimeSpan(17, 0, 0) , new TimeSpan(17, 0, 0) , new TimeSpan(17, 0, 0) , new TimeSpan(17, 0, 0)};
            SolutionMaker.lunch_break_froms = new List<TimeSpan> { new TimeSpan(12, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(12, 0, 0) };
            SolutionMaker.lunch_break_tos = new List<TimeSpan> { new TimeSpan(12, 30, 0), new TimeSpan(12, 30, 0), new TimeSpan(12, 30, 0), new TimeSpan(12, 30, 0), new TimeSpan(12, 30, 0) };

            SolutionMaker.leave_out_labs = true;
            SolutionMaker.leave_out_tutorials = true;

            SolutionMaker.MakeSolution();

            int index = SolutionMaker.solution_q.Count;
            Console.WriteLine("Course list: ");
            foreach (Course course in SolutionMaker.course_list)
            {
                Console.WriteLine(course.GetSub() + " " + course.GetID() + " is consist of " + course.GetLectures().Count + 
                    " lectures, " + course.GetLabs().Count + " labs and " + course.GetTutorials().Count + " tutorials");
            }
            Console.WriteLine("\nChecking filters...");
            /*if (time_range_from.TotalMinutes == 0 && time_range_to.TotalMinutes == 0)
                Console.WriteLine("No time range restriction");
            else Console.WriteLine("Time restricted from "+ time_range_from.ToString() + " to "+time_range_to.ToString());

            if (break_from.TotalMinutes == 0 && break_to.TotalMinutes == 0)
                Console.WriteLine("No lunch break restriction.");
            else Console.WriteLine("Break restricted from " + break_from.ToString() + " to " + break_to.ToString());
            */

            if (SolutionMaker.leave_out_labs) Console.WriteLine("Leave out labs.");
            if (SolutionMaker.leave_out_tutorials) Console.WriteLine("Leave out tutorials");

            Console.WriteLine("\nTotal number of feasible solutions: {0}",index);
            Console.WriteLine("Print all temporary schedules: \n");
            for (int i = 0; i < index ; i++)
            {
                TimeTableSolution s = (TimeTableSolution)SolutionMaker.solution_q.Dequeue();
                Console.WriteLine("Solution {0}:", i + 1);
                s.GetTempSchedule().PrintSchedule();
                foreach (Section sec in s.GetSectionList())
                    Console.WriteLine("{0} {1} {2}", sec.GetSub(), sec.GetCourseID(), sec.GetSectionID());
                Console.WriteLine();
            }

            if (index == 0) Console.WriteLine("No feasible solutions available!");

            Console.ReadKey();
        }
    }
}
