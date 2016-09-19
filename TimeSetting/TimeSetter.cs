using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TimeSetting
{
    /// <summary>
    /// Class, which sets the time you specified as parameter in ChangeTime
    /// </summary>
    class TimeSetter
    {
        /// <summary>
        /// Structure of the system time
        /// </summary>
        private struct SYSTEMTIME
        {
            public short Year;
            public short Month;
            public short DayOfWeek;
            public short Day;
            public short Hour;
            public short Minute;
            public short Second;
            public short Milliseconds;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetSystemTime ([In] ref SYSTEMTIME st);

        /// <summary>
        /// Dummy initialization
        /// </summary>
        public TimeSetter ()
        { }

        /// <summary>
        /// Setting the system time
        /// </summary>
        /// <param name="serverTime">Time</param>
        public void ChangeTime (DateTime serverTime)
        {
            SYSTEMTIME s = new SYSTEMTIME();
            DateTime setTime = serverTime.AddHours(-3);
            s.Year = (short)setTime.Year;
            s.Month = (short)setTime.Month;
            s.DayOfWeek = (short)setTime.DayOfWeek;
            s.Day = (short)setTime.Day;
            s.Hour = (short)setTime.Hour;
            s.Minute = (short)setTime.Minute;
            s.Second = (short)setTime.Second;
            s.Milliseconds = (short)setTime.Millisecond;
            SetSystemTime(ref s);
        }
    }
}
