using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string pattern = @"^[\D]*(1|[\D]*)[\D]*([2-9]\d{2})[\D]*([2-9]\d{2})[\D]*(\d{4})[\D]*$";
        
        Match match = Regex.Match(phoneNumber, pattern);
        
        if (!match.Success) throw new ArgumentException("Invalid number", nameof(phoneNumber));
        
        return $"{match.Groups[2]}{match.Groups[3]}{match.Groups[4]}";
    }
        
    
}