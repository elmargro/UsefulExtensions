namespace UsefulExtensions.Tests.TestHelpers
{
    internal static class Extensions
    {
        internal static bool CompareToMicrosecondExtension(this DateTime dateTime, DateTime value)
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
