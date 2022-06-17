
using Figgle;

namespace BigText
{
    class BText
    {
        public static void show(int numero)
        {

            string sNumero = numero.ToString();

            Console.WriteLine(
                FiggleFonts.Slant.Render(String.Join(' ', stringToArray(sNumero))));

        }

        public static char[] stringToArray(string s)
        {
            char[] ch = new char[s.Length]; 

            // Copy character by character into array 
            for (int i = 0; i < s.Length; i++) { 
                ch[i] = s[i]; 
            } 

            return ch;
        }

        public static int leNumero()
        {
            int numero;
            bool converteu;
            string numeroLido;
            do
            {
                numeroLido = Console.ReadLine();
                converteu = int.TryParse(numeroLido, out numero);
                if(!converteu)
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            } while (!converteu);
            return numero;
        }

        public static int escolheNumeroNaoEscolhido(int menor, int maior, List<int> numerosSorteados)
        {
            Random rd = new Random();
            int numero;
            do
            {
                numero = rd.Next(menor, maior);
            } while (numerosSorteados.Contains(numero));
            return numero;
        }

        public static void mostraNumerosEscolhidos(List<int> numerosSorteados)
        {
            for (int i = 0; i < numerosSorteados.Count(); i++)
            {
                if(i<numerosSorteados.Count()-1){
                    Console.Write(numerosSorteados[i].ToString()+", ");
                }else{
                    Console.Write(numerosSorteados[i]);
                }
            }
        }
    }
}