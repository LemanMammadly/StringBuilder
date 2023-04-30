using System.Globalization;
using System.Text;
using myApp.Builder;

CustomBuilder cb = new CustomBuilder();

Console.WriteLine(cb.Length);
Console.WriteLine(cb.Capacity);

cb.Append('a');
cb.Append('b');
cb.Append('c');
cb.Replace('a', 'd');

Console.WriteLine(cb.Length);
Console.WriteLine(cb.Capacity);


Console.WriteLine(cb.ToString());




