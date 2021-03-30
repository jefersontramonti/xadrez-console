
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; } // protected posde ser assecivel pala sub classe tambem
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;// toda peça ja inicia null
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;

        }
    }
}
