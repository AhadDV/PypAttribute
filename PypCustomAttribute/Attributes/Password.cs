
using System.Text.RegularExpressions;

public class Password : Attribute
{
    public void Check(string? data)
    {
        if (data == null)
        {
            Console.WriteLine("Data can not null");
            return;
        }

        Regex regex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
        Match match = regex.Match(data);

        if (!match.Success)
            Console.WriteLine("Passwor is not walid");

    }


}
