using System;

DateTime data1 = new DateTime(2024, 10, 07, 8, 30, 25);
Console.WriteLine(data1);
string data = "2024-07-01";
DateTime data2 = DateTime.Parse(data);
Console.WriteLine(data2);
DateTime data3 = DateTime.Now;
Console.WriteLine(data3);
Console.WriteLine(data3.Year);
Console.WriteLine(data3.Month);
Console.WriteLine(data3.Day);
Console.WriteLine(data3.Hour);
Console.WriteLine(data3.Minute);
Console.WriteLine(data3.Second);

DateTime hoje = DateTime.Now;
DateTime dataDevolução = hoje.AddDays(7);
dataDevolução = dataDevolução.AddHours(2);
Console.WriteLine($"Você pegou o livro no dia {hoje} \n" +
    $"devrá devolver no dia {dataDevolução}");


TimeSpan resultado = dataDevolução - hoje;
TimeSpan diferença = hoje.Subtract(dataDevolução);
Console.WriteLine(resultado);
Console.WriteLine(resultado.Days);
Console.WriteLine(resultado.Hours);
Console.WriteLine(resultado);
Console.WriteLine(resultado);
Console.WriteLine(resultado.Days);
Console.WriteLine(resultado.Hours);
Console.WriteLine(resultado);
Console.WriteLine(resultado);






