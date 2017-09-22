using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class LunchBreakFilter : ScheduleFilter
    {
        public LunchBreakFilter(List<TimeSpan> tls_from, List<TimeSpan> tls_to) : base(tls_from, tls_to) { }
    }
}
