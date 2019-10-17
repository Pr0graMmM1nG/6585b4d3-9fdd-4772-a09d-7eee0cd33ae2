namespace Library
{
    public static class Validation
    {
        public static bool GetString(this string inputString, out string outString)
        {
            var isNullOrEmpty = string.IsNullOrEmpty(inputString);
            var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(inputString);

            if (!isNullOrEmpty && !isNullOrWhiteSpace && inputString.Length > 2)
            {
                outString = inputString;
                return true;
            }
            else
            {
                // MessageBox.Show($"String is fuuuu:","Please enter a value.");
                outString = "";
                return false;

            }
        }
    }
}
