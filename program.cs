using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создайте пароль");
            string NewPass =  Console.ReadLine();
            User Client = new User();
            Client.CreatePassword(NewPass);


            int selection = 0;
            do
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1-Выйти");
                Console.WriteLine("2-Сменить пароль");
                Console.WriteLine("3-Запрос баланса");
                Console.WriteLine("4-Добавить транзакцию");
                Console.WriteLine("5-Создайте счёт");

                selection = Int32.Parse(Console.ReadLine());

                switch (selection)
                {

                    case 1:
                        Console.WriteLine("Вы вышли");
                        break;
                    case 2:
                        Console.WriteLine("Введите новый пароль:");
                        string changedPass = Console.ReadLine();
                        Client.ChangePassword(changedPass);
                        Console.WriteLine("Вы успешно сменили пароль");

                        break;
                    case 3:
                        if (Client.Acc != null)
                        {
                            Console.WriteLine(Account.getBalance(Client.Acc.Details));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Создайте для начала счёт!");
                            break;
                        }
                    case 4:
                        if (Client.Acc != null && Client.Acc.Details != null)
                        {
                            int Transaction = 0;
                            do
                            {
                                Console.WriteLine("Введите вид транзакции (1 - расход/2 - доход)");
                                Transaction = Int32.Parse(Console.ReadLine());
                                switch (Transaction)
                                {

                                    case 1:
                                        Console.WriteLine("Расход");
                                        Transaction = 1;
                                        break;
                                    case 2:
                                        Console.WriteLine("Доход");
                                        Transaction = 2;
                                        break;
                                    default:
                                        Console.WriteLine("Необходимо ввести 1 или 2");
                                        break;
                                }
                            } while (Transaction != 3);
                            Console.WriteLine("Введите категорию:");
                            string Category = Console.ReadLine();
                            Console.WriteLine("Введите сумму:");
                            double Amount = Convert.ToDouble(Console.ReadLine());
                           Client.Acc.Details.Add(Detail.NewDatail(Amount,Category,DateTime.Now, Transaction));
                            Console.WriteLine("Успешно!");
                            break;
                        }
                        if (Client.Acc == null)
                        {
                            Console.WriteLine("Создайте для начала счёт!");
                            break;
                        }
                      
                            Console.WriteLine("Введите вид транзакции (расход/приход)");
                            string MYTransaction = Console.ReadLine();
                            Console.WriteLine("Введите категорию:");
                            string MYCategory = Console.ReadLine();
                            Console.WriteLine("Введите сумму:");
                            double MYAmount = Convert.ToDouble(Console.ReadLine());
                            List<Detail> myNewDetail = new List<Detail>();

                            myNewDetail.Add(Detail.NewDatail(Convert.ToDouble(MYAmount), MYCategory, DateTime.Now,
                                MYTransaction));
                            Client.Acc.Details = myNewDetail;
                            Console.WriteLine("Успешно!");
                            break;
                        
                       
                    case 5:
                        Console.WriteLine("Название счёта:");
                        string newAcc = Console.ReadLine();
                        Account myNewAccount = new Account();
                       
                        myNewAccount.name = newAcc;
                        Client.Acc = myNewAccount;
                        Console.WriteLine("Вы успешно создали счёт");

                        break;
                 
                

                    default:
                        Console.WriteLine("Некоректный ввод");
                        break;

                }
            } while (selection != 6);
            
            
           

        }
    }
}
