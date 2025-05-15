Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

// Pedindo a idade do usuário
Console.Write("Digite sua idade: ");
string idade = Console.ReadLine();

// Pedindo a cidade onde mora
Console.Write("Digite a cidade onde você mora: ");
string cidade = Console.ReadLine();

// Mostrando as informações coletadas
Console.WriteLine("\n=== Informações Coletadas ===");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade} anos");
Console.WriteLine($"Cidade: {cidade}");

// Exemplo de cálculo simples com a idade
int idade_futura = int.Parse(idade) + 5;
Console.WriteLine($"\nEm 5 anos você terá {idade_futura} anos");

// Mensagem personalizada
Console.WriteLine($"\nOlá {nome}! É um prazer te conhecer!");
Console.WriteLine($"Que legal que você mora em {cidade}!");