double metros, centimetros, quilometros;

Console.Write("Por favor, insira a distância (em metros): ");
metros = Convert.ToDouble(Console.ReadLine()!);

centimetros = metros * 100;
quilometros = metros / 1000;

Console.WriteLine("-------Equivalência-------");
Console.WriteLine($"\nCentímetros: {centimetros} cm\nMetros.....: {metros} m\nQuilômetros: {quilometros} Km");