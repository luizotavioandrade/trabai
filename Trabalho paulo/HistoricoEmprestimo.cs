using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class HistoricoEmprestimo
{

  

    class HistoricoEmprestimos
    {
        private List<Emprestimo> listaEmprestimos;

        // Construtor
        public HistoricoEmprestimos()
        {
            this.listaEmprestimos = new ArrayList<>();
        }

        // Método para adicionar empréstimo ao histórico
        public void adicionarEmprestimo(Emprestimo emprestimo)
        {
            listaEmprestimos.Add(emprestimo);
        }

        // Método para listar todos os empréstimos registrados
        public List<HistoricoEmprestimo> listarEmprestimos()
        {
            List<Emprestimo> listaEmprestimos1 = listaEmprestimos;
            return listaEmprestimos1;
        }
    }

}
