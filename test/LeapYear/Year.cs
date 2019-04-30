namespace LeapYear
{
    public class Year
    {
        public bool IsLeap(int year)
        {
            return IsTypicalLeap(year) && !IsAtypicalCommon(year);
        }

        private bool IsTypicalLeap(int year)
        {
            return year % 4 == 0;
        }

        private bool IsAtypicalCommon(int year)
        {
            return year % 100 == 0 && !IsAtypicalLeap(year);
        }

        private bool IsAtypicalLeap(int year)
        {
            return year % 400 == 0;
        }
    }
}
