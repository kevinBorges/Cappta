using ExplorandoMarte;

Console.WriteLine("Informe as coordenadas do canto superior direito do planalto (por exemplo, '5 5'): ");
string[] plateauSize = Console.ReadLine().Split(' ');
int maxX = int.Parse(plateauSize[0]);
int maxY = int.Parse(plateauSize[1]);

List<Sonda> sondas = new List<Sonda>();

while (true)
{
    Console.WriteLine("Informe a posição inicial da sonda e sua direção (por exemplo, '1 2 N'): ");
    string[] initialPosition = Console.ReadLine().Split(' ');
    int startX = int.Parse(initialPosition[0]);
    int startY = int.Parse(initialPosition[1]);
    char direction = char.Parse(initialPosition[2].ToUpper());

    Console.WriteLine("Informe as instruções para a sonda (por exemplo, 'LMLMLMLMM'): ");
    string instructions = Console.ReadLine();

    Sonda sonda = new Sonda(startX, startY, direction);
    sondas.Add(sonda);

    foreach (char instruction in instructions)
        sonda.Mover(instruction, maxX, maxY);

    Console.WriteLine("Deseja adicionar outra sonda? (S/N): ");
    string resposta = Console.ReadLine().ToUpper();
    if (resposta != "S")
        break;
}

Console.WriteLine("Posição final das sondas:");

foreach (Sonda sonda in sondas)
{
    Console.WriteLine($"{sonda.X} {sonda.Y} {sonda.Direcao}");
}