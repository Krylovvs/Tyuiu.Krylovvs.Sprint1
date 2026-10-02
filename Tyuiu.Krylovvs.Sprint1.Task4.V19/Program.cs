using System.Text;
using Tyuiu.Krylovvs.Sprint1.Task4.V19.Lib;

string PlaceHolder1 = "Num1 = 0.230f";
DataService Examp = new DataService();
float Num1 = 1.0f;
float Num2 = 1.0f;
double Res = Examp.Calculate(Num1, Num2);


Console.Title = "Спринт #1 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"Content\Epilog.txt", Encoding.UTF8);

var Outer = Text.Replace("{{ENTER_DATA1_ARRAY}}", string.Join(", ", PlaceHolder1))
    .Replace("{{OUT_DATA_ARRAY}}", string.Join(", ", Res));

Console.WriteLine(Outer);
Console.ReadKey();
