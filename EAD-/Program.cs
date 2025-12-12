List<double> notas = new List<double>();

Console.Write("Digite a nota de Matemática: ");
notas.Add(double.Parse(Console.ReadLine()));

Console.Write("Digite a nota de Português: ");
notas.Add(double.Parse(Console.ReadLine()));

Console.Write("Digite a nota de Geografia: ");
notas.Add(double.Parse(Console.ReadLine()));

Console.Write("Digite a nota de História: ");
notas.Add(double.Parse(Console.ReadLine()));

Console.Write("Digite a nota de Física: ");
notas.Add(double.Parse(Console.ReadLine()));

var notasOrdenadas = notas.OrderByDescending(n => n).ToList();

double maiorNota = notasOrdenadas[0];
double segundaMaiorNota = notasOrdenadas[1];

Console.WriteLine($"Primeira maior nota: {maiorNota}");
Console.WriteLine($"Segunda maior nota: {segundaMaiorNota}");
