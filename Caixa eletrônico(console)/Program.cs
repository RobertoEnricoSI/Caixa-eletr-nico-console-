using Caixa_eletrônico_console_;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;



List<CCorrente> contas = new List<CCorrente>();          
int menu()
{
    string? i;
    Console.WriteLine("Digite o que deseja fazer:");
    Console.WriteLine("Acesso administrativo (1)");
    Console.WriteLine("Caixa eletronico (2)");
    Console.WriteLine("Sair (3)");
    i = Console.ReadLine();
    int op;
    Int32.TryParse(i, out op);
    return op;
}
void esc1()
{
    int a = 1;
    string? i;
    do
    {
        
        Console.WriteLine("Digite o que deseja fazer:");
        Console.WriteLine("cadastro de conta corrente (1)");
        Console.WriteLine("Mostrar saldo de todas as contas (2)");
        Console.WriteLine("Excluir conta específica (3)");
        Console.WriteLine("Voltar (qualquer outro num)");
        i = Console.ReadLine();
        int op;
        Int32.TryParse(i, out op);
        switch (op)
        {
            case 1:
                esc11();
                break;
            case 2:
                esc12();
                break;
            case 3:
                esc13();
                break;
            default:
                a = 0;
                break;
        }
    } while (a != 0);
}

void esc11()
{
    string? k;
    double limite;
    Console.WriteLine("Digite o limite da conta");
    k= Console.ReadLine();
    Double.TryParse(k, out limite);
    String numero = contas.Count.ToString();
    contas.Add(new CCorrente(numero,limite));
    Console.WriteLine("Numero da conta: " + numero);
    Console.WriteLine("Limite da conta: " + limite);
}

void esc12()
{
    foreach (var item in contas)
    {
        if (item.status == true)
        {
            Console.WriteLine("Saldo da conta "+item.numero+": "+item.saldo);
        }
    }
}

void esc13()
{
    Console.WriteLine("Digite o numero da conta que voce deseja excluir: ");
    string contex = Console.ReadLine();
    foreach(var item in contas)
    {
        if (item.numero == contex)
        {
            item.status = false;
            Console.WriteLine("Conta excluida com sucesso");
            return;
        }
    }
    Console.WriteLine("Conta nao encontrada");
}

void esc2()
{
    Console.WriteLine("Digite o numero da conta que deseja utilizar:");
    int con;
    string? i;
    i = Console.ReadLine();
    Int32.TryParse(i, out con);
    int b = 1;
    string? j;
    if (contas.Count-1 < con)
    {
        Console.WriteLine("Essa conta nao existe ou esta desativada");
    }
    else if (contas[con].status == true)
    {
        do
            {

                Console.WriteLine("Digite o que deseja fazer:");
                Console.WriteLine("Depositar (1)");
                Console.WriteLine("Sacar (2)");
                Console.WriteLine("Transferir (3)");
                Console.WriteLine("Voltar (qualquer outro num)");
                j = Console.ReadLine();
                int op;
                Int32.TryParse(j, out op);
                switch (op)
                {
                    case 1:
                        esc21(con);
                        break;
                    case 2:
                        esc22(con);
                        break;
                    case 3:
                        esc23(con);
                        break;
                    default:
                        b = 0;
                        break;
                }
            } while (b != 0);
    }
    else
    {
        Console.WriteLine("Essa conta nao existe ou esta desativada");
    }
    
}

void esc21(int con)
{
    Console.WriteLine("Digite o valor que deseja depositar: ");
    string? l;
    l = Console.ReadLine();
    int dep;
    Int32.TryParse(l, out dep);
    if (contas[con].Depositar(dep))
    {
        Console.WriteLine("Deposito realizado com sucesso"); 
    }
    else
    {
        Console.WriteLine("O deposito nao pode ser realizado");
    }
}

void esc22(int con)
{
    Console.WriteLine("Digite o valor do saque: ");
    string? m;
    m = Console.ReadLine();
    int saq;
    Int32.TryParse(m, out saq);
    if (contas[con].Depositar(saq))
    {
        Console.WriteLine("Saque realizado com sucesso");
    }
    else
    {
        Console.WriteLine("O saque nao pode ser realizado");
    }
}

void esc23(int Con)
{

    Console.Write("Digite o numero da conta de destino: ");
    string destino = Console.ReadLine();
    int text;
    Int32.TryParse(destino, out text);
    if (Con == text)
    {
        Console.WriteLine("Voce nao pode transferir para si mesmo");
    }
    else
    {
        foreach(var item in contas)
            {
                if (item.numero == destino)
                {
                    double val;
                    Console.Write("Digite o valor a transferir: ");
                    string i = Console.ReadLine();
                    Double.TryParse(i, out val);
                    if (contas[Con].Transferir(item, val))
                    {
                        Console.WriteLine("Transferencia bem sucedida!");
                    }
                    else
                    {
                        Console.WriteLine("Nao foi possivel realizar a transferencia");
                    }
                    return;
                }
            }
        Console.WriteLine("Conta nao encontrada");
    }
}

int z = 1;
do
    switch (menu())
    {
        case 1:
            esc1();
            break;
        case 2:
            esc2();
            break;
        case 3:
            Console.WriteLine("Adeus");
            z = 0;
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    } while (z != 0);
