namespace Stopwatch
{
    public class Time(string value)
    {
        private readonly string _value = value;

        public int Interval
        {
            get
            {
                var interval = int.Parse(_value[..^1]);

                return interval * Type.GetHashCode();
            }
        }

        public IntervalType Type
        {
            get
            {
                var intervalType = _value.Substring(_value.Length - 1, 1);

                return intervalType switch
                {
                    "s" => IntervalType.Seconds,
                    "m" => IntervalType.Minutes,
                    _ => throw new NotImplementedException(),
                };
            }
        }
    }
}