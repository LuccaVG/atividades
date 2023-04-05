Console.WriteLine($"Insira o seu Nome");
string nome;

nome = (Console.ReadLine());

Console.WriteLine($"Insira sua Idade");
int Idade;

Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira seu Sálario");
int sálario;

sálario = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira seu estado civil");

Console.WriteLine($"Digite 1 para Solteiro(a)");

Console.WriteLine($"Digite 2 para Casado(a)");

Console.WriteLine($"Digite 3 para Viúvo(a)");

Console.WriteLine($"Digite 4 para Divorciado(a)");


int estadocivil = int.Parse(Console.ReadLine());

switch(estadocivil){

case 1:
Console.WriteLine($"Solteiro(a)");
break;

case 2:
Console.WriteLine($"Casado(a)");
break;

case 3:
Console.WriteLine($"Viúvo(a)");
break;

case 4:
Console.WriteLine($"Divorciado(a)");
break;

}