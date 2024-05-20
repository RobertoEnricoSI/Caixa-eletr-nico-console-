using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_eletrônico_console_
{
    public class Conta
    {
        protected string numero;
        protected double saldo;
        protected double limite;
        protected bool status;
        protected List<Transacao> transacoes;
        public string Numero
        {
            get=>this.numero;
            set
            {
                if(value != "" && Int32.TryParse(value,out int a))
                {
                    this.numero = value;
                }
            }
        }
        public double Saldo
        {
            get => this.saldo;
        }
        public double Limite
        {
            get=> this.limite; // double l = conta.Limite; Console.Write(conta.Limite);
            set                // conta.Limite = 500;
            {
                if(value>=0)
                    this.limite = value;
            }
        }
        public bool Status
        {
            get => this.status;
            set => this.status = value;
        }
        public List<Transacao> Transacoes
        {
            get=> this.transacoes;
        }
        public Conta()
        {
            this.saldo = 0;
            this.status = true;
            this.transacoes = new List<Transacao>();
        }
        public Conta(string numero):this()
        {
            this.numero = numero;
        }
        public bool Sacar(double valor)
        {
            if (saldo - valor >= 0)
            {
                saldo -= valor;
                transacoes.Add(new Transacao(valor, 's',this));
                return true;
            }
            return false;
        }
        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                transacoes.Add(new Transacao(valor, 'd',this));
                return true;
            }
            return false;
        }
        public bool Transferir(CCorrente destino, double valor)
        {
            if (destino.status   // Conta de destino deve estar ativa
                   &&              // E
                   Sacar(valor)    // Saque tem que dar certo
                   &&              // E
                   destino.Depositar(valor)) // Depósito tem que ser aceito
            {
                transacoes[transacoes.Count - 1].duplicata = destino.transacoes[destino.transacoes.Count - 1];
                destino.transacoes[destino.transacoes.Count - 1].duplicata = transacoes[transacoes.Count - 1];
                return true;
            }
            return false;
        }
    }
}
