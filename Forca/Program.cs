
Console.WriteLine("**BEM-VINDO AO JOGO DA FORCA**");
Console.WriteLine("");
Console.WriteLine("Dica: É um brinquedo!");
Console.WriteLine("");
Console.WriteLine("Não se preocupe, suas tentativas são ilimitadas");
Console.WriteLine("");
Console.WriteLine("Você poderá adivinhar a palavra durante o jogo!");
Console.WriteLine("");

// criar uma lista de palavras
string[] brinquedos = new string[5] { "skate", "pipa", "bambole", "lego", "boneca" };

// criar uma variável randomica
Random random = new Random();

// criar uma variável do tipo inteira que recebe o valor aleatório de um índice do array "brinquedos"
int posicao_aleatoria = random.Next(brinquedos.Length);

// montar uma string com a palavra da posição randomica
string palavra_escolhida = brinquedos[posicao_aleatoria];

// criar um vetor da palavra randomica, onde cada caractere se torna um índice
char[] vetorDaPalavra = palavra_escolhida.ToCharArray();

// criar um outro vetor onde cada caractere será um "_", respeitando o tamanho da palavra escolhida aleatóriamente
char[] espaco_vazio = new string('_', vetorDaPalavra.Length).ToCharArray();

// exibir os caracteres "_" na tela
for (int i = 0; i <  espaco_vazio.Length; i++)
{
    Console.Write(espaco_vazio[i] + " ");
}

// criar uma estrutura "while", ou seja, rodar a estrutura "for" até que uma condição seja atendida
while (String.Join("", espaco_vazio) != palavra_escolhida)
{
    // pedir para o usuário digitar uma letra
    Console.WriteLine(" <- Digite uma letra da palavra.");
    string tentativa = Console.ReadLine() ?? "";

    // criar uma variável para armzenar um número, caso o usuário digite um número
    int tentativaNum;

    // criar uma variável booleana que testa a conversão de uma string em um número
    // se for verdadeiro, significa que o usuário digitou um número, se falso é porque ele não digitou um número
    bool resultado = int.TryParse(tentativa, out tentativaNum);

    // criar uma condição para impedir que o usuário digite algo diferente de uma letra
    if (tentativa.Length == palavra_escolhida.Length && tentativa == palavra_escolhida)
    {
        break;
    }
    if (tentativa.Length > 1 || String.IsNullOrEmpty(tentativa) || resultado)
    {
        Console.WriteLine("Esse tipo de caractere não é aceito. Favor, digite apenas uma letra.");
    }
    else
    {
        // transformando o dado de entrada do usuário (tentativa) em um caractere
        char letra = char.Parse(tentativa);

        // percorrer todo o vetor "vetorDaPalavra
        for (int i = 0; i < vetorDaPalavra.Length; i++)
        {
            //comparando SE algum indice do vetor é igual a letra digitada pelo usuário -> dado de entrada
            if (vetorDaPalavra[i] == letra)
            {
                // substituindo o espaço "_" pela letra digitada caso a condição de cima seja atendida
                espaco_vazio[i] = letra;
            }
        }
    }
    // impressão do vetor na tela, após o acerto de todas as letras
    foreach (char c in espaco_vazio)
    {
        Console.Write(c + " ");
    }
}
// pulando uma linha
Console.WriteLine(" ");
Console.WriteLine("Parabéns, você acertou a palavra!");
