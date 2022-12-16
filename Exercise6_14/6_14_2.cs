using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Exercise6_14
{
    class Account   // 계정 클래스
    {
        private double balance;
        public Account(double initialDeposit)   // 생성자
        {
            balance = initialDeposit;
        }
        public double Balance   // 프로퍼티
        {
            get { return balance; } // 잔액 조회
            set { balance = value; }
        }
        public void Deposit(double amount)  // 총액 계산 및 기록
        {
            lock (this)
            {
                balance += amount;
            }
        }
    }
    class Teller    // 은행원 클래스
    {
        string name;        // 은행원 이름
        Account account;    // 처리할 계정
        double amount;      // 예금액
        public Teller(string name, Account account, double amount)
        {
            this.name = name;
            this.account = account;
            this.amount = amount;
        }
        public void TellerTask()
        {
            account.Deposit(amount);
            Console.WriteLine(name + " : " + account.Balance);
        }
    }
    class Exercise6_14_2
    { 
        public static void Main()
        {
            double account;
            double amount;
            Console.Write("초기 예금 금액을 입력하세요 : ");
            account = double.Parse(Console.ReadLine());
            Account a = new Account(account);
            Console.Write("은행원1 예금 금액 입력 : ");
            amount = double.Parse(Console.ReadLine());
            Teller t1 = new Teller("은행원1", a, amount);
            Console.Write("은행원2 예금 금액 입력 : ");
            amount = double.Parse(Console.ReadLine());
            Teller t2 = new Teller("은행원2", a, amount);
            Console.Write("은행원3 예금 금액 입력 : ");
            amount = double.Parse(Console.ReadLine());
            Teller t3 = new Teller("은행원3", a, amount);
            t1.TellerTask();
            t2.TellerTask();
            t3.TellerTask();
        }
    }
}
