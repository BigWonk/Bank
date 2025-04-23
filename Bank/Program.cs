List<string> users = new List<string>();
int balance = 10000;
string koi = "";
int pari = 0;
string izbor = "";
List<int> parite = new List<int>();
string[] user = { "Skibidi", "Mazniq", "PeshoSlepiq" };
string[] password = { "Jockey34", "DimovFL9", "NzSlapSum27" };

for (int i = 0; i < user.Length; i++)
{
    for (int j = 0; j < password.Length; j++)
    {
        Console.WriteLine(user[i]);
        Console.WriteLine(password[j]);

        if (user [j] == "Skibidi" && password[i] == "Jockey34")
        {
            Console.WriteLine("Suvpada");
        }
        else if (user[j] == "Mazniq" && password[i] == "DimovFL9") 
        {
            Console.WriteLine("Suvpada");
        }
        else if (user[j] == "PeshoSlepiq" && password[i] == "NzSlapSum27")
        {
            Console.WriteLine("Suvpada");
        }
        else
        {
            Console.WriteLine("Nesuvpada");

        }



    }
}

while (izbor != "e")
{
    Console.WriteLine("Kakvo iskate da napravite?");
    Console.WriteLine("1. Da vidite balansa si");
    Console.WriteLine("2. Tranzakciq do drug user");
    Console.WriteLine("3. Istoriq na tranzaciite");
    Console.WriteLine("e. Izlez");

    izbor = Console.ReadLine();
    switch (izbor)
    {
        case "1":
            Console.WriteLine($"Vashiq balans e {balance}$");
            break;
        case "2":
            Console.WriteLine("Do kogo iskate da pratite pari?");
            koi = Console.ReadLine();
            users.Add(koi);
            Console.WriteLine("Kolko pari iskate da izrpratite?");
            pari = int.Parse(Console.ReadLine());
            parite.Add(pari);
            if (pari < balance)
            {
                Console.WriteLine("Uspeshno napravena transakciq!");
                balance -= pari;
            }
            else
            {
                Console.WriteLine("Ne uspeshno napravena transakciq!");
            }
            break;
        case "3":
            for (int i = 0; i < users.Count; i++)
            { 
            Console.WriteLine($"Izprateni do {users[i]} na stoinost ot {parite[i]}$");
            }
        break;
        
        case "e":
                
            Console.WriteLine("Izhod");
                break;
            

                
    }
}    



