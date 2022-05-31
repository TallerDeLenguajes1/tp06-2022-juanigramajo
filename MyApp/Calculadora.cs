public class Calculadora{
    public double resultado;

    public Calculadora(double valorInicial){

        resultado = valorInicial;
    }

    public void Sumar(double valor){

        resultado += valor;
    }

    public void Restar(double valor){

        resultado -= valor;
    }

    public void Multiplicar(double valor){

        resultado *= valor;
    }

    public void Dividir(double valor){

        while (valor <= 0) {
        Console.WriteLine("\nError de formato, ingrese el denominador mayor que 0: ");
        valor = Convert.ToInt32(Console.ReadLine());
        }
        
        resultado /= valor;
    }
    public void Limpiar(){

        resultado = 0;
    }
}