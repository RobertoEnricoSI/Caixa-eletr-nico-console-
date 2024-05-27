using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Caixa_eletrônico_console_
{
    public class CCorrente:Conta
    {
        private bool especial;
        public CCorrente(string numero, double limite):this()
        {
            this.numero = numero;
            this.limite = limite;
        }
        public CCorrente()
        {
            this.saldo = 0;
            this.status = true;
            this.transacoes = new List<Transacao>();
        }
        public bool Especial
        {
            get => this.especial;
            set => this.especial = value;
        }
    }
}