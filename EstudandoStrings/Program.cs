using System;
using System.Text;

namespace EstudandoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GUID");
            var id = Guid.NewGuid();
            Console.WriteLine("Forma correta de gerar GUID (var id = Guid.NewGuid()): "+ id);
            var novoId = new Guid();
            Console.WriteLine("Forma errada de gerar GUID pois só inicializa (var novoId = new Guid()): "+novoId);
            Console.WriteLine("---------------------");
            Console.WriteLine("Interpolação de strings");
            double preco = 15.5;
            string texto = "o preço do produto é: "+preco;
            Console.WriteLine(texto);
            var txt1 = String.Format("o preço é: {0} com desconto de {1} %" ,preco,5);
            Console.WriteLine(txt1);
            Console.WriteLine("---------------------");
            string txt2 = $@"o preço é {300.70} 
            com desconto de {preco} % em pagamento à vista";
            //@ para quebrar linha e não da erro
            Console.WriteLine(txt2);
             string txt3 = $"o preço é {300.70} \n com desconto de {preco} % em pagamento à vista";
             Console.WriteLine(txt3);
             Console.WriteLine("-------------------------");
             Console.WriteLine("Comparação de strings");
             var t1 = "Exemplo";
             Console.WriteLine(t1.CompareTo("Exemplo"));
             Console.WriteLine(t1.CompareTo("exemplo"));
             Console.WriteLine(t1.CompareTo("exemplO"));
             Console.WriteLine("-------------------------");
             Console.WriteLine(t1.Contains("Exem"));
             Console.WriteLine(t1.Contains("exem"));
             Console.WriteLine(t1.Contains("exem",StringComparison.OrdinalIgnoreCase));
             Console.WriteLine("-------------------------");
             texto = "Exemplo para teste";
             Console.WriteLine(texto.StartsWith("Exemplo"));
             Console.WriteLine(texto.StartsWith(" Exemplo"));
             Console.WriteLine(texto.StartsWith("exemplo"));
             Console.WriteLine(texto.EndsWith("teste"));
             Console.WriteLine(texto.EndsWith("Teste"));
             Console.WriteLine(texto.EndsWith("teste "));
             Console.WriteLine("-------------------------");
             Console.WriteLine(texto.Equals("Exemplo para teste"));
             Console.WriteLine(texto.Equals("exemplo para teste", StringComparison.OrdinalIgnoreCase));
             Console.WriteLine(texto.Equals("exemplo para teste"));
             Console.WriteLine("-------------------------");
             Console.WriteLine("Indices");
             Console.WriteLine(texto.IndexOf("m"));
             Console.WriteLine(texto.LastIndexOf("e"));
             Console.WriteLine("-------------------------");
             Console.WriteLine("to lower or to upper");
             Console.WriteLine(texto.ToLower());
             Console.WriteLine(texto.ToUpper());
             Console.WriteLine("-------------------------");
             Console.WriteLine("Manipulando strings");
             var exemplo = "Uma frase qualquer";
             Console.WriteLine("exemplo replace: "+exemplo.Replace("frase","palavra"));
             var splitExemplo = exemplo.Split(" ");
             Console.WriteLine("Exemplo de split");
             for(int i = 0; i < splitExemplo.Length; i++){
                 Console.WriteLine(splitExemplo[i]);
             }
             Console.WriteLine("Exemplo trim: removendo espaço no começo e fim");
             var testeTrim = " "+exemplo+" ";
             Console.WriteLine("("+testeTrim+")");             
             Console.WriteLine("("+testeTrim.Trim()+")");
             Console.WriteLine("Substring: "+exemplo.Substring(4,5));
             Console.WriteLine("-------------------------");
             Console.WriteLine("String builder");
             var text = new StringBuilder();
             text.Append("Começo");
             text.Append(" meio ");
             text.Append("fim");
             Console.WriteLine(text);
        }
    }
}