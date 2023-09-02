using System.Text.RegularExpressions;

namespace Validation;

public static class ValidationClass
{
    public static bool Validation(this string str, string regExp)
    {
        var regexp = new Regex(regExp);
        return regexp.IsMatch(str);
    }
}