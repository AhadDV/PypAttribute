
using System.Text.RegularExpressions;

public class Email : Attribute
{
    public void Check(string? email)
    {
        if (email == null)
        {
            Console.WriteLine("data vcan not null");
            return;
        }


        Regex regex = new Regex(@"^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}");
        Match match = regex.Match(email);
        if (!match.Success)
            Console.WriteLine("Email is not valid");
    }
}
