using System;
using System.Globalization;

class Account{
    public string name;
    private int id;
    private double sake;
    private double deposit;
    public Account(int id, string name, double deposit){
        this.id = id;
        this.name = name;
        this.deposit = deposit;
        
    }

    public int Id {
        get {return this.id;}
    }
 

    public double Deposit {
        get {return this.deposit;}

        set {
            this.deposit += value;
        }
    }

    public double Sake {
        get {return this.sake;}

        set {
            this.sake = this.sake - value - 5.00;
        }
    }

    public double ValueTotal(){
       return this.Deposit - this.Sake;
    }

    public override string ToString(){
        return "Conta: "
        + this.Id
        + ", Titular: "
        + this.name
        + ", Saldo: $ "
        + this.ValueTotal().ToString("F2", CultureInfo.InvariantCulture);
    }
}

class Program{
    static void Main(string[] args){

        Console.Write("Entre o número da conta: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string name = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n) ? ");
        string choice = Console.ReadLine();
        double deposit;

        if(choice == "s" || choice == "S"){
            Console.Write("Entre o valor do depósito inicial: ");
             deposit = double.Parse(Console.ReadLine());
        }else{
            deposit = 0.00;
        }

        Account account = new Account(id, name, deposit);

        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(account);
        

    }
}
