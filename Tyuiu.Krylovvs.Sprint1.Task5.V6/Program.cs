using System.Text;
using Tyuiu.Krylovvs.Sprint1.Task5.V6.Lib;

string PlaceHolder1 = "Num1 = 61";
DataService Examp = new DataService();
int Num1 = 61;
int Res = 0;
Examp.Calculate(Num1, ref Res);


Console.Title = "Спринт #1 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"Content\Epilog.txt", Encoding.UTF8);

var Outer = Text.Replace("{{ENTER_DATA1_ARRAY}}", string.Join(", ", PlaceHolder1))
    .Replace("{{OUT_DATA_ARRAY}}", string.Join(", ", Res));

Console.WriteLine(Outer);
Console.ReadKey();
