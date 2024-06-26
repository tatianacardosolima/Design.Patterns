using System;

namespace Design.Patterns.Console.Behavioral.Patterns.Command
{
    public static class Main
    {
        public static void Execute()
        {
            // Criação das contas
            var account1 = new Account();
            var account2 = new Account();

            // Criação dos comandos
            ICommand depositCommand = new DepositCommand(account1, 100);
            ICommand withdrawCommand = new WithdrawCommand(account1, 50);
            ICommand transferCommand = new TransferCommand(account1, account2, 30);

            // Criação do invoker
            var transactionManager = new TransactionManager();

            // Execução dos comandos
            transactionManager.ExecuteCommand(depositCommand);
            transactionManager.ExecuteCommand(withdrawCommand);
            transactionManager.ExecuteCommand(transferCommand);

            // Undo da última transferência           
            transferCommand.Undo();

           


        }
    }
}
