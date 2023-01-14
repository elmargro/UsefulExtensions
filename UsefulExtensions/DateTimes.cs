namespace UsefulExtensions
{
    public static class DateTimes
    {
        /// <summary>
        /// Subtracts the given microseconds from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="microseconds">Microseconds to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted microseconds</returns>
        /// <exception cref="ArgumentException">When microseconds is lower than zero</exception>
        public static DateTime SubtractMicroseconds(this DateTime dateTime, double microseconds)
        {
            if (microseconds < 0)
            {
                throw new ArgumentException($"{nameof(microseconds)} is not allowed to be lower than 0");
            }

            return dateTime.Subtract(TimeSpan.FromMicroseconds(microseconds));
        }

        /// <summary>
        /// Subtracts the given milliseconds from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="milliseconds">Milliseconds to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted milliseconds</returns>
        /// <exception cref="ArgumentException">When milliseconds is lower than zero</exception>
        public static DateTime SubtractMilliseconds(this DateTime dateTime, double milliseconds)
        {
            if (milliseconds < 0)
            {
                throw new ArgumentException($"{nameof(milliseconds)} is not allowed to be lower than 0");
            }

            return dateTime.Subtract(TimeSpan.FromMilliseconds(milliseconds));
        }

        /// <summary>
        /// Subtracts the given seconds from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="seconds">Seconds to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted seconds</returns>
        /// <exception cref="ArgumentException">When seconds is lower than zero</exception>
        public static DateTime SubtractSeconds(this DateTime dateTime, double seconds)
        {
            if (seconds < 0)
            {
                throw new ArgumentException($"{nameof(seconds)} is not allowed to be lower than 0");
            }

            return dateTime.Subtract(TimeSpan.FromSeconds(seconds));
        }

        /// <summary>
        /// Subtracts the given mintes from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="minutes">Minutes to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted minutes</returns>
        /// <exception cref="ArgumentException">When minutes is lower than zero</exception>
        public static DateTime SubtractMinutes(this DateTime dateTime, double minutes)
        {
            if (minutes < 0)
            {
                throw new ArgumentException($"{nameof(minutes)} is not allowed to be lower than 0");
            }

            return dateTime.Subtract(TimeSpan.FromMinutes(minutes));
        }

        /// <summary>
        /// Subtracts the given hours from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="hours">Hours to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted hours</returns>
        /// <exception cref="ArgumentException">When hours is lower than zero</exception>
        public static DateTime SubtractHours(this DateTime dateTime, double hours)
        {
            if (hours < 0)
            {
                throw new ArgumentException($"{nameof(hours)} is not allowed to be lower than 0");
            }

            return dateTime.Subtract(TimeSpan.FromHours(hours));
        }

        /// <summary>
        /// Subtracts the given days from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="days">Days to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted days</returns>
        /// <exception cref="ArgumentException">When days is lower than zero</exception>
        public static DateTime SubtractDays(this DateTime dateTime, double days)
        {
            if (days < 0)
            {
                throw new ArgumentException($"{nameof(days)} is not allowed to be lower than 0");
            }

            return dateTime.Subtract(TimeSpan.FromDays(days));
        }

        /// <summary>
        /// Subtracts the given months from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="months">Months to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted months</returns>
        /// <exception cref="ArgumentException">When months is lower than zero</exception>
        public static DateTime SubtractMonths(this DateTime dateTime, int months)
        {
            if (months < 0)
            {
                throw new ArgumentException($"{nameof(months)} is not allowed to be lower than 0");
            }

            return dateTime.AddMonths(months * -1);
        }

        /// <summary>
        /// Subtracts the given years from the DateTime and returns a new instance
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="years">Years to subtract</param>
        /// <returns>A new instance of <see cref="DateTime"/> with the subtracted years</returns>
        /// <exception cref="ArgumentException">When years is lower than zero</exception>
        public static DateTime SubtractYears(this DateTime dateTime, int years)
        {
            if (years < 0)
            {
                throw new ArgumentException($"{nameof(years)} is not allowed to be lower than 0");
            }

            return dateTime.AddYears(years * -1);
        }

        /// <summary>
        /// Compares two <see cref="DateTime"/>(s) on the basis of the year, month, day, hour, minute and second and ignores the millisecond, microsecond, nanosecond and tick/>
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="value">DateTime to compare to</param>
        /// <returns>True if both <see cref="DateTime"/>(s) are equal up to the second, otherwise false</returns>
        public static bool CompareToSecond(this DateTime dateTime, DateTime value)
        {
            return dateTime.Year == value.Year &&
                   dateTime.Month == value.Month &&
                   dateTime.Day == value.Day &&
                   dateTime.Hour == value.Hour &&
                   dateTime.Minute == value.Minute &&
                   dateTime.Second == value.Second;
        }

        /// <summary>
        /// Compares two <see cref="DateTime"/>(s) on the basis of the year, month, day, hour, minute, second, and millisecond and ignores the microsecond, nanosecond and tick/>
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="value">DateTime to compare to</param>
        /// <returns>True if both <see cref="DateTime"/>(s) are equal up to the millisecond, otherwise false</returns>
        public static bool CompareToMillisecond(this DateTime dateTime, DateTime value)
        {
            return dateTime.Year == value.Year &&
                   dateTime.Month == value.Month &&
                   dateTime.Day == value.Day &&
                   dateTime.Hour == value.Hour &&
                   dateTime.Minute == value.Minute &&
                   dateTime.Second == value.Second &&
                   dateTime.Millisecond == value.Millisecond;
        }

        /// <summary>
        /// Compares two <see cref="DateTime"/>(s) on the basis of the year, month, day, hour, minute, second, millisecond and microsecond and ignores the nanosecond and tick/>
        /// </summary>
        /// <param name="dateTime">Given DateTime</param>
        /// <param name="value">DateTime to compare to</param>
        /// <returns>True if both <see cref="DateTime"/>(s) are equal up to the microsecond, otherwise false</returns>
        public static bool CompareToMicrosecond(this DateTime dateTime, DateTime value)
        {
            return dateTime.Year == value.Year &&
                   dateTime.Month == value.Month &&
                   dateTime.Day == value.Day &&
                   dateTime.Hour == value.Hour &&
                   dateTime.Minute == value.Minute &&
                   dateTime.Second == value.Second &&
                   dateTime.Millisecond == value.Millisecond &&
                   dateTime.Microsecond == value.Microsecond;
        }
    }
}
