
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas; //matriz do tabuleiro

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }


        public void colocarPeca(Peca p, Posicao pos) // da a posição para a peça
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
