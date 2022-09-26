using System.Text.RegularExpressions;

namespace Framework.LeadsManager.Application
{
    public class ValidationHelper
    {
        public static string EmailRegEx { get; set; } = @"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        public static bool IsValidEmailAddress(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            return Regex.IsMatch(email, EmailRegEx, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }
    }
}