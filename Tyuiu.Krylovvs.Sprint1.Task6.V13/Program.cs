using System.Text;
using Tyuiu.Krylovvs.Sprint1.Task6.V13.Lib;

string PlaceHolder1 = "abcd";
DataService Examp = new DataService();
string Text1 = "abcd";
bool Res = Examp.Calculate(Text1);


Console.Title = "Спринт #1 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"Content\Epilog.txt", Encoding.UTF8);

var Outer = Text.Replace("{{ENTER_DATA1_ARRAY}}", string.Join(", ", PlaceHolder1))
    .Replace("{{OUT_DATA_ARRAY}}", string.Join(", ", Res));

Console.WriteLine(Outer);
Console.ReadKey();
