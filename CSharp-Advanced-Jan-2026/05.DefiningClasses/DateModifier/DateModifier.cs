using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime date1;
        private DateTime date2;

        public DateModifier(string date1AsText, string date2AsText)
        {
            date1 = DateTime.Parse(date1AsText);
            date2 = DateTime.Parse(date2AsText);
        }

        public int CaculateDayDiff()
        {
            int diff = (int)Math.Abs((date2 - date1).TotalDays);
            return diff;
        }
    }
}
