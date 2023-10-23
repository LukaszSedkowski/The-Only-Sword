using System.Media;
using static System.Console;
using System.IO;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.Start();                         //wywołanie gry
        }
    }
}


class Game
{
    public void Start()
    {

        RunMainMenu();
    }
    private void RunMainMenu()
    {
        Title ="The Only Sword";

        deep_menu();
        void deep_menu()
        {
            string prompt = "The Only Sword";
            string[] option_main = { "Graj","Autorzy","Wyjdź z Gry" };                //opcje menu_glownego
            Menu MainMenu = new Menu(prompt,option_main);                                          //wywolanie klasy i nadanie opcji z option_main
            int Menu_Choice = MainMenu.Run();
            switch (Menu_Choice)                                                          //opcje menu glownego
            {
                case 0:
                    skip();
                    break;
                case 1:
                    DisplayAboutInfo();                                                 //wywolanie info o autorze
                    break;
                case 2:
                    ExitGame();                                                            //wywolanie zapytania o koniec gry
                    break;          

            }
        }
            void DisplayAboutInfo()                                                     //funkcja info o autorze
        {
                        Clear();
            WriteLine($@"Game created by Łukasz Luki Sędkowski Company, czy jakoś tak XD
+muzuka i efekty dźwiękowe z gier/filmów:
-Wiedźmin
-Gothic
-Dawn Of War
-Władca Pierścieni
-i kilka innych losowych dźwięków
Proszę nie pozywać nic na tym nie zarabiam itp. :) 

Wciśnij dowolny przycisk aby wrócić");
                        ReadKey();
                        deep_menu();
            }


    void ExitGame()
    {
            Clear();
            string[] quit_option = { "tak", "nie" };
            string tytul = "Czy na pewno chcesz zakończyć grę?";                               //potwierdzenie zakonczenia gry
            Menu QuitMenu = new Menu(tytul, quit_option);
            int Game_End = QuitMenu.Run();
            switch (Game_End)
            {
                case 0:
                    Clear();
                    Environment.Exit(0);
                    break;
                case 1:
                    deep_menu();                                                                        //powrót do menu
                    break;
            }
    }
    }


    void skip()                                     //skip historii
    {
        Clear();
        string[] quit_option = { "tak", "nie" };
        string tytul = "Czy chcesz pominąć historię?";
        Menu QuitMenu = new Menu(tytul, quit_option);
        int Game_End = QuitMenu.Run();
        switch (Game_End)
        {
            case 0:
                Clear();
                town_begin();
                break;
            case 1:
                short_story();
                break;
        }
    }
    private void short_story()                  //funkcja jakaś historia na start
    {
        Clear();
            WriteLine("Jest rok 1136...");
            Thread.Sleep(2000);
            WriteLine("Prowadzona jest aktualnie wojna, między obecnym królem Grzegorzem Słomą I Wielkim, a rebeliantami...");
            Thread.Sleep(4000);
            WriteLine("Kilka dni temu odegrała się jedna z większych potyczek, dotychczas jakie miały miejsce...");
            Thread.Sleep(4000);
            WriteLine("Jako biedak, który chce coś zarobić stwierdzasz, że ograbisz zwłoki poległych w tej walce...");
            Thread.Sleep(4000);
            WriteLine("Przy jednym ze zniszczonych wozów znajdujesz papier wyglądający jak mapa...");
            Thread.Sleep(4000);
            WriteLine("Udajesz się we wskazane miejsce i otwierasz kryptę...");
            Thread.Sleep(4000);
            WriteLine("W krypcie znajdujesz miecz i mase najzwyklejszych napisów, ale ty nie umiesz czytać...");
            Thread.Sleep(4000);
            WriteLine("Na szczęście po dotknięciu ostrza, w twojej głowie ukazuje się historia obrazkowa zarówno miecza jak i tego miejsca...");
            Thread.Sleep(4000);
            WriteLine("Miecz Żywiołów prosi cię o zniszczenie żywiołaka, dewastującego sanktuarium równowagi inaczej świat czeka zagłada...");
            Thread.Sleep(4000);
            WriteLine("Świat już zaczął tracić balans, a wszystko zaczyna zmieniać swoją formę w jakiś żywioł...");
            Thread.Sleep(4000);
            WriteLine("Nie interesują cię losy świata, lecz mimo to zgadasz się...");
            Thread.Sleep(4000);
            WriteLine("Widzisz, że ostrze jest wyblakłe i słabe, a sam nie jesteś jakimś super bohaterem...");
            Thread.Sleep(4000);
            WriteLine("Uświadamiasz sobie, że będzie to długa przygoda...");
            Thread.Sleep(2000);
            WriteLine("");
        
        WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
        ReadKey();
        town_begin();
    }

    private int klasa_postaci()                 //funkcja nadająca wartość klasy postaci
    {
        string kl_choice = "Za dzieciaka śniłeś, że jesteś...";
        string[] klasy = { "Wojownikiem", "Magiem","Biznesmenem", "Nikim szczególnym" };
        Menu klasa_menu = new Menu(kl_choice, klasy);
        int class_choice = klasa_menu.Run();
        switch (class_choice)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 3;
            default:
                return 3;
        }
    }
    private int game_lvl()              //funkcja nadająca poziom trudności
    {
        string lvl_prompt = "Na jakim poziomie chcesz zagrać?";
        string[] lvle = { "Normalny - Przegrana oznacza utratę pieniędzy", "Hardcore - Przegrana oznacza koniec gry" };
        Menu lvl_menu = new Menu(lvl_prompt, lvle);
        int lvl = lvl_menu.Run();
        switch (lvl)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            default:
                return 0;
        }
    }
    private void town_begin()               //funkcja nadająca wszystkie podstawowe wartości
    {
        int klasa = klasa_postaci();
        int game_hard = game_lvl();
        int[] rs = new int[5];
        int[] dmg = new int[5];
        for (int i = 0; i < 5; i++)
        {
            rs[i] = 5;                  //tworzenie się wartości na resisty i dmg po kolei fizyczne, ogień, woda, powietrze, skała
            dmg[i] = 5;
        }
        int day_number = 1;
        int health_ring = 5;
        int mana_ring = 10;
        double max_mana = 0;
        double max_hp = 0;
        double money_bag = 0;
        int licznik_dnia = 0;
        int[] speel_book = new int[] { 0, 0, 0 };
        //profity z klasy
        if (klasa == 3)                     //nikt
        {
            max_hp = 95 + health_ring;
            money_bag = 5000;
            max_mana = 10 + mana_ring;
        }
        else if(klasa==1)                   //mag
        {
            max_hp = 45 + health_ring;
            money_bag = 10;
            max_mana = 95 + mana_ring;
        }
        else if (klasa == 0)                //wojownik
        {
            max_hp = 65 + health_ring;
            money_bag = 10;
            max_mana =0+ mana_ring;
        }
        else if (klasa==2)                  //biznesmen
        {
            max_mana = 5 + mana_ring;
            max_hp = 45 + health_ring;
            money_bag = 200;
        }
        double mana = max_mana;
        double hp = max_hp;
        int health_potion = 0;
        int mana_potion = 0;
        string[] pora_dnia = new string[] {"Poranek","Południe","Wieczór" };
        town();
        void town()                 //najważniejsza "menu" funkcja gdzie wszystko się dzieje
        {
            music();
            while (true)
            {
                Clear();
                string t_choice = $"Dzień {day_number} - {pora_dnia[licznik_dnia]}. Dokąd chcesz się udać?";
                string[] town_options = { "Wyprawa","Zaklinacz", "Płatnerz","Jublier","Alchemik","Mag","Łowienie Ryb","Medyk","Medytacja","Pokaż eq i statystyki","Zapisz/Wczytaj Grę","Zakończ Przygodę"};
                Menu town_menu = new Menu(t_choice, town_options);
                int town_choice = town_menu.Run();
                switch (town_choice)
                {
                    case 0:
                        potwory();
                        break;
                    case 1:
                        mistyk_upgrader();
                        break;
                    case 2:
                        armor_upgrader();
                        break;
                    case 3:
                        jubiler();
                        break;
                    case 4:
                        alchemik();
                        break;
                    case 5:
                        wizard();
                        break;
                    case 6:
                        fishing_accept();
                        break;
                    case 7:
                        medyk();
                        break;
                    case 8:
                        medytacja();
                        break;
                    case 9:
                        staty();
                        break;
                    case 10:
                        save_load_together();
                        break;
                    case 11:
                        end_in_game();
                        break;
                }
            }


            void save_load_together()                   //menu dla wczytania i zapisania
            {
                string save_load_prompt = $"Co chcesz zrobić?";
                string[] save_load_choice = { "Zapisz Grę", "Wczytaj Grę","Powrót" };
                Menu save_load_menu = new Menu(save_load_prompt, save_load_choice);
                int sl = save_load_menu.Run();
                switch (sl)
                {
                    case 0:
                        save();
                        break;
                    case 1:
                        load();
                        break;
                    case 2:
                        break;
                }
            }
            void medytacja()                //regeneruje mane przez 30 sec
            {
                Clear();
                if(mana==max_mana)
                {
                    WriteLine("Twoja mana jest pełna i nie będziesz marnował czasu na medytacje!!!");
                    WriteLine("");
                    WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                    ReadKey();
                    town();
                }
                string medytacja_p = $"Czy na pewno chcesz medytować?";
                string[] medytacja_yes = { "Tak", "Nie"};
                Menu medytacja_menu = new Menu(medytacja_p, medytacja_yes);
                int medyt = medytacja_menu.Run();
                switch (medyt)
                {
                    case 0:
                        Clear(); 
                        int x = 30;
                        WriteLine("To będzie długa i przyjemna medytacja...");
                        Thread.Sleep(2000);
                        Clear();
                        while (x > 0)
                        {
                            WriteLine($"Czas upływał powoli... Do końca pozostało {x} sec.");
                            Thread.Sleep(1000);
                            Clear();
                            x--;
                        }
                        WriteLine("Odnowiono całą mane!!!");
                        WriteLine("");
                        WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                        ReadKey();
                        mana = max_mana;
                        licznik_dnia++;
                        town();
                        break;
                    case 1:
                        town();
                        break;
                }
            }

            void save()             //troszkę rakowy sposób zapisu
            {
                Clear();
                try
                {
                    StreamWriter zapis = new StreamWriter("save.txt");
                    zapis.WriteLine(max_hp);
                    zapis.WriteLine(hp);
                    zapis.WriteLine(health_ring);
                    zapis.WriteLine(max_mana);
                    zapis.WriteLine(mana);
                    zapis.WriteLine(mana_ring);
                    zapis.WriteLine(money_bag);
                    zapis.WriteLine(day_number);
                    zapis.WriteLine(licznik_dnia);
                    zapis.WriteLine(speel_book[0]);
                    zapis.WriteLine(speel_book[1]);
                    zapis.WriteLine(speel_book[2]);
                    for (int x = 0; x < 5; x++)
                    {
                        zapis.WriteLine(rs[x]);
                        zapis.WriteLine(dmg[x]);
                    }
                    zapis.WriteLine(health_potion);
                    zapis.WriteLine(mana_potion);
                    zapis.WriteLine(klasa) ;
                    zapis.WriteLine(game_hard);
                    zapis.Close();
                }
                finally
                {
                    WriteLine("Gra została zapisana!");
                    Thread.Sleep(2500);
                }
            }

            void load()             //jeszcze bardziej upośledzony sposób wczytania
            {
                Clear();
                try
                {
                    StreamReader wczyt = new StreamReader("save.txt");
                    double.TryParse(wczyt.ReadLine(), out max_hp);
                    double.TryParse(wczyt.ReadLine(), out hp);
                    int.TryParse(wczyt.ReadLine(), out health_ring);
                    double.TryParse(wczyt.ReadLine(), out max_mana);
                    double.TryParse(wczyt.ReadLine(), out mana);
                    int.TryParse(wczyt.ReadLine(), out mana_ring);
                    double.TryParse(wczyt.ReadLine(), out money_bag);
                    int.TryParse(wczyt.ReadLine(), out day_number);
                    int.TryParse(wczyt.ReadLine(), out licznik_dnia);
                    int.TryParse(wczyt.ReadLine(), out speel_book[0]);
                    int.TryParse(wczyt.ReadLine(), out speel_book[1]);
                    int.TryParse(wczyt.ReadLine(), out speel_book[2]);
                    for (int x = 0; x < 5; x++)
                    {
                        int.TryParse(wczyt.ReadLine(), out rs[x]);
                        int.TryParse(wczyt.ReadLine(), out dmg[x]);
                    }
                    int.TryParse(wczyt.ReadLine(), out health_potion);
                    int.TryParse(wczyt.ReadLine(), out mana_potion);
                    int.TryParse(wczyt.ReadLine(), out klasa);
                    int.TryParse(wczyt.ReadLine(), out game_hard);
                    wczyt.Close();
                }
                catch (Exception)
                {
                    WriteLine("Nie ma aktualnie żadnego zapisu...");
                    Thread.Sleep(2500);
                    town();
                }
                finally
                {
                    WriteLine("Wczytywanie Gry...");
                    Thread.Sleep(2500);
                    town();
                }
            }

            void wizard()                       //sklep z magią wybór
            {
                Clear();
                while (true)
                {
                    string wizard_prompt = $"Jaką magię chciałbyś ulepszyć?";
                    string[] wizard_spells = { "Uzdrowienie", "Zwiększenie Mocy Magicznej", "Pocisk Prawdziwej Magii", "Powrót" };
                    Menu wizard_menu = new Menu(wizard_prompt, wizard_spells);
                    int spell_run = wizard_menu.Run();
                    switch (spell_run)
                    {
                        case 0:
                            speel_book[0] = magic_upgrade(speel_book[0]);
                            break;
                        case 1:
                            speel_book[1] = magic_upgrade(speel_book[1]);
                            break;
                        case 2:
                            speel_book[2] = magic_upgrade(speel_book[2]);
                            break;
                        case 3:
                            town();
                            break;
                    }
                }
            }
            int magic_upgrade(int moc)              //sklep z magią potwierdzenie zakupu
            {
                Clear();
                    int magic_up_cost = (20 * moc)+150 ;
                    string m_upgrade_prompt = $"Czy na pewno chcesz ulepszyć podaną magię za {magic_up_cost} złota?";
                    string[] magic_yes = { "Tak", "Nie" };
                    Menu magic_menu = new Menu(m_upgrade_prompt, magic_yes);
                    int upg = magic_menu.Run();
                    switch (upg)
                    {
                        case 0:
                            if (money_bag < magic_up_cost)
                            {
                                Clear();
                                WriteLine("Posiadasz za mało złota!!!");
                                Thread.Sleep(1500);
                            }
                            else
                            {
                                Clear();
                                money_bag = money_bag - magic_up_cost;
                                moc = moc + 10;
                            }
                                return moc;
                        case 1:
                            wizard();
                            return moc;
                        default:
                            return moc;
                    }
                
                }

                void alchemik()             //funkcja do kupowania potek
                {
                while (true)
                {

                    Clear();
                    string potions_prompt = $"Jaki eliksir chcesz kupić?";
                    string[] potion_choice = { "Eliksir Zdrowia", "Eliksir Many", "Powrót" };
                    Menu potion_menu = new Menu(potions_prompt, potion_choice);
                    int potions = potion_menu.Run();
                    switch (potions)
                    {
                        case 0:
                            Clear();
                            health_potion=potion_buying(health_potion);
                            break;
                        case 1:
                            mana_potion=potion_buying(mana_potion);
                            Clear();
                            break;
                        case 2:
                            town();
                            break;
                    }
                }
                    int potion_buying(int potka)        //potwierdzenie zakupu potek
                    {
                    string pot_prompt = $"Czy na pewno chcesz kupić eliksir za 500 złota?";
                    string[] potion_yes = { "Tak", "Nie" };
                    Menu potion_menu = new Menu(pot_prompt, potion_yes);
                    int potions = potion_menu.Run();
                    switch (potions)
                    {
                        case 0:
                            return potka_check();
                        case 1:
                            alchemik();
                            return 0;
                        default:
                            return 0;
                    }
                    int potka_check()               //sprawdzenie czy stać na kupienie potek
                    {

                        if (money_bag >= 500)
                        {
                            money_bag = money_bag - 500;
                            potka++;
                        }
                        else
                        {
                            Clear();
                            WriteLine("Masz za mało złota");
                            Thread.Sleep(1500);
                        }
                        return potka;

                    }
                }

            }
            void potions_brake()                //funkcja psująca potki gdy jest ich za dużo XD
            {
                if (health_potion + mana_potion > 10)
                {
                    Clear();
                    WriteLine("Zabrałeś za dużo eliksirów i na nieszczęście wszystkie się potłukły!!! (Nie kupuj nigdy więcej niż 10)");
                    Thread.Sleep(4000);
                    Clear();
                    health_potion = 0;
                    mana_potion = 0;
                }
            }


            void end_in_game()
            {

                    Clear();
                    string[] quit_option = { "tak", "nie" };
                    string tytul = "Czy na pewno chcesz zakończyć przygodę?";                               //potwierdzenie zakonczenia gry
                    Menu QuitMenu = new Menu(tytul, quit_option);
                    int Game_End = QuitMenu.Run();
                    switch (Game_End)
                    {
                        case 0:
                        RunMainMenu();
                            break;
                        case 1:                                                                    //powrót do menu
                            break;
                   }
                
            }

            void potwory()              //wybór miejsca walki
            {
                Clear();
                string battlefield_p = $"W jakie niebezpieczne miejsce chcesz się udać?";
                string[] battle_places = {"Portowy zaułek","Arena","Mroczny Las","Wyschnięte Góry","Gorące Groty","Portal Pustki","Sanktuarium Równowagi","Powrót"};
                Menu battlezone = new Menu(battlefield_p, battle_places);
                int battlezone_menu = battlezone.Run();
                switch (battlezone_menu)
                {
                    case 0:
                        Clear();
                        potions_brake();
                        mob_prep(3, 0);
                        break;
                    case 1:
                        Clear();
                        potions_brake();
                        mob_prep(6, 5);
                        break;
                    case 2:
                        Clear();
                        potions_brake();
                        mob_prep(9, 10);
                        break;
                    case 3:
                        Clear();
                        potions_brake();
                        mob_prep(12, 15);
                        break;
                    case 4:
                        Clear();
                        potions_brake();
                        mob_prep(15, 20);
                        break;
                    case 5:
                        Clear();
                        potions_brake();
                        mob_prep(18, 25);
                        break;
                    case 6:
                        warning();
                        Clear();
                        potions_brake();       
                        mob_prep(30,30);            //finall boss
                        break;
                    case 7:
                        break;
                }
                void warning()              //ostrzeżenie do ostatniego bossa
                {
                    string boss_prompt = @"Jest to ostatnia lokacja w grze z finalnym bossem, gdzie walka toczy się do końca i można zginąć.
Jesteś pewien, że chcesz się tam udać?";
                    string[] boss_yes = { "Tak", "Nie" };
                    Menu finnal_menu = new Menu(boss_prompt, boss_yes);
                    int bye = finnal_menu.Run();
                    switch (bye)
                    {
                        case 1:
                            break;
                        case 2:
                            potwory();
                            break;
                    }
                }
            }

            void jubiler()              //funkcja wzmacniająca pierścienie
            {
                while (true)
                {

                    string jub_pr = "Co chciałbyś ulepszyć?";
                    string[] jub_choice = { $"Pierścień Zdrowia", $"Pierścień Many", "Powrót" };
                    Menu jub_menu = new Menu(jub_pr, jub_choice);
                    int jub = jub_menu.Run();
                    int d = 0;
                    switch (jub)
                    {
                        case 0:
                            d=up_check(health_ring);
                            if (d == 1)
                            {
                                health_ring = upgrade_accept(health_ring);
                                max_hp = max_hp + 5;
                                hp = hp + 5;
                            }
                            break;
                        case 1:
                            d = up_check(mana_ring);
                            if (d == 1)
                            {

                                mana_ring = upgrade_accept(mana_ring);

                                max_mana = max_mana + 5;
                                mana = mana + 5;
                            }
                                break;
                        case 2:
                            town();
                            break;
                    }
                }
                int up_check(int pay)           //sprawdzenie czy masz złota na upgrade pierścieni
                {
                    if (klasa == 2)
                    {
                        pay = pay * 18;
                    }
                    else
                    {
                        pay = pay * 20;
                    }
                    if (money_bag >= pay)
                    {
                        return 1;
                    }
                    else
                    {
                        Clear();
                        WriteLine($"Masz za mało złota. (Potrzeba {pay}) ");
                        Thread.Sleep(1500);
                        return 0;
                    }
                }

            }


                void medyk()            //funkcja medyka, który cię leczy do max hp 
                {
                double healing_cost = (max_hp - hp) * 5;
                if (healing_cost == 0)
                {
                    Clear();

                    WriteLine("Medyk z daleka widzi, że jesteś bez szwanku i każe ci od razu wyjść!!!");
                    WriteLine("");
                    WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                    ReadKey();
                    town();
                }

                string heal_prompt = $"Wyleczenie ze wszystkich ran będzie kosztować {Math.Round(healing_cost,2)} złota.";
                string[] heal_agree = { "Tak", "Nie" };
                Menu heal_menu = new Menu(heal_prompt, heal_agree);
                int heal_accept = heal_menu.Run();
                switch (heal_accept)
                {
                    case 0:
                        if (money_bag < healing_cost)
                        {
                            Clear();

                            WriteLine("Masz za mało złota na wyleczenie ran");
                            WriteLine("");
                            WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                            ReadKey();
                            town();
                        }
                        else if (money_bag >= healing_cost)
                        {
                            Clear();

                            WriteLine("Wyleczyłeś się ze wszystkich ran!!!");
                            WriteLine("");
                            WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                            money_bag = money_bag - healing_cost;
                            hp = max_hp;
                            ReadKey();
                            town();
                        }
                        break;
                    case 1:
                        town();
                        break;
                }
            }

            void armor_upgrader()                       //kowal ulepszanie res[]
            {
                while (true)         
                {
                    Clear();
                    string bl_pr = "Co chciałbyś ulepszyć?";
                    string[] blacks_choice = { "Napierśnik - Odporność na Fizyczne", "Rękawice - Odporność na Ogień", "Buty - Odporność na Wode", "Peleryna - Odporność na Powietrze", "Hełm - Odporność na Kamień ", "Powrót" };
                    Menu blacksmith = new Menu(bl_pr, blacks_choice);
                    int menu_black = blacksmith.Run();
                    switch (menu_black)
                    {
                        case 0:
                            rs[0] = upgrade_accept(rs[0]);
                            break;
                        case 1:
                            rs[1] = upgrade_accept(rs[1]);
                            break;
                        case 2:
                            rs[2] = upgrade_accept(rs[2]);
                            break;
                        case 3:
                            rs[3] = upgrade_accept(rs[3]);
                            break;
                        case 4:
                            rs[4] = upgrade_accept(rs[4]);
                            break;
                        case 5:
                            town();
                            break;
                        default:
                            break;
                    }                                                                                   
                }

            }

            void mistyk_upgrader()                      //mistyk ulepszanie dmg
            {
                while (true)                                                                                    
                {
                    Clear();
                    string bl_pr = "Jak chciałbyś ulepszyć swój miecz?";
                    string[] blacks_choice = { "Ostrze - Atak Fizyczny", "Czerwony Klejnot - Atak od Ognia", "Niebieski Klejnot - Atak od Wody", "Biały Klejnot - Atak od Powietrza", "Zielony Klejnot - Atak od Kamienia", "Powrót" };
                    Menu mistyk = new Menu(bl_pr, blacks_choice);
                    int menu_mistyk = mistyk.Run();
                    switch (menu_mistyk)
                    {
                        case 0:
                            dmg[0] = upgrade_accept(dmg[0]);
                            break;
                        case 1:
                            dmg[1] = upgrade_accept(dmg[1]);
                            break;
                        case 2:
                            dmg[2] = upgrade_accept(dmg[2]);
                            break;
                        case 3:
                            dmg[3] = upgrade_accept(dmg[3]);
                            break;
                        case 4:
                            dmg[4] = upgrade_accept(dmg[4]);
                            break;
                        case 5:
                            town();
                            break;
                        default:
                            break;
                    }                                                                                   
                }
            }
            void music()                                //muzyka zależna od pory dnia i spanie
            {
                if (licznik_dnia == 0)
                {

                }
                else if (licznik_dnia == 1)
                {

                }
                else if (licznik_dnia == 2)
                {

                }
                else if (licznik_dnia == 3)
                {
                    string day_prompt = $"Nastała noc, gdzie chcesz się przespać? Noc w gospodzie będzie kosztować {Math.Round(money_bag * 0.1,2)} złota";
                    string[] day_options = { "Gospoda", "Ulica" };
                    Menu day = new Menu(day_prompt, day_options);
                    int day_menu = day.Run();
                    switch (day_menu)
                    {
                        case 0:
                            money_bag = Math.Round(money_bag * 0.9,2);
                            Clear();
                            WriteLine("Warunki w gospodzie są wyśmienite i beztrosko się wysypiasz.");
                            WriteLine("");
                            WriteLine("Wciśnij dowolny przycisk aby kontynuować");
                            ReadKey();
                            break;
                        case 1:
                            Random thiev = new Random();
                            int stealing = thiev.Next(0, 2);
                            Clear();
                            if (stealing == 0)
                            {
                                WriteLine("Pomimo ulicznych warunków spało ci się dobrze i o dziwo nic ci nie zniknęło.");
                                WriteLine("");
                                WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                ReadKey();
                            }
                            else if (stealing == 1)
                            {
                                money_bag = 0;
                                WriteLine("Spanie na ulicy nie było dobrym pomysłem...");
                                WriteLine("Okradziono cię z całego złota!!!");
                                WriteLine("");
                                WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
                                ReadKey();
                            }
                            break;
                    }
                    day_number++;
                    licznik_dnia = 0;
                    town();
                }
            }
            void staty()                //wypisanie wszystkich statystyk
            {
                Clear();
WriteLine(@$"Maksymalne Zdrowie: {max_hp}
Aktualne Zdrowie: {hp}

Maksymalna Mana: {max_mana}
Aktualna Mana: {mana}

Atak:
Fizyczne - {dmg[0]}
Ogień - {dmg[1]}
Woda - {dmg[2]}
Powietrze - {dmg[3]}
Kamień - {dmg[4]}

Obrona:
Fizyczne - {rs[0]}
Ogień - {rs[1]}
Woda - {rs[2]}
Powietrze - {rs[3]}
Kamień - {rs[4]}

Aktualna moc zaklęć:
Uzdrowienie - {speel_book[0]}
Zwiększenie mocy magicznej - {speel_book[1]/2}
Pocisk prawdziwej magii - {speel_book[2]}

Ilość przedmiotów:
Złoto - {Math.Round(money_bag,2)}
Eliksir Zdrowia - {health_potion}
Eliksir Many - {mana_potion}

Wciśnij dowolny przycisk, aby kontynuować...
        ");
                ReadKey();
            }
        }
        int upgrade_accept(int stat)                //kowal i inni ulepszanie
        {
            Clear();
            int up = 0;
            if (klasa == 2)
            {
                up = 18 * stat;
            }
            else
            {
                up = 20 * stat;
            }
            string ace_yes_not = $"Czy na pewno chcesz ulepszyć dany przedmiot? Ulepszenie będzie kosztować {up} złota.";
            string[] yes_not = { "Tak", "Nie" };
            Menu accept = new Menu(ace_yes_not,yes_not);
            int menu_accept = accept.Run();
            switch (menu_accept)
            {
                case 0:
                    if (money_bag >= up)
                    {
                        stat = stat + 5;
                        money_bag = money_bag - up;
                    }
                    else
                    {
                        Clear();
                        WriteLine("Masz za mało złota...");
                        Thread.Sleep(1500);
                    }
                    return stat;
                case 1:
                    return stat;
                default:
                    return stat;
            }
        }
        void fishing_accept()               //potwierdzenie czy chcesz łowić ryby
        {
            Clear();
            string fishing_prompt = $"Czy na pewno chcesz łowić ryby?";
            string[] fishing_accept = { "Tak","Nie" };
            Menu fishing_time = new Menu(fishing_prompt, fishing_accept);
            int fishing_menu = fishing_time.Run();
            switch (fishing_menu)
            {
                case 0:
                    anoying_money();
                    break;
                case 1:
                    town();
                    break;
            }
        }

        void anoying_money()                //łowienie ryb i marny zarobek
        {
            Clear();
            int finded= 0;
            int x = 15;
            WriteLine("To będzie długie i męczące zadanie...");
            Thread.Sleep(2000);
            Clear();
            while (x > 0)
            {
                x--;
                WriteLine($"Licznik złapanych ryb: {finded}");
                WriteLine($"Czas upływał powoli... Do końca pozostało {x} sec.");
                Random chr = new Random();
                int chased = chr.Next(0, 4);
                Thread.Sleep(1000);
                Clear();
                if (chased < 2)
                {
                    Random fish_number = new Random();
                    int fish_random = fish_number.Next(2, 4);
                    finded=finded+fish_random;
                    Clear();
                }
            }
            money_bag = money_bag + (finded * 15);
            WriteLine($"Finalnie złowiono {finded} ryb i zarobiono {finded * 15} złota!!!");
            WriteLine("Wciśnij dowolny przycisk aby kontynuować");
            ReadKey();
            licznik_dnia++;
            town();
        }

        
        

        //---------------------------------------------------------------------------------------------------//

        void mob_prep(int tier,int name_plus)               //przygotowywanie mobów na podstawie kilku tablic
        {
            
            string[] mob_type = new string[] {"Potężny","Ognisty","Wodny","Powietrzny","Kamienny" };

            Random rn = new Random();
            int part_1 = rn.Next(0, 5);
            int[] mob_res = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Random p = new Random();
                mob_res[x] = p.Next(5, 10);
                mob_res[x] = mob_res[x] * tier;
            }                                           //tworzenie się odporności przeciwnika, ulepszenie głównej statystyki i nadanie 1 człona nazwy
            mob_res[part_1] = mob_res[part_1] * tier;

            string[] mob_name = new string[] { "Pijak", "Menel", "Narkoman", "Zjaraniec", "Żul",
            "Lew","Młody Gladiator","Wojownik","Morderca","Goryl",
            "Wilk","Krwiożerczy Wiewiór","Niedźwieź","Elf","Skrzat",
            "Goblin","Szakal","Troll","Ork","Ogr",            
            "Dinozaur","Jaszczur","Młody Smok","Jaszczuro-Człowiek","Cerber",
            "Kąsacz","Gryzak","Obserwator","Krwiopijca","Skałożerca",
            "Żywiołak"};
            double[] mob_hp = new double[] { 100, 170, 200, 130, 150 };
            Random rnd = new Random();
            int part_2 = rnd.Next(0, 5);
            mob_hp[part_2] = mob_hp[part_2] * (tier / 3);
            int real_race = part_2 + name_plus;             //tworzenie się zdrowia przeciwnika i nadanie 2 człona nazwy


            string[] mob_atack = new string[] { "Ze Sztyletem", "Z Zapalniczką", "Z Mokrymi Rękami", "Z Torebką Powietrza", "Z Kamieniami",
            "Z Toporem", "Z Płonącymi Rękami", "Z Butelką Wody", "Z Mocnymi Płucami", "Ze Skałką"
            ,"Z Mieczem", "Z Płonącym Ogonem", "Z Wiadrem Wody", "Z Przenośnym Wiatrakiem", "Z Głazem"
            ,"Z Kastetami", "Z Pochodnią", "Z Baniakiem Wody", "Z Liściem Palmowym", "Z Gruzem"
            ,"Z Ostymi Szponami", "Z Płonącym Językiem", "Z Kotłem Wody", "Z Zaczadzonymi Płucami", "Z Kamienną Szczęką"
            ,"Z Ręko-ostrzem", "Z Ognio-mieczem", "Z Wodnym Biczem", "Z Siarczałymi Płucami", "Z Kamienną Lancą",
            "Z Aurą Ostrzy", "Z Aurą Ognia", "Z Aurą Wody", "Z Aurą Powietrza", "Z Aurą Kamienia" };

            int[] mob_atack_numbers = new int[5];
            Random r = new Random();
            int part_3 = r.Next(0, 5);
            for (int z = 0; z < 5; z++)
            {
                mob_atack_numbers[z] = 0;
            }
            Random dmg_creator = new Random();
            int rnd_dmg = dmg_creator.Next(7,14);

            mob_atack_numbers[part_3] = rnd_dmg* tier;
            int real_weapon = part_3 + name_plus;                                       //tworzenie się dmg, nadanie 0 do wszystkich poza głównym i nadanie 3 człona nazwy

            if (tier == 30)
            {
                game_hard = 1;
                real_race = 30;
                real_weapon = part_3 + name_plus;
            }                                                   

            WriteLine($"Twoim przeciwnikiem będzie...");
            Thread.Sleep(2000);
            WriteLine($"{mob_type[part_1]} {mob_name[real_race]} {mob_atack[real_weapon]}");
            Thread.Sleep(2000);
            WriteLine("");
            WriteLine("Wciśnij dowolny przycisk aby rozpocząć walkę...");
            ReadKey();


            int player_block = 25;
            int mob_block = 25;
            int player_rounds = 0;
            int mob_rounds = 0;
            int shadow_upgrade = 0;

            
            fight();
            void fight()                //początek epickiej walki
            {
                while (mob_hp[part_2] > 0 && hp>0)
                {
                    string fight_prompt =
                    @$"Twoje hp: {hp}           {mob_hp[part_2]} :{mob_type[part_1]} {mob_name[real_race]} {mob_atack[real_weapon]}
Twoja mana: {mana}";
                    string[] fight_menu_names = { "Atak","Magia","Obrona","Przedmioty","Ucieczka" };
                    Menu fight_menu = new Menu(fight_prompt, fight_menu_names);
                    int fight_op = fight_menu.Run();
                    switch (fight_op)
                    {
                        case 0:
                            atack_type();
                            break;
                        case 1:
                            magia_fight();
                            break;
                        case 2:
                            mob_block = 20;
                            mob_rounds = 2;
                            Clear();
                            WriteLine("Zwiększono swoją szansę na zablokowanie ataku przez 3 tury!");
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            items_use();
                            break;
                        case 4:
                            tactital_retreat();
                            break;
                    }
                    if (player_block == 20)
                    {
                        player_rounds--;
                        if (player_rounds == 0)
                        {
                            Clear();
                            player_block = 25;
                        }
                    }

                    if (shadow_upgrade == 1)
                    {
                        speel_book[0] = speel_book[0] - speel_book[1] / 2;
                        speel_book[2] = speel_book[2] - speel_book[1] / 2;
                        shadow_upgrade = 0;
                    }

                    if (mob_hp[part_2] <= 0)
                    {
                        Clear();
                        licznik_dnia++;
                        Random precious = new Random();
                        int money_precious = precious.Next(50, 101);
                        money_bag = money_bag + (money_precious * tier);
                        WriteLine($"Zwyciężyłeś z {mob_type[part_1]} {mob_name[real_race]} {mob_atack[real_weapon]} i zarobiłeś {money_precious * tier*5} złota!!!");
                        WriteLine("");
                        WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                        ReadKey();
                        if (tier == 30)
                        {
                            Clear();
                            void true_ending()              //śmieszny prawdziwy koniec gry
                            {
                                string[] pociski = new string[] { "Twoje zęby są jak gwiazdy - wielkie, żółte i daleko od siebie",
                                "Jesteś rozwinięty jak papier toaletowy",
                                "Lubię cię, masz śmiech jak hamujący pociąg",
                                "Nie bądź taki do przodu, bo się sznurówki wyprzedzają",
                                "Jak cię słucham, to chce mi się wysłać sowę z wiadomością o treści pomagam",
                                "Twoja mama maluje sie w paintcie",
                                "Masz twarz jak pinokio po inwazji termitów",
                                "Sypiesz się jak choinka po trzech królach",
                                "Twój ojciec prowadzi pociąg w Teleexpresie",
                                "Schowaj się, bo na małpy polują",
                                "Kochaj deszcz. Tylko on na ciebie leci",
                                "Masz łeb jak sklep tylko półki puste...",
                                };
                                int wyzywansko_licznik = 0;
                                WriteLine("Po długiej i wyczerpującej walce myślisz, że to już koniec i w końcu odpoczniesz...");
                                Thread.Sleep(4000);
                                WriteLine("Niestety los chciał inaczej i zastałeś całą gwardię królewską z królem Grzegorzem Słomą I Wielkim na czele...");
                                Thread.Sleep(4000);
                                WriteLine("Król słysząc o twojej potędzę i czynach przybył osobiście, aby cię powstrzymać...");
                                Thread.Sleep(4000);
                                WriteLine("Wiedząc, że walcząc nie masz szans z nimi wszystkimi, wyzywasz króla na pojedynek ciętej riposty...");
                                Thread.Sleep(4000);
                                WriteLine("Niestety okazuje się, że poza byciem królem, jest również mistrzem ciętej riposty!!!");
                                Thread.Sleep(4000);

                                WriteLine("");
                                WriteLine("Wciśnij dowolny przycisk, aby rozpocząć ostateczny pojedynek!!!");
                                ReadKey();
                                for (int riposty = 0; riposty < 3; riposty++)
                                {
                                    wyzywanie();
                                    wyzywansko_licznik = wyzywansko_licznik + 4;
                                }

                                Clear();
                                WriteLine("Po druzgocącym zwycięstwie i uratowaniu świata, w końcu zaznajesz spokój, a nawet zostajesz królem i zaprowadzasz pokój!!!");
                                Thread.Sleep(4000);
                                WriteLine("Koniec...");
                                Thread.Sleep(4000);
                                WriteLine("Dziękuję za zagranie!!! Tutaj jakieś napisy końcowe powinny być, ale po co to komu? XD");
                                Thread.Sleep(4000);
                                WriteLine("");
                                WriteLine("Wciśnij dowolny przycisk, aby zakończyć grę!!!");
                                ReadKey();
                                RunMainMenu();
                                void wyzywanie()            //wyzywanie ostatniego przeciwnika
                                {
                                    Clear();
                                    WriteLine("Kolei przeciwnika!!!");
                                    Thread.Sleep(4000);
                                    WriteLine(pociski[wyzywansko_licznik]);
                                    Thread.Sleep(4000);
                                    string prompt_diss = $"Jaki będzie twój kontratak?";
                                    string[] wyzywanie_opcje = { $"{pociski[wyzywansko_licznik + 1]}", $"{pociski[wyzywansko_licznik+2]}", $"{pociski[wyzywansko_licznik+3]}" };
                                    Menu wyzywanie_menu = new Menu(prompt_diss,wyzywanie_opcje);
                                    int wyzywansko = wyzywanie_menu.Run();
                                    switch (wyzywansko)
                                    {
                                        case 1:
                                            break;
                                        case 2:
                                            break;
                                        case 3:
                                            break;
                                    }
                                }

                            }
                            true_ending();
                        }
                        town();
                    }
                    Clear();
                    WriteLine("Kolei przeciwnika!!!");
                    Thread.Sleep(2000);
                    mob_fight();
                    if (hp <= 0)
                    {
                        Clear();

                        Write($"Niestety {mob_type[part_1]} {mob_name[real_race]} {mob_atack[real_weapon]} był silniejszy, a ");
                        if (game_hard == 0)
                        {
                            licznik_dnia++;
                            money_bag = 0;
                            hp = 1;
                            Write("ty jesteś ledwo żywy i ogołocony z pieniędzy...");
                            WriteLine("");
                            WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                            ReadKey();
                            town();
                        }
                        else if (game_hard == 1)
                        {
                            File.Delete("save.txt");
                            Write("twoja przygoda dobiega końca...");
                            WriteLine("");
                            WriteLine("Wciśnij dowolny przycisk, aby zakończy grę...");
                            ReadKey();
                            Start();
                        }
                    }
                }

                void magia_fight()          //wybór magii jaką chcemy użyć
                {
                    string magia_prompt = $"Którego zaklęcia chcesz użyć?";
                    string[] magic_use_choice = { $"Uzdrowienie - {speel_book[0]}", $"Zwiększenie Mocy Magicznej - {speel_book[1]}", $"Pocisk Prawdziwej Magii - {speel_book[2]}", "Powrót" };
                    Menu magic_menu = new Menu(magia_prompt, magic_use_choice);
                    int magic_switch = magic_menu.Run();
                    switch (magic_switch)
                    {
                        case 0:
                            heal();
                            break;
                        case 1:
                            magic_power_up();
                            break;
                        case 2:
                            magic_strike();
                            break;
                        case 3:
                            fight();
                            break;
                    }
                }
                
                void heal()         //leczenie gracza za pomocą many
                {
                    Clear();
                    if (speel_book[0] == 0)
                    {
                        WriteLine("Nie potrafisz tego zaklęcia, a mówienie losowych słów nie przyniosło żadnego skutku...");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        if (speel_book[0] <= mana)
                        {
                            hp = hp + speel_book[0];
                            if (hp > max_hp)
                            {
                                hp = max_hp;
                            }
                            mana = mana - speel_book[0];

                            WriteLine($"Użyto leczenia!!!");
                            Thread.Sleep(2000);
                        }
                        else if (speel_book[0]> mana)
                        {
                            WriteLine("Masz za mało many na uleczenie...");
                            Thread.Sleep(2000);
                            magia_fight();
                        }
                    }
                }


                void magic_power_up() //zwiększenie mocy następnej zdolności
                {
                    Clear();
                    if (speel_book[1] == 0)
                    {
                        WriteLine("Nie potrafisz tego zaklęcia, a mówienie losowych słów nie przyniosło żadnego skutku...");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        if (speel_book[1] <= mana)
                        {
                            WriteLine("Twoje następne zaklęcie zostanie wzmocnione!!!");
                            mana = mana - speel_book[1];
                            speel_book[0] = speel_book[0] + speel_book[1] / 2;
                            speel_book[2] = speel_book[2] + speel_book[1] / 2;
                            shadow_upgrade = 1;
                            Thread.Sleep(2000);
                            fight();
                        }
                        else if (speel_book[1] > mana)
                        {
                            WriteLine("Posiadasz za mało many");
                            Thread.Sleep(2000);
                            magia_fight();
                        }
                    }
                }

                void magic_strike()         //pocisk zadający nieuchronne obrażenia w przeciwnika
                {
                    Clear();
                    if (speel_book[2] == 0)
                    {
                        WriteLine("Nie potrafisz tego zaklęcia, a mówienie losowych słów nie przyniosło żadnego skutku...");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        if (speel_book[2] <= mana)
                        {
                            WriteLine($"Wysyłasz magiczny pocisk w stronę przeciwnika i zadajesz {speel_book[2]} obrażeń!!!");
                            mana = mana - speel_book[2];
                            mob_hp[part_2] = mob_hp[part_2] - speel_book[2];
                            Thread.Sleep(2000);
                        }
                        else if (speel_book[2] > mana)
                        {
                            WriteLine("Posiadasz za mało many");
                            Thread.Sleep(2000);
                            magia_fight();
                        }
                    }
                }

                void items_use()                //wybór potki którą chce się użyć
                {
                    int x = 0;
                        string item_prompt = $"Czego chcesz użyć?";
                        string[] item_menu_names = { $"Eliksir Zdrowia - {health_potion}", $"Eliksir Many - {mana_potion}", "Powrót" };
                        Menu item_menu = new Menu(item_prompt, item_menu_names);
                        int item_switch = item_menu.Run();
                        switch (item_switch)
                        {
                            case 0:
                                x = 1;
                                health_potion=potki_sprawdzanie(health_potion,max_hp,hp);
                                break;
                            case 1:
                                x = 2;
                                mana_potion=potki_sprawdzanie(mana_potion,max_mana,mana);
                                break;
                            case 2:
                                fight();
                                break;
                        }
                    
                    int potki_sprawdzanie(int potka,double statystyka_max,double statystyka)        //sprawdzenie poprawnych wartości dla potek
                    {
                        if (potka <= 0)
                        {
                            Clear();
                            WriteLine("Nie masz eliksiru żeby go użyć!!!");
                            Thread.Sleep(2000);
                            items_use();
                            return potka;

                        }
                        else
                        {
                            Clear();
                            if (statystyka_max - statystyka < statystyka_max - 100)
                            {
                                statystyka = statystyka_max;
                            }
                            else if (statystyka_max-statystyka>=statystyka_max-100)
                            {
                                statystyka = statystyka + 100;
                            }
                                if (x == 1)
                                {
                                    WriteLine("Wykorzystano Eliksir Zdrowia!!!");
                                    hp= statystyka;
                                }
                                else if (x == 2)
                                {
                                    WriteLine("Wykorzystano Eliksir Many!!!");
                                    mana = statystyka;
                                }
                            
                            WriteLine("");
                            if(item_switch==0)
                            Thread.Sleep(2000);
                            potka--;
                            if (statystyka_max - statystyka < statystyka_max - 100)
                            {
                                statystyka = statystyka_max;
                            }
                            return potka;
                        }
                    }
                }
                void tactital_retreat()         //taktyczna ucieczka 
                {
                    string retreat_prompt = $"Czy na pewno chcesz ucieć?";
                    string[] retreat_menu_names = { "Tak", "Nie"};
                    Menu retreat_menu = new Menu(retreat_prompt, retreat_menu_names);
                    int retreat = retreat_menu.Run();
                    switch(retreat)
                    {
                        case 0:
                            Clear();
                            if (tier == 30)
                            {
                                WriteLine("Nie możesz się teraz wycofać, musisz walczyć do końca!!!");
                                Thread.Sleep(3000);
                                fight();
                            }

                            licznik_dnia++;
                            WriteLine("Udaje ci się uciec z pola walki, ale jesteś ranny i gubisz część swojego złota!!!");
                            WriteLine("");
                            WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                            ReadKey();
                            money_bag = money_bag * 0.5;
                            hp = hp * 0.5;
                            town();
                            break;
                        case 1:
                            fight();
                            break;
                    }
                    money_bag = money_bag * 0.5;
                    hp = hp * 0.5;
                    town();
                }

                void atack_type()           //wybór rodzaju ataku jaki chce się wykonać
                {
                    string atack_prompt = "Jaki atak chcesz wykonać?";
                    string[] atack_options = { "Szybki atak", "Średni atak", "Mocny atak", "Powrót" };
                    Menu atack_menu = new Menu(atack_prompt, atack_options);
                    int atack = atack_menu.Run();
                    switch (atack)
                    {
                        case 0:
                            mob_hp[part_2] = mele_fight(player_block * 3, 0.5);     //pierwsza wartość szanse trafienia, druga mnożnik dmg
                            break;
                        case 1:
                            mob_hp[part_2] = mele_fight(player_block * 2, 1);
                            break;
                        case 2:
                            mob_hp[part_2] = mele_fight(player_block, 1.5);
                            break;
                        case 3:
                            fight();
                            break;

                    }
                }

                double mob_fight()                  //funkcja wykonująca walkę moba
                {
                    Random chance_random = new Random();
                    int get_it = chance_random.Next(0, 101);
                    Random atack_type = new Random();
                    int type = 0;
                    if (player_block == 25)
                    {
                        type = atack_type.Next(0, 4);
                    }
                    else if (player_block == 20)
                    {

                        type = atack_type.Next(0, 3);
                    }

                    if (type == 0)
                    {
                        WriteLine("Przeciwnik Wykonuje Atak");
                        Thread.Sleep(2000);
                        hp = mob_chance(mob_block * 3, 0.5);
                    }
                    else if (type == 1)
                    {
                        WriteLine("Przeciwnik Wykonuje Atak");
                        Thread.Sleep(2000);
                        hp = mob_chance(mob_block * 2, 1);
                    }
                    else if (type == 2)
                    {
                        WriteLine("Przeciwnik Wykonuje Atak");
                        Thread.Sleep(2000);
                        hp = mob_chance(mob_block, 1.5);
                    }
                    else if (type == 3)
                    {
                        player_block = 20;
                        player_rounds = 2;
                        WriteLine("Przeciwnik zwiększył swoją obronę na 3 tury!!!");
                        Thread.Sleep(2000);
                    }


                    if (mob_block == 20)
                    {
                        mob_rounds--;
                        if (mob_rounds == 0)
                        {
                            Clear();
                            mob_block = 25;
                        }
                    }
                    return hp;

                    double mob_chance(int atack_chance,double dmg_mnoznik)          //sprawdzenie czy się trafiło udeżeniem
                    {
                        if (atack_chance >= get_it)
                        {
                            if (mob_atack_numbers[part_3] * dmg_mnoznik - rs[part_3] <= 0)
                            {
                                WriteLine("Atak przeciwnika był zbyt słaby, aby coś ci zrobić.");
                                Thread.Sleep(2000);
                            }
                            else if (mob_atack_numbers[part_3] * dmg_mnoznik - rs[part_3] > 0)
                            {
                                hp = hp - Math.Round(mob_atack_numbers[part_3] * dmg_mnoznik - rs[part_3],0);
                                WriteLine($"Przeciwnik zadał ci {Math.Round(mob_atack_numbers[part_3] * dmg_mnoznik - rs[part_3],0)} obrażeń.");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            WriteLine("Udało ci się zablokować atak!!!");
                            Thread.Sleep(2000);
                        }
                        return hp;
                    }
                }

                double mele_fight(int atack_chance,double dmg_mnoznik)          //wszystkie przeliczniki obrażeń w grze
                {
                    Clear();
                    double[] damaged_dealed = new double[5];
                    double total_dmg=0;
                    Random chance_random = new Random();
                    int get_it = chance_random.Next(0, 101);
                    if (atack_chance >= get_it)
                    {
                        WriteLine("Udało ci się wyprowadzić udany atak!!!");
                        Thread.Sleep(2000);
                        if (part_1 == 0)
                        {
                            damaged_dealed[0] = dmg[0] - mob_res[0];
                            damaged_dealed[1] = dmg[1] - mob_res[1];
                            damaged_dealed[2] = dmg[2] - mob_res[2];
                            damaged_dealed[3] = dmg[3] - mob_res[3];
                            damaged_dealed[4] = dmg[4] - mob_res[4];
                        }
                        else if (part_1 == 1)
                        {
                            damaged_dealed[0] = dmg[0] * 0.3 - mob_res[0];
                            damaged_dealed[1] = dmg[1] - mob_res[1];
                            damaged_dealed[2] = dmg[2] * 2 - mob_res[2];
                            damaged_dealed[3] = (dmg[3] - mob_res[3]) * 0;
                            damaged_dealed[4] = dmg[4] * 0.5 - mob_res[4];
                        }
                        else if (part_1 == 2)
                        {
                            damaged_dealed[0] = dmg[0] * 0.3 - mob_res[0];
                            damaged_dealed[1] = (dmg[1] - mob_res[1]) * 0;
                            damaged_dealed[2] = dmg[2] - mob_res[2];
                            damaged_dealed[3] = dmg[3] * 0.5 - mob_res[3];
                            damaged_dealed[4] = dmg[4] * 2 - mob_res[4];
                        }
                        else if (part_1 == 3)
                        {
                            damaged_dealed[0] = dmg[0] * 0.3 - mob_res[0];
                            damaged_dealed[1] = dmg[1] * 2 - mob_res[1];
                            damaged_dealed[2] = dmg[2] * 0.5 - mob_res[2];
                            damaged_dealed[3] = dmg[3] - mob_res[3];
                            damaged_dealed[4] = (dmg[4] - mob_res[4]) * 0;
                        }
                        else if (part_1 == 4)
                        {
                            damaged_dealed[0] = dmg[0] * 0.3 - mob_res[0];
                            damaged_dealed[1] = dmg[1] * 0.5 - mob_res[1];
                            damaged_dealed[2] = (dmg[2] - mob_res[2]) * 0;
                            damaged_dealed[3] = dmg[3] * 2 - mob_res[3];
                            damaged_dealed[4] = dmg[4] - mob_res[4];
                        }

                        for (int any_dmg = 0; any_dmg < 5; any_dmg++)
                        {
                            if (damaged_dealed[any_dmg] <= 0)
                            {
                                damaged_dealed[any_dmg] = 0;
                            }

                            else
                            {
                                if (klasa == 0)
                                {
                                    total_dmg = Math.Round((total_dmg + damaged_dealed[any_dmg])*2,0);
                                }
                                else
                                {
                                    total_dmg = Math.Round(total_dmg + damaged_dealed[any_dmg],0);
                                }
                            }
                        }
                        if (total_dmg <= 0)
                        {
                            WriteLine("Twój atak nie wywarł żadnego wrażenia na przeciwniku");
                            Thread.Sleep(2000);
                        }
                        else if (total_dmg > 0)
                        {
                            WriteLine($"Zadano {total_dmg * dmg_mnoznik} obrażeń.");
                            Thread.Sleep(2000);
                        }
                        mob_hp[part_2] = mob_hp[part_2] - (total_dmg * dmg_mnoznik);
                        return mob_hp[part_2];
                    }
                    else
                    {
                        WriteLine("Przeciwnik sparował atak!!!");
                        Thread.Sleep(2000);
                        return mob_hp[part_2];
                    }

                }
            }
            
        }
    }
}


class Menu                              //źródło wszystkich menu
{
    private int SelectedIndex;
    private string[] Options;
    private string Prompt;

    public Menu(string prompt,string[] options)
    {
        Prompt = prompt;
        Options = options;
        SelectedIndex = 0;
    }
    private void DisplayOptions()
    {
        WriteLine(Prompt);
        for (int i = 0; i < Options.Length; i++)
        {
            string currentOption = Options[i];

            if (i == SelectedIndex)
            {
                ForegroundColor = ConsoleColor.Blue;
                BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
            }
            WriteLine($"<< {currentOption} >>");
        }
        ResetColor();
    }
    public int Run()            //możliwość poruszania się strzałkami i potwierdzenie enterem
    {
        ConsoleKey keyPressed;
        do
        {
            Clear();
            DisplayOptions();
            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {
                SelectedIndex--;
                if (SelectedIndex == -1)
                {
                    SelectedIndex = Options.Length - 1;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                SelectedIndex++;
                if (SelectedIndex == Options.Length)
                {
                    SelectedIndex = 0;
                }
            }
        }
        while (keyPressed != ConsoleKey.Enter);

        return SelectedIndex;
    }
}