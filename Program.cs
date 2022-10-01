using System.Globalization;
using static System.Console;
using System.Text;
internal class Program
{
     private static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        double moeda = 1234567.9;
        sb.AppendFormat(moeda.ToString("C", CultureInfo.CurrentCulture));
        sb.AppendLine();
        sb.AppendFormat(moeda.ToString("C3", CultureInfo.CreateSpecificCulture("pt-br")));
        Console.WriteLine(sb.ToString());
    }
}