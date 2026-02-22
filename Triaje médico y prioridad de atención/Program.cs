Console.WriteLine("Tipo de atención");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatria");
Console.WriteLine("4. Traumatologia");

int opciones = int.Parse(Console.ReadLine());
int edad;
double temperatura;
int saturacioO;
int ndolor;
double presion;

switch (opciones)
{
    case 1:
        Console.WriteLine("Ingrese la edad");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la temperatura");
        temperatura = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la saturacion del oxigeno");
        saturacioO = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nivel de dolor (escala del 1-10)");
        ndolor = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la presion sistolica");
        presion = double.Parse(Console.ReadLine());

    break;
    case 2:
        Console.WriteLine("Ingrese la edad");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la temperatura");
        temperatura = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la saturacion del oxigeno");
        saturacioO = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nivel de dolor (escala del 1-10)");
        ndolor = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la presion sistolica");
        presion = double.Parse(Console.ReadLine());
        break;
    case 3:
        Console.WriteLine("Ingrese la edad");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la temperatura");
        temperatura = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la saturacion del oxigeno");
        saturacioO = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nivel de dolor (escala del 1-10)");
        ndolor = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la presion sistolica");
        presion = double.Parse(Console.ReadLine());
        break;
    case 4:
        Console.WriteLine("Ingrese la edad");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la temperatura");
        temperatura = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la saturacion del oxigeno");
        saturacioO = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nivel de dolor (escala del 1-10)");
        ndolor = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la presion sistolica");
        presion = double.Parse(Console.ReadLine());
        break;

    default:
        Console.WriteLine("Desicion no valida");
        break;
}
