// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;


Empleado[] empleados = new Empleado[3];
double totalEnSalarios = 0;


for (int i = 0; i < 1; i++)
{
    Empleado emp = cargaEmpleados(i);
    
    empleados[i] = emp;
}




Empleado cargaEmpleados(int ID)
{
    Empleado emp = new Empleado();

    Console.WriteLine($"\n----------CARGA DE DATOS----------");
    Console.WriteLine($"\n-----Empleado [{ID+1}]-----");

    Console.WriteLine("\nNombre:");
    emp.Nombre = Console.ReadLine();

    Console.WriteLine("\nApellido:");
    emp.Apellido = Console.ReadLine();



    //-------------------Día de nacimiento-------------------
    Console.Write("\n\nDía de nacimiento: ");
    int dia = int.Parse(Console.ReadLine());

    while ((dia < 0) ||  (dia > 31))
    {
        Console.Write("\nError de formato.\nDía de nacimiento: ");
        dia = int.Parse(Console.ReadLine());
    }

    //-------------------Mes de nacimiento-------------------
    Console.Write("\nMes de nacimiento: ");
    int mes = int.Parse(Console.ReadLine());

    while ((mes < 0) ||  (mes > 12))
    {
        Console.Write("\nError de formato.\nMes de nacimiento: ");
        mes = int.Parse(Console.ReadLine());
    }

    //-------------------Año de nacimiento-------------------
    Console.Write("\nAño de nacimiento: ");
    int ano = int.Parse(Console.ReadLine());

    while ((ano < 1000) ||  (ano > 2022))
    {
        Console.Write("\nError de formato.\nAño de nacimiento: ");
        ano = int.Parse(Console.ReadLine());
    }

    DateTime FechaNac = new DateTime(ano, mes, dia);



    //-------------------Estado civil-------------------
    Console.WriteLine("\n\nOpciones de estado civil:\nCasado [C]\nSoltero [S]\nIngrese una opción:");
    emp.EstCivil = Char.ToLower(Convert.ToChar(Console.ReadLine()));

    while ((emp.EstCivil != 'c') && (emp.EstCivil != 's'))
    {
        Console.WriteLine("\nError de formato.\nOpciones de estado civil:\nCasado [C]\nSoltero [S]\nIngrese una opción:");
        emp.EstCivil = Char.ToLower(Convert.ToChar(Console.ReadLine()));
    }



    //-------------------Género-------------------
    Console.WriteLine("\n\nOpciones de género:\nFemenino [F]\nMasculino [M]\nIngrese una opción:");
    emp.Genero = Char.ToLower(Convert.ToChar(Console.ReadLine()));

    while ((emp.Genero != 'm') && (emp.Genero != 'f'))
    {
        Console.WriteLine("\nError de formato.\nOpciones de género:\nFemenino [F]\nMasculino [M]\nIngrese una opción:");
        emp.Genero = Char.ToLower(Convert.ToChar(Console.ReadLine()));
    }



    //-------------------Día de ingreso a la empresa-------------------
    Console.Write("\n\nDía de ingreso a la empresa:");
    int diaIng = int.Parse(Console.ReadLine());

    while ((diaIng < 0) ||  (diaIng > 31))
    {
        Console.Write("\nError de formato.\nDía de ingreso a la empresa:");
        diaIng = int.Parse(Console.ReadLine());
    }

    //-------------------Mes de ingreso a la empresa-------------------
    Console.Write("\nMes de ingreso a la empresa:");
    int mesIng = int.Parse(Console.ReadLine());

    while ((mesIng < 0) ||  (mesIng > 12))
    {
        Console.Write("\nError de formato.\nMes de ingreso a la empresa:");
        mesIng = int.Parse(Console.ReadLine());
    }

    //-------------------Año de ingreso a la empresa-------------------
    Console.Write("\nAño de ingreso a la empresa:");
    int anoIng = int.Parse(Console.ReadLine());

    while ((anoIng < 1000) ||  (anoIng > 2022))
    {
        Console.Write("\nError de formato.\nAño de ingreso a la empresa:");
        anoIng = int.Parse(Console.ReadLine());
    }

    DateTime FechaIng = new DateTime(anoIng, mesIng, diaIng);



    Console.WriteLine("\n\nSalario:");
    emp.SalarioEmp = Convert.ToDouble(Console.ReadLine());



    //-------------------Cargo-------------------
    Console.WriteLine("\n\nOpciones de cargos:\nAuxliar [0]\nAdministrativo [1]\nIngeniero [2]\nEspecialista [3]\nInvestigador [4]\nIngrese una opción:");
    int dato = Convert.ToInt32(Console.ReadLine());

    while ((dato < 0) && (dato > 4))
    {
        Console.WriteLine("\nError de formato.\nOpciones de cargos:\nAuxliar [0]\nAdministrativo [1]\nIngeniero [2]\nEspecialista [3]\nInvestigador [4]\nIngrese una opción:");
        dato = Convert.ToInt32(Console.ReadLine());
    };

    switch (dato){
        case 1:
            emp.Cargos = Cargo.Auxiliar;
            break;
        case 2:
            emp.Cargos = Cargo.Administrativo;
            break;
        case 3:
            emp.Cargos = Cargo.Ingeniero;
            break;
        case 4:
            emp.Cargos = Cargo.Especialista;
            break;
        case 5:
            emp.Cargos = Cargo.Investigador;
            break;
        default:
            break;
    }

    emp.Edad = emp.calcularEdad(emp.FechaNac);
    
    emp.AntiguedadEmp = emp.Antiguedad(emp.FechaIng);
    
    emp.Anos = emp.AnosPJubilarse(emp.Genero);
    
    emp.SalarioEmp = emp.Salario(emp.SalarioEmp, emp.Cargos, emp.EstCivil, emp.AntiguedadEmp);
    
    totalEnSalarios = totalEnSalarios + emp.SalarioEmp;


    return emp;
}