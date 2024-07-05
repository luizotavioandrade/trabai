namespace Trabalho_paulo
{
    internal class emprestimo : Emprestimo
    {
        private int v;
        private Livro livro1;
        private Usuario usuario1;

        public emprestimo(int v, Livro livro1, Usuario usuario1)
        {
            this.v = v;
            this.livro1 = livro1;
            this.usuario1 = usuario1;
        }
    }
}