﻿using System;
using System.Globalization;

namespace LocationTracker.Utils
{
    public class DateFunctions
    {
        /// <summary>
        /// Parse a dd-MM-yyyy input date or return a given default or today
        /// </summary>
        /// <param name="date"></param>
        /// <param name="defaultDate"></param>
        /// <returns></returns>
        public static DateTime GetDate(string date = "", DateTime? defaultDate = null)
        {
            if (string.IsNullOrEmpty(date) ||
                !(DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime _date)))
            {
                _date = defaultDate ?? DateTime.Now.Date;
            }

            return _date;
        }
    }
}
