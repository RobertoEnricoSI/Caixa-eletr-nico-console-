using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_eletrônico_console_
{
    public class CPoupanca:Conta
    {
        public CPoupanca()
        {
            this.limite = 0;
            this.saldo = 0;
            this.status = true;
            this.transacoes = new List<Transacao>();
        }
        public CPoupanca(string numero):this()
        {
            this.numero = numero;
        }
    }
}
