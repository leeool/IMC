double altura, peso;

Console.Write("\nInsira seu peso (kg).....: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira a sua altura (m)..: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Seu IMC é de {peso / (Math.Pow(altura,2)):N2}");