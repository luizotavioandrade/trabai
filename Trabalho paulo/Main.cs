using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_paulo
{
    internal class Main
    {
        

        
        
          public static List<Emprestimo> Main (String[] args)
            {
                // Criando alguns objetos de exemplo
                Livro livro1 = new livro(1, "Dom Casmurro", "Machado de Assis", "978-85-12-12345-6");
                Usuario usuario1 = new usuario(1, "João Silva", "(11) 98765-4321", "joao.silva@example.com");
                Emprestimo emprestimo1 = new emprestimo(1, livro1, usuario1);

                // Adicionando empréstimo ao histórico
                HistoricoEmprestimos historico = new HistoricoEmprestimos();
                historico.adicionarEmprestimo(emprestimo1);

                // Exemplo de penalidade aplicada
                Penalidade penalidade1 = new Penalidade(1, 5.0, "Devolução atrasada", emprestimo1);
                penalidade1.calcularMulta();

         
               
            }

        private static void println(object value)
        {
            throw new NotImplementedException();
        }
    }

    
}
