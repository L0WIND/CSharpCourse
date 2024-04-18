#region Array1
//string[] students = new string[3];
//students[0] = "Yakup";
//students[1] = "Yusuf";
//students[2] = "Büşra";

//foreach (string student in students)
//{
//    Console.WriteLine(student);
//}

//string[] students2 = { "Yakup", "Yusuf", "Büşra" };
//students2[3] = "Ahmet";

//for (int i = 0; i < students2.Length; i++)
//{
//    Console.WriteLine(students2[i]);
//}
#endregion




string[,] regions = new string[5, 3]
{
    { "İstanbul", "İzmit", "Balıkesir" },
    { "Ankara", "Konya", "Kurıkkale" },
    { "Antalya", "Adana", "Mersin" },
    { "Rize", "Trabzon", "Samsun" },
    { "İzmir", "Muğla", "Manisa" }
};

for (int i = 0;i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("********");
}
