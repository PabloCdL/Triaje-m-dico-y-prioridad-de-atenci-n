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

Console.WriteLine($"Edad: {edad}");
Console.WriteLine($"Temperatura: {temperatura}");
Console.WriteLine($"Saturacion de oxigeno: {saturacioO}");
Console.WriteLine($"Nivel de dolor: {ndolor}");
Console.WriteLine($"Presion: {presion}");

switch (opciones)
{

    case 1: // emergencia
        if (saturacioO < 90 || saturacioO > 100)
        {
            Console.WriteLine("Prioridad 1");
        } else if (presion < 90 || presion > 180)
        {
            Console.WriteLine("Prioridad 1");
        } else if (temperatura > 40 || temperatura < 30)
        {
            Console.WriteLine("Prioridad 1");
        } else if (saturacioO > 90 )
        {
            Console.WriteLine("Se recomienta haerse una CONSULTA");
            Console.WriteLine("Saturacion normal");
            Console.WriteLine("Prioridad 2");
        }else if (presion > 90)
        {
            Console.WriteLine("Se recomienta haerse una CONSULTA");
            Console.WriteLine("Presion normal");
            Console.WriteLine("Prioridad 2");
        }else if (temperatura > 34 && temperatura < 36)
        {
            Console.WriteLine("Temperatura estable");
            Console.WriteLine("Prioridad 2");
            Console.WriteLine("Se recomienta haerse una CONSULTA");
        }else
        {
            Console.WriteLine("Prioridad 3");
            Console.WriteLine("Se recomienda hacerse una CONSULTA");
        }
     break;
    case 2: // consulta
 
        break;
    case 3: // pediatria
 
        break;
    case 4: // traumatologia
 
        break;

    default:
        Console.WriteLine("Opcion no valida");
        break;
}




