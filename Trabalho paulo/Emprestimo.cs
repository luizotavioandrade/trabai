using System;
using Trabalho_paulo;

internal class Emprestimo
{
    internal string getDataEmprestimo()
    {
        throw new NotImplementedException();
    }

    internal object getLivro()
    {
        throw new NotImplementedException();
    }

    internal object getUsuario()
    {
        throw new NotImplementedException();
    }

    public static implicit operator Emprestimo(int v)
    {
        throw new NotImplementedException();
    }

    private class emprestimo
    {
        private int idEmprestimo;
        private Date dataEmprestimo;
        private Date dataDevolucao;
        private Livro livro;
        private Usuario usuario;

        // Construtor
        public emprestimo(int idEmprestimo, Livro livro, Usuario usuario)
        {
            this.idEmprestimo = idEmprestimo;
            this.dataEmprestimo = new Date(); // Data atual como data de empréstimo
            this.livro = livro;
            this.usuario = usuario;
            this.dataDevolucao = null; // Ainda não foi devolvido
        }

        // Getters e Setters
        public int getIdEmprestimo()
        {
            return idEmprestimo;
        }

        public void setIdEmprestimo(int idEmprestimo)
        {
            this.idEmprestimo = idEmprestimo;
        }

        public Date getDataEmprestimo()
        {
            return dataEmprestimo;
        }

        public void setDataEmprestimo(Date dataEmprestimo)
        {
            this.dataEmprestimo = dataEmprestimo;
        }

        public Date getDataDevolucao()
        {
            return dataDevolucao;
        }

        public void setDataDevolucao(Date dataDevolucao)
        {
            this.dataDevolucao = dataDevolucao;
        }

        public Livro getLivro()
        {
            return livro;
        }

        public void setLivro(Livro livro)
        {
            this.livro = livro;
        }

        public Usuario getUsuario()
        {
            return usuario;
        }

        public void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }
    }

}