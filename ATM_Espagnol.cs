using System;
using System.Diagnostics.SymbolStore;

public class cardHolder
{

    String cardNum;
    int pin;
    String prenom;
    String nom;
    double balance;

    public cardHolder(String cardNum, int pin, String prenom, String nom, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.prenom = prenom;
        this.nom = nom;
        this.balance = balance;
    }

    /* getters */

    public String getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getPrenom()
    {
        return prenom;
    }

    public String getNom()
    {
        return nom;
    }

    public double getBalance()
    {
        return balance;
    }

    /* setters */

    public void setNum(String num)
    {
        cardNum = num;
    }

    public void setPin(int pin)
    {
        this.pin = pin;
    }

    public void setPrenom(String prenom)
    {
        this.prenom = prenom;
    }

    public void setNom(String nom)
    {
        this.nom = nom;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }


    /* Fonction d'affichage main */
    public static void Main(String[] args)
    {
        cardHolder user;

        void printOptionsES()
        {
            Console.WriteLine("Elige una de las siguientes opciones.");
            Console.WriteLine("1. Realizar un depósito "); /* línea de espacio */
            Console.WriteLine("2. Realizar una transferencia");
            Console.WriteLine("3. Consultar el saldo");
            Console.WriteLine("4. Salir");
        }

        /* fonction : option d'un dépot */

        void depositES(cardHolder U)
        {
            Console.WriteLine("¿Cuánto dinero desea depositar?");
            double deposit = Double.Parse(Console.ReadLine());
            U.setBalance(deposit);
            Console.WriteLine("Gracias por su depósito. Su saldo ahora es de " + user.getBalance());
        }


        /* fonction : option d'un transfert */

        void withdrawES(cardHolder U)
        {
            Console.WriteLine("¿Cuánto dinero desea transferir?");
            double withdrawal = Double.Parse(Console.ReadLine());
            double total = U.getBalance();
            if (withdrawal > total)
            {

                Console.WriteLine("ERROR: Saldo insuficiente.");

            }
            else
            {
                U.setBalance(total - withdrawal) ;
                Console.WriteLine("Gracias, la transferencia ha sido realizada.");
            };
        }

        /* fonction : option d'une consultation du solde */

        void balanceES(cardHolder user)
        {
            Console.WriteLine("Su saldo actual es: " + user.getBalance());
        }

        /* Liste d'adhérents */
        List<cardHolder> listHolder = new List<cardHolder>();

        /* création/ajout de nouveaux adhérents */
        listHolder.Add(new cardHolder("345678980", 1244, "John", "Terry", 23800.05));
        listHolder.Add(new cardHolder("345678980", 1564, "Iyad", "Mohamed", 23800.46));
        listHolder.Add(new cardHolder("304956780", 1674, "Brad", "Stevenson", 0.85));
        listHolder.Add(new cardHolder("222870980", 1287, "Ali", "Ahamada", 20.65));
        listHolder.Add(new cardHolder("123458980", 1303, "Nassourdine", "Zourid", 2090.89));
        listHolder.Add(new cardHolder("345609874", 9594, "Kassim", "M'ba", 67880.09));
        listHolder.Add(new cardHolder("300045680", 9199, "George", "Poter", 255500.23));
        listHolder.Add(new cardHolder("111111111", 1111, "Jean-Charles", "Mchangama", 100000.03));
        listHolder.Add(new cardHolder("345678980", 1244, "John", "Terry", 23800.05));

        /* -- Scénario final -- */

        Console.WriteLine(" ──────────────────────────── ");
        Console.WriteLine("│                            │");
        Console.WriteLine("│    MONEY IS RIGHT HERE $   │");
        Console.WriteLine("│                            │");
        Console.WriteLine(" ──────────────────────────── ");


        Console.WriteLine(" ");
        Console.WriteLine("   BIENVENIDO A SimpleATM.     ");
        Console.WriteLine(" ");

        String debitCardNum = "";


        /* -- Etape : numéro de carte -- */
        while (true)
{
    try
    {
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese su tarjeta (número identificador de la misma).");
        debitCardNum = Console.ReadLine();
        // Verificar si el número de tarjeta ingresado (arriba) pertenece / corresponde a uno de los "holder" en nuestra lista de titulares
        user = listHolder.FirstOrDefault(a => a.cardNum == debitCardNum);

        if (user != null) { break; }
        else
        {
            Console.WriteLine("Tarjeta no reconocida: número identificador no válido.");
        }

    }
    catch
    {
        Console.WriteLine("Tarjeta no reconocida: número identificador no válido.");
    }
}

/* -- Paso : Código PIN -- */

Console.WriteLine("Ingrese su código secreto (pin).");


int pinC = 0;

while (true)
{
    try
    {
        pinC = int.Parse(Console.ReadLine());

        if (user.getPin() == pinC) { break; }
        else
        {
            Console.WriteLine("Código incorrecto. Por favor intente de nuevo.");

        }

    }
    catch
    {
        Console.WriteLine("Código incorrecto. Por favor intente de nuevo.");
    }
}


        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" _________________________________________________________________________________________________________");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("        /\\        ");
        Console.WriteLine("       /  \\       ");
        Console.WriteLine("      /    \\      ");
        Console.WriteLine("     /      \\     ");
        Console.WriteLine("    /________\\    ");
        Console.WriteLine("    |        |    ");
        Console.WriteLine("    |        |    ");
        Console.WriteLine("    |        |    ");
        Console.WriteLine("    |        |    ");
        Console.WriteLine("    |________|    ");
        Console.WriteLine("   /          \\   ");
        Console.WriteLine("  /____________\\  ");
        Console.WriteLine("  |            |  ");
        Console.WriteLine("  |  SimpleATM |  ");
        Console.WriteLine("  |            |  ");
        Console.WriteLine("  \\____________/  ");

        Console.WriteLine("   ************   ");
        Console.WriteLine("   * * * ** * *   ");
        Console.WriteLine("    *********    ");
        Console.WriteLine("      * * *         <=  oui, ce sont bien les flammes de la fusée x) ");
        Console.WriteLine("      *****      ");
        Console.WriteLine("       * *       ");
        Console.WriteLine("        *       ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Console.WriteLine("Bienvenido " + user.getPrenom() + " " + user.getNom() + " : ) ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        int option = 0;

        do
        {
            printOptionsFR();

            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }

            if (option == 1) { depositES(user); }
            else if (option == 2) { withdrawES(user); }
            else if (option == 3) { balanceES(user); }
            else if (option == 4) { break; }
            else { option = 0; }
        } while (option != 4);

        Console.WriteLine(" ");
        Console.WriteLine("Hasta pronto. Por cierto, ¡que tengáis un buen día!");
        Console.WriteLine(" ");
    }
}