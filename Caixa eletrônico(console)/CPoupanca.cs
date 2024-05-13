using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_eletrônico_console_
{
    public class CPoupanca
    {
        public string numero;
        public double saldo;
        public bool status;
        public List<Transacao> transacoes;
        public CPoupanca()
        {
            this.saldo = 0;
            this.status = true;
            this.transacoes = new List<Transacao>();
        }
        public CPoupanca(string numero):this()
        {
            this.numero = numero;
        }
        public bool Sacar(double valor)
        {
            if (saldo - valor >= 0)
            {
                saldo -= valor;
                transacoes.Add(new Transacao(valor, 's'));
                return true;
            }
            return false;
        }
        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                transacoes.Add(new Transacao(valor, 'd'));
                return true;
            }
            return false;
        }
        public bool Transferir_C(double valor,CCorrente destino)
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
        public bool transferir_P(double valor, CPoupanca destino)
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
