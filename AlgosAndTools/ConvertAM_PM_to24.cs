using System;

namespace ConsoleApp1
{
    internal class ConvertAM_PM_to24
    {
        private string ConvertAMPMto24(string s)
        {
            DateTime dt;

            if (DateTime.TryParse(s, out dt))
                return dt.ToString("HH:mm:ss");
            throw new Exception("Not valid date passed");
        }
    }
}