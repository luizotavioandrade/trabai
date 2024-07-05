using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_paulo
{
    internal class Livro
    {
        class livro
        {
            private int idLivro;
            private String titulo;
            private String autor;
            private String isbn;
            private bool disponibilidade;

            // Construtor
            public livro(int idLivro, String titulo, String autor, String isbn)
            {
                this.idLivro = idLivro;
                this.titulo = titulo;
                this.autor = autor;
                this.isbn = isbn;
                this.disponibilidade = true; // Livro está disponível por padrão
            }

            // Getters e Setters
            public int getIdLivro()
            {
                return idLivro;
            }

            public void setIdLivro(int idLivro)
            {
                this.idLivro = idLivro;
            }

            public String getTitulo()
            {
                return titulo;
            }

            public void setTitulo(String titulo)
            {
                this.titulo = titulo;
            }

            public String getAutor()
            {
                return autor;
            }

            public void setAutor(String autor)
            {
                this.autor = autor;
            }

            public String getIsbn()
            {
                return isbn;
            }

            public void setIsbn(String isbn)
            {
                this.isbn = isbn;
            }

            public bool isDisponivel()
            {
                return disponibilidade;
            }

            public void setDisponibilidade(bool disponibilidade)
            {
                this.disponibilidade = disponibilidade;
            }
        }

    }
}
