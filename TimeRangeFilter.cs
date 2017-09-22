using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class TimeRangeFilter : ScheduleFilter
    {
        public TimeRangeFilter(List<TimeSpan> tls_from, List<TimeSpan> tls_to) : base (tls_from, tls_to) { }
    }
}
