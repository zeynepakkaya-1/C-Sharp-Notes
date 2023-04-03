string[] students = new string[3];
students[0] = "Noah";
students[1] = "Olivia";
students[2] = "Amelia";

foreach (string student in students)
{
    Console.WriteLine(student);
}

string[] students2_1 = new[] { "Noah" , "Olivia" , "Amelia" };
string[] students2_2 = { "Noah", "Olivia", "Amelia" };
string[] students2_3 = new string[3] { "Noah", "Olivia", "Amelia" };

string[,] regions = new string[7, 3]
{
    { "İstanbul" , "Bursa" , "Yalova" },
    { "Bolu" , "Samsun" , "Sinop" },
    { "Eskişehir" , "Ankara" , "Sivas" },
    { "Gaziantep" , "Şanlıurfa" , "Diyarbakır" },
    { "İzmir" , "Aydın" , "Muğla" },
    { "Şırnak" , "Hakkari" , "Van" },
    { "Antalya" , "Isparta" , "Hatay" }
};

for(int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for(int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("***");
}