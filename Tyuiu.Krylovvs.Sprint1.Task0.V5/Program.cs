using System.Text;
using Tyuiu.Krylovvs.Sprint1.Task0.V5.Lib;


string PlaceHolder1 = "(1+2)*(1+9/3)";
DataService Examp = new DataService();
int Res = Examp.Calculate();


Console.Title = "Спринт #1 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"Content\Epilog.txt", Encoding.UTF8);

var Outer = Text.Replace("{{ENTER_DATA1_ARRAY}}", string.Join(", ", PlaceHolder1))
    .Replace("{{OUT_DATA_ARRAY}}", string.Join(", ", Res));

Console.WriteLine(Outer);
Console.ReadKey();
