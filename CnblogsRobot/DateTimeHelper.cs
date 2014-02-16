/*
 *  Description：DateTime工具类
 *  Author: FrankFan
 *  Email:fanyong@gmail.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnblogsRobot
{
    public class DateTimeHelper
    {
        public string ConvertToTimeStamp(DateTime dt)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (dt.Ticks - dtStart.Ticks) / 1000;

            return t.ToString();
        }
    }
}
