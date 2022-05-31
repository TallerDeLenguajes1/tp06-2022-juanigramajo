// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Calculadora calc = new Calculadora(0);

int opcion = 0;
double num = 0;
opcion = menu();

while (opcion != 6){

    if(opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4){
        Console.WriteLine("\nIngrese un numero: ");
    num = Convert.ToDouble(Console.ReadLine());
    }

    string operac = " ";

    switch (opcion){
        case 1:
            calc.Sumar(num);
            operac = "sumar";
            break;
        case 2:
            calc.Restar(num);
            operac = "restar";
            break;
        case 3:
            calc.Multiplicar(num);
            operac = "multiplicar";
            break;
        case 4:
            calc.Dividir(num);
            operac = "dividir";
            break;
        case 5:
            calc.Limpiar();
            operac = "limpiar";
            break;
        default:
            break;
    }

    Console.WriteLine("\n\n-----Resultado de " + operac + ": [" + calc.resultado + "]-----");

    opcion = menu();
}




int menu(){

    Console.WriteLine("\nOPCIONES:\n[1]: Suma\n[2]: Resta\n[3]: Multiplicación\n[4]: División\n[5]: Limpiar\n[6]: Salir\nIngrese que operación desea realizar: ");
    opcion = Convert.ToInt32(Console.ReadLine());


    while (opcion > 6){

        Console.WriteLine("\nError de formato\nOPCIONES:\n[1]: Suma\n[2]: Resta\n[3]: Multiplicación\n[4]: División\n[5]: Limpiar\n[6]: Salir\nIngrese que operación desea realizar: ");
        opcion = Convert.ToInt32(Console.ReadLine());
    }

    return opcion;
}