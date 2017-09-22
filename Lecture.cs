using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Lecture : Section
    {
        public Lecture(string id, TimeSpan start, TimeSpan end, List<Day> days) : base(id, start, end, days) { }
    }
}
