//Intro();
string sentence = "My name is Yakup";

var result = sentence.Length;
var result2 = sentence.Clone();
bool result3 = sentence.EndsWith("ğ");
bool result4 = sentence.StartsWith("My Name");
var result5 = sentence.IndexOf("namee");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello ");
var result9 = sentence.Substring(0, 2);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(0, 1);


sentence = "My Name is Yılmaz";
Console.WriteLine(result);
Console.WriteLine(result2);


static void Intro()
{
    string city = "Ankara";
    Console.WriteLine(city[0]);
    foreach (var item in city)
    {
        Console.WriteLine(item);
    }
    string city2 = "İstanbul";
    string result = city + city2;
    Console.WriteLine(result);
    Console.WriteLine(String.Format("{0} {1}", city, city2));
}