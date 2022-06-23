
public enum Cargo
{
    Auxiliar,
    Administrativo, 
    Ingeniero,
    Especialista, 
    Investigador
}


public class Empleado
{
    public string Nombre;
    public string Apellido;
    public DateTime FechaNac;
    public char EstCivil;
    public char Genero;
    public DateTime FechaIng;
    public double SueldoBasic;

    public Cargo Cargos;

    DateTime Now = DateTime.Today;
    public int Edad = 0, AntiguedadEmp = 0, Anos = 0;
    public double SalarioEmp = 0;


    public int Antiguedad(DateTime fechaIn)
    {
        AntiguedadEmp = Now.Year - fechaIn.Year;

        if(fechaIn.Month > Now.Month)
        {
            AntiguedadEmp = AntiguedadEmp-1;
        }

        return AntiguedadEmp;
    }


    public int calcularEdad(DateTime fechaNac)
    {
        Edad = Now.Year - fechaNac.Year;

        if(fechaNac.Month > Now.Month)
        {
            Edad = Edad-1;
        }

        return Edad;
    }


    public int AnosPJubilarse(char genero)
    {

        if((genero == 'f') || (genero == 'F'))
        {
            Anos = 60 - Edad;
        } else
        {
            Anos = 65 - Edad;
        }

        return Anos;
    }


    public double Salario(double sueldo, Cargo Cargo, char EstCivil, int antiguedad)
    {

        double adicional = 0;

        if(antiguedad < 20)
        {
            adicional = (antiguedad * 0.01) * sueldo;
        } else
        {
            adicional = 0.25 * sueldo;
        }

        if((Cargos == Cargo.Ingeniero) || (Cargos == Cargo.Especialista))
        {
            adicional = adicional * 1.50;
        }

        if((EstCivil == 'c') || (EstCivil == 'C'))
        {
            adicional = adicional + 15000;
        }

        SalarioEmp = sueldo + adicional;


        return SalarioEmp;
    }
}

