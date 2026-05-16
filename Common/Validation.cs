using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StaffUniformTracker.Common;

public static class Validation
{
    public static bool IsBlank(string? s) => string.IsNullOrWhiteSpace(s);

    public static bool LooksLikeId(string s) =>
        !string.IsNullOrWhiteSpace(s)
        && Regex.IsMatch(s.Trim(), "^[A-Za-z0-9-]{3,12}$");

    public static bool LooksLikeEmail(string s) =>
        string.IsNullOrWhiteSpace(s)
        || Regex.IsMatch(s.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
}

