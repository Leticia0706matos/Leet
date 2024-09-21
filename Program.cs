String Usuario;
String traducao;

Console.Clear();


Console.WriteLine("traduzindo para leet speak");
Usuario= Console.ReadLine()!;

traducao = Usuario.Replace("a", "4")
                .Replace("A", "4")
                .Replace("E", "3")
                .Replace("e", "3")
                .Replace("I", "1")
                .Replace("i", "1")
                .Replace("O", "0")
                .Replace("o", "0")
                .Replace("T", "7")
                .Replace("t", "7")
                .Replace("S", "5")
                .Replace("s", "5");

                Console.WriteLine($"Seu nome em leet speak fica assim. {traducao}");