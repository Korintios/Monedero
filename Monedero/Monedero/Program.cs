int moneda500 = 0;
int moneda1000 = 0;
int moneda2000 = 0;
int moneda5000 = 0;
int moneda10000 = 0;
int monedas = 0;

int dinero500 = 0;
int dinero1000 = 0;
int dinero2000 = 0;
int dinero5000 = 0;
int dinero10000 = 0;
int dinerototal = 0;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("╔═════════════════════════════════════╗");
    Console.WriteLine("║               MONEDERO              ║");
    Console.WriteLine("╠═════════════════════════════════════╣");
    Console.WriteLine("║               INGRESO               ║");
    Console.WriteLine("║     [A]-Ingresar Moneda de 500      ║");
    Console.WriteLine("║     [B]-Ingresar Moneda de 1000     ║");
    Console.WriteLine("║     [C]-Ingresar Moneda de 2000     ║");
    Console.WriteLine("║     [D]-Ingresar Moneda de 5000     ║");
    Console.WriteLine("║     [E]-Ingresar Moneda de 10000    ║");
    Console.WriteLine("╠═════════════════════════════════════╣");
    Console.WriteLine("║              VISUALIZAR             ║");
    Console.WriteLine("║   [1]-Visualizar Monedas Totales    ║");
    Console.WriteLine("║   [F]-Visualizar Monedas de 500     ║");
    Console.WriteLine("║   [G]-Visualizar Monedas de 1000    ║");
    Console.WriteLine("║   [H]-Visualizar Monedas de 2000    ║");
    Console.WriteLine("║   [I]-Visualizar Monedas de 5000    ║");
    Console.WriteLine("║   [J]-Visualizar Monedas de 10000   ║");
    Console.WriteLine("║                                     ║");
    Console.WriteLine("║   [2]-Visualizar Dinero Total       ║");
    Console.WriteLine("║   [K]-Visualizar Dinero de 500      ║");
    Console.WriteLine("║   [L]-Visualizar Dinero de 1000     ║");
    Console.WriteLine("║   [M]-Visualizar Dinero de 2000     ║");
    Console.WriteLine("║   [N]-Visualizar Dinero de 5000     ║");
    Console.WriteLine("║   [O]-Visualizar Dinero de 10000    ║");
    Console.WriteLine("╠═════════════════════════════════════╣");
    Console.WriteLine("║              OPCIONES               ║");
    Console.WriteLine("║             [X]-Salir               ║");
    Console.WriteLine("╚═════════════════════════════════════╝");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "A":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            monedas++;
            moneda500++;
            dinero500 += 500;
            dinerototal += 500;
            Console.WriteLine("Moneda de 500 Ingresada Exitosamente!");
            break;
        case "B":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            monedas++;
            moneda1000++;
            dinero1000 += 1000;
            dinerototal += 1000;
            Console.WriteLine("Moneda de 1000 Ingresada Exitosamente!");
            break;
        case "C":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            monedas++;
            moneda2000++;
            dinero2000 += 2000;
            dinerototal += 2000;
            Console.WriteLine("Moneda de 2000 Ingresada Exitosamente!");
            break;
        case "D":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            monedas++;
            moneda5000++;
            dinero5000 += 5000;
            dinerototal += 5000;
            Console.WriteLine("Moneda de 5000 Ingresada Exitosamente!");
            break;
        case "E":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            monedas++;
            moneda10000++;
            dinero10000 += 10000;
            dinerototal += 10000;
            Console.WriteLine("Moneda de 10000 Ingresada Exitosamente!");
            break;
        case "1":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas Totales: " + monedas);
            break;
        case "F":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 500: " + moneda500);
            break;
        case "G":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 1000: " + moneda1000);
            break;
        case "H":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 2000: " + moneda2000);
            break;
        case "I":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 5000: " + moneda5000);
            break;
        case "J":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 10000: " + moneda10000);
            break;
        case "2":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dinero Total: " + dinerototal);
            break;
        case "K":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 500: " + dinero500);
            break;
        case "L":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 1000: " + dinero1000);
            break;
        case "M":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 2000: " + dinero2000);
            break;
        case "N":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 5000: " + dinero5000);
            break;
        case "O":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Monedas de 10000: " + dinero10000);
            break;
        case "X":
            Environment.Exit(0);
            break;
    }
}