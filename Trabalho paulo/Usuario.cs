using System;

namespace Trabalho_paulo
{
    internal class Usuario
    {
        class usuario
        {
            private int idUsuario;
            private String nome;
            private String telefone;
            private String email;

            // Construtor
            public usuario(int idUsuario, String nome, String telefone, String email)
            {
                this.idUsuario = idUsuario;
                this.nome = nome;
                this.telefone = telefone;
                this.email = email;
            }

            // Getters e Setters
            public int getIdUsuario()
            {
                return idUsuario;
            }

            public void setIdUsuario(int idUsuario)
            {
                this.idUsuario = idUsuario;
            }

            public String getNome()
            {
                return nome;
            }

            public void setNome(String nome)
            {
                this.nome = nome;
            }

            public String getTelefone()
            {
                return telefone;
            }

            public void setTelefone(String telefone)
            {
                this.telefone = telefone;
            }

            public String getEmail()
            {
                return email;
            }

            public void setEmail(String email)
            {
                this.email = email;
            }
        }

    }
}