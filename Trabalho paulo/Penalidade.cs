using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_paulo
{
    internal class Penalidade
    {
        private int v1;
        private double v2;
        private string v3;
        private Emprestimo emprestimo1;

        public Penalidade(int v1, double v2, string v3, Emprestimo emprestimo1)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.emprestimo1 = emprestimo1;
        }

        internal void calcularMulta()
        {
            throw new NotImplementedException();
        }

        class penalidade
        {
            private int idPenalidade;
            private double valorMulta;
            private String motivo;
            private Date dataAplicacao;
            private Emprestimo emprestimos;

            // Construtor
            public penalidade(int idPenalidade, double valorMulta, String motivo, Emprestimo emprestimo)
            {
                this.idPenalidade = idPenalidade;
                this.valorMulta = valorMulta;
                this.motivo = motivo;
                this.dataAplicacao = new Date(); // Data atual como data de aplicação
                this.emprestimos = emprestimo;
            }

            // Método para calcular a multa
            public void calcularMulta()
            {
                // Lógica para calcular a multa com base nas datas e regras da biblioteca
                // Exemplo simples: penalidade fixa por dia de atraso
            }

            // Getters e Setters
            public int getIdPenalidade()
            {
                return idPenalidade;
            }

            public void setIdPenalidade(int idPenalidade)
            {
                this.idPenalidade = idPenalidade;
            }

            public double getValorMulta()
            {
                return valorMulta;
            }

            public void setValorMulta(double valorMulta)
            {
                this.valorMulta = valorMulta;
            }

            public String getMotivo()
            {
                return motivo;
            }

            public void setMotivo(String motivo)
            {
                this.motivo = motivo;
            }

            public Date getDataAplicacao()
            {
                return dataAplicacao;
            }

            public void setDataAplicacao(string dataAplicacao)
            {
                this.dataAplicacao = dataAplicacao;
            }

            public int GetEmprestimos()
            {
                return emprestimos;
            }

            public int getemprestimo(int emprestimos) => emprestimos;

            public void setEmprestimo(int emprestimo)
            {
                this.emprestimos = emprestimo;
            }
        }


    }
}
