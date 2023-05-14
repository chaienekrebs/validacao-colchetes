namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma string!");
            var entrada = Console.ReadLine();
            var resultado = ValidarOrdemColchetes(entrada);
            if (resultado)
            {
                Console.WriteLine("Sequência válida!");
            }
            else
            {
                Console.WriteLine("Sequência inválida!");
            }
        }

        public static bool ValidarOrdemColchetes(string entrada)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char caractere in entrada)
            {
                switch (caractere)
                {
                    case '(':
                    case '{':
                    case '[':
                        pilha.Push(caractere);
                        break;

                    case ')':
                        if (pilha.Count == 0 || pilha.Peek() != '(')
                        {
                            return false;
                        }
                        pilha.Pop();
                        break;

                    case '}':
                        if (pilha.Count == 0 || pilha.Peek() != '{')
                        {
                            return false;
                        }
                        pilha.Pop();
                        break;

                    case ']':
                        if (pilha.Count == 0 || pilha.Peek() != '[')
                        {
                            return false;
                        }
                        pilha.Pop();
                        break;
                }
            }

            return pilha.Count == 0;
        }
    }
}