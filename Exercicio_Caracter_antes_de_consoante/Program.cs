internal class Program
{
    private static void Main(string[] args)
    {
        bool valida=false;
        string parametro, resultado="", letra;
        string consoante = "bcdfghjklmnpqrstvwxyz";

        Console.WriteLine("digite o parametro a ser auterado: ");
        parametro = Console.ReadLine();

        Console.WriteLine("digite a letra que deseja inserir: ");
        letra = Console.ReadLine();

        for(int i = 0; i <parametro.Length; i++)
        {
            valida = false;
            for(int j = 0; j <consoante.Length; j++) 
            {
                if (parametro[i] == consoante[j])
                {
                    valida = true;
                    break;
                }
            }
            if (valida)
            {
                resultado += letra;
            }
            resultado += parametro[i];
           
        }
        Console.WriteLine(resultado);

    }
}