using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_eletrônico_console_
{
    public class Transacao
    {
        private double valor;
        private char tipo;
        private Transacao duplicata;
        private Conta conta;
        public double Valor
        {
            get=>this.valor;
        }
        public char Tipo
        {
            get => this.tipo;
        }
        public Transacao Duplicata
        {
            get=>this.duplicata;
            set=>this.Duplicata= value;
        }
        public Conta Conta
        {
            get => this.conta;
        }
        public Transacao(double valor, char tipo, Conta conta)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.conta = conta;
        }
    }
}