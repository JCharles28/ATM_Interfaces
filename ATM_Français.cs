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

        void printOptionsFR()
        {
            Console.WriteLine("Choisissez l'une des options suivantes.");
            Console.WriteLine("1. Effectuer un dépot "); /* ligne d'espacement */
            Console.WriteLine("2. Effectuer un transfert");
            Console.WriteLine("3. Consulter le solde");
            Console.WriteLine("4. Quitter");
        }

        /* fonction : option d'un dépot */

        void depositFR(cardHolder U)
        {
            Console.WriteLine("Combien d'argent souhaitez-vous déposer ?");
            double deposit = Double.Parse(Console.ReadLine());
            U.setBalance(deposit);

            Console.WriteLine("Merci pour votre dépôt. Votre solde s'élève maintenant à " + user.getBalance());
        }

        /* fonction : option d'un transfert */

        void withdrawFR(cardHolder U)
        {
            Console.WriteLine("Combien d'argent souhaiterais-tu tranférer ?");
            double withdrawal = Double.Parse(Console.ReadLine());
            double total = U.getBalance();
            if (withdrawal > total)
                
            {

                Console.WriteLine("ERROR : Solde insuffisant..");
 
            }
            else
            {
                U.setBalance(total - withdrawal);

                Console.WriteLine("Merci, le transfert est fait.");
            };
        }
        /* fonction : option d'une consultation du solde */

        void balanceFR(cardHolder user)
        {
            Console.WriteLine("Votre solde actuel : " + user.getBalance());
        }

        /* Liste d'adhérents*/
        List<cardHolder> listHolder = new List<cardHolder>();

        /* création/ajout de nouveaux adhérents*/
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
        Console.WriteLine("   BIENVENUE CHEZ SimpleATM.     ");
        Console.WriteLine(" ");

        String debitCardNum = "";


        /* -- Etape : numéro de carte -- */
        while (true)
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("Entrer votre carte (numéro identificateur de celle-ci)).");
                debitCardNum = Console.ReadLine();
                //Vérifier si le numéro de carte entré (ci-dessus) appartient/correspond à celui d'un "holder" de notre liste de holders
                user = listHolder.FirstOrDefault(a => a.cardNum == debitCardNum);

                if (user != null) { break; }
                else
                {
                    Console.WriteLine("Carte non reconnue : numéro identificateur invalide.");
                }

            }
            catch
            {
                Console.WriteLine("Carte non reconnue : numéro identificateur invalide.");
            }
        }

        /* -- Etape : code pin -- */

        Console.WriteLine("Entrer votre code secret (pin).");


        int pinC = 0;

        while (true)
        {
            try
            {
                pinC = int.Parse(Console.ReadLine());

                if (user.getPin() == pinC) { break; }
                else
                {
                    Console.WriteLine("Mauvais code. Veuillez réssayez s'il vous plaît.");

                }

            }
            catch
            {
                Console.WriteLine("Mauvais code. Veuillez réssayez s'il vous plaît.");
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

        Console.WriteLine("Bienvenue " + user.getPrenom() + " " + user.getNom() + " : ) ");
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

            if (option == 1) { depositFR(user); }
            else if (option == 2) { withdrawFR(user); }
            else if (option == 3) { balanceFR(user); }
            else if (option == 4) { break; }
            else { option = 0; }
        } while (option != 4);

        Console.WriteLine(" ");
        Console.WriteLine("A bientôt ! Au fait, passez une bonne journée !");
        Console.WriteLine(" ");
    }
}