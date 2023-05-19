using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngleCalculator.Clocks
{
    public class Clock : ICLock
    {
        public int Hours { get; }
        public int Minutes { get; }

        public Clock(int hours, int minutes)
        {
            if (hours < 0 || hours > 12 || minutes < 0 || minutes >= 60)
            {
                throw new ArgumentException("Invalid hours or minutes.");
            }

            Hours = hours;
            Minutes = minutes;
        }

        public int CalculateAngle()
        {
            // 1 hour = 30 degrees (360 / 12)
            double hourAngle = 0.5 * (Hours * 60 + Minutes);

            // 1 minute = 6 degrees (360 / 60)
            double minuteAngle = 6 * Minutes;

            // Find the difference between two angles
            int diff = (int)Math.Abs(hourAngle - minuteAngle);
            int angle = Math.Min(360 - diff, diff);

            return angle;
        }
    }
}
