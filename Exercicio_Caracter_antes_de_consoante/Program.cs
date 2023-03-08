internal class Program
{
    private static void Main(string[] args)
    {
        string original, alterada;

        original = Console.ReadLine();

        alterada = insereCaracter(original);

        Console.WriteLine(alterada);


        string insereCaracter(string original)
        {
            string alterada = "";
            char[] aux = new char[original.Length * 2];

            for (int i = 0, j = 0; i < original.Length; i++)
            {
                if ((original[i] != 'a') && (original[i] != 'e') && (original[i] != 'i') && (original[i] != 'o') && (original[i] != 'u'))
                {
                    aux[j + 1] = original[i];
                    aux[j] = '.';
                    j += 2;
                }
                else
                {
                    aux[j] = original[i];
                    j++;
                }
            }
            for (int i = 0; i < aux.Length; i++)
            {
                alterada += aux[i];
            }

            return alterada;
        }

    }
}