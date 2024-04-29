using Caixa_eletrônico_console_;
using System.Runtime.CompilerServices;


int menu()
{
    string? i;
    Console.WriteLine("Digite o que deseja fazer:");
    Console.WriteLine("Acesso administrativo (1)");
    Console.WriteLine("Caixa elotronico (2)");
    Console.WriteLine("Sair (3)");
    i = Console.ReadLine();
    int op;
    Int32.TryParse(i, out op);
    return op;
}
int esc1()
{
    int a = 1;
    do
    {
        string? i;
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

int esc2()
{
    Console.WriteLine("Digite o numero da conta que deseja saber se existe");
    int con;
    string? i;
    i = Console.ReadLine();
    Int32.TryParse(i, out con);
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
