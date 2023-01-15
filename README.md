# UsefulDotNetExtensions
Class library that contains useful C# extensions

## String extension examples

    string value = "Test".Value(); // will simply return the value "Test"

    string? test = null;
    string value = test.Value(); // will return an empty string

    bool hasValue = "Test".HasValue(); // returns true if string is not null

    bool hasActualValue = "Test".HasActualValue(); // returns true if string is not null, empty or whitespace

    Stream stream = "Test".AsStream(Encoding.UTF8); // converts a string to a stream

## DateTime extension examples

    var dateTime = DateTime.UtcNow.SubtractMicroseconds(300);

    var dateTime = DateTime.UtcNow.SubstractMilliseconds(300);

    var dateTime = DateTime.UtcNow.SubstractSeconds(300);

    var dateTime = DateTime.UtcNow.SubtractMinutes(300);

    var dateTime = DateTime.UtcNow.SubtractHours(300);

    var dateTime = DateTime.UtcNow.SubtractDays(300);

    var dateTime = DateTime.UtcNow.SubtractMonths(300);

    var dateTime = DateTime.UtcNow.SubtractYears(300);

    var dateTimeUtcNow = DateTime.UtcNow;
    var dateTimeWithAddedSeconds = DateTime.UtcNow.AddMilliseconds(100);
    var result = dateTimeUtcNow.CompareToSecond(dateTimeWithAddedSeconds); // will result in true, if 100 milliseconds will not bump up the second

    var result = dateTimeUtcNow.CompareToMillisecond(...);

    var result = dateTimeUtcNow.CompareToMicrosecond(...);

## Number extension examples

    int? value = null;
    int nonNullableInteger = value.Value(); // will return zero

    double value = double.NaN;
    double nonNaNDouble = value.Value(); // will return zero
    // also works with long, ulong, float

    double? value = null;
    bool hasValue = value.HasValue(); // will return false if a number type is either null or NaN

    double value = 0;
    bool hasActualValue = value.HasActualValue(); // will return false if the number type is either zero, null or NaN

## Stream extension examples

    var stream = new MemoryStream(Encoding.UTF8.GetBytes("Test"));
    var readStream = stream.ReadToEnd(Encoding.UTF8);

## Iterator extension examples

    var array = new TestObject[] { ..., ..., ... };
    array.ForEach(x => x.DoSomething());

    var array = new TestObject[] { ..., ..., ... };
    var iEnumerable = array.OrderBy(x => x.Property);
    iEnumerable.ForEach(x => x.DoSomething());
