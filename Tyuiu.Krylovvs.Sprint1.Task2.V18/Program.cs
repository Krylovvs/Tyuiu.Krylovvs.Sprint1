using System.Text;
using Tyuiu.Krylovvs.Sprint1.Task2.V18.Lib;

string PlaceHolder1 = "x = 1, y = 1, a = 1";
DataService Examp = new DataService();
int x = 1, y = 1, a = 1;
int Res = Examp.Calculate(x, y, a);


Console.Title = "Спринт #1 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"Content\Epilog.txt", Encoding.UTF8);

var Outer = Text.Replace("{{ENTER_DATA1_ARRAY}}", string.Join(", ", PlaceHolder1))
    .Replace("{{OUT_DATA_ARRAY}}", string.Join(", ", Res));

Console.WriteLine(Outer);
Console.ReadKey();