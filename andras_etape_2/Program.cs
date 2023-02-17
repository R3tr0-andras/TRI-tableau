using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        byte recom = 0;
        do
        {
            Console.Clear();

            int methodeDeTri = 0;
            Console.WriteLine("Quel méthode de tri voulez vous utilisé ?");
            Console.WriteLine("\n | entrez 1 pour tri par sélection" +
                "\n | entrez 2 pour tri a bulle" +
                "\n | entrez 3 pour tri par insertion" +
                "\n | entrez 4 pour tri intuitif" +
                "\n | entrez 5 pour tri shell");
            methodeDeTri = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le minimum de l'intervalle :");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le maximum de l'intervalle :");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le nombre de valeurs à générer :");
            int nbVal = int.Parse(Console.ReadLine());

            int[] tableau = new int[nbVal];
            Random rnd = new Random();
            Stopwatch stopwatch = new Stopwatch();

            if (methodeDeTri == 1) // tri par sélection
            {
                stopwatch.Start();

                for (int i = 0; i < nbVal; i++)
                {
                    tableau[i] = rnd.Next(min, max + 1);
                }

                Console.Clear();

                Console.WriteLine(" ########  ########  ####      ########    ###      #########     ######   ########  ##        ########   ######    ########  ####   #######   ##    ##\n" +
                                  "    ##    ##     ##   ##      ##     ##   ## ##    ##      ##    ##    ##  ##        ##        ##        ##    ##      ##      ##   ##     ##  ###   ##\n" +
                                  "    ##    ##     ##   ##      ##     ##  ##   ##   ##      ##    ##        ##        ##        ##        ##            ##      ##   ##     ##  ####  ##\n" +
                                  "    ##    ########    ##      ########  ##     ##  ## ######      ######   ######    ##        ######    ##            ##      ##   ##     ##  ## ## ##\n" +
                                  "    ##    ##   ##     ##      ##        #########  ##    ##            ##  ##        ##        ##        ##            ##      ##   ##     ##  ##  ####\n" +
                                  "    ##    ##    ##    ##      ##        ##     ##  ##     ##     ##    ##  ##        ##        ##        ##    ##      ##      ##   ##     ##  ##   ###\n" +
                                  "    ##    ##     ##  ####     ##        ##     ##  ##      ##     ######   ########  ########  ########   ######       ##     ####   #######   ##    ##");

                Console.WriteLine("\nTableau généré :");
                AfficherTableau(tableau);

                TriSelection(tableau);

                Console.WriteLine("\nTableau trié :");
                AfficherTableau(tableau);

                stopwatch.Stop();

                Console.WriteLine("Temps de traitement : " + stopwatch.ElapsedMilliseconds + " ms");

                Console.WriteLine("Voulez vous recommencer avec d'autres valeurs ou une autre méthode de tri ?" +
                    "\n entrez 0 pour recommencer et un autre chiffre pour fermer le programme");
                recom = byte.Parse(Console.ReadLine());
            }

            else if (methodeDeTri == 2) // tri bulle
            {
                stopwatch.Start();

                for (int i = 0; i < nbVal; i++)
                {
                    tableau[i] = rnd.Next(min, max + 1);
                }

                Console.Clear();

                  Console.WriteLine("\r\n   /$$$$$$$$           /$$                       /$$                 /$$ /$$          " +
                                    "\r\n  |__  $$__/          |__/                      | $$                | $$| $$          " +
                                    "\r\n     | $$     /$$$$$$  /$$        /$$$$$$       | $$$$$$$  /$$   /$$| $$| $$  /$$$$$$ " +
                                    "\r\n     | $$    /$$__  $$| $$       |____  $$      | $$__  $$| $$  | $$| $$| $$ /$$__  $$" +
                                    "\r\n     | $$   | $$  \\__/| $$        /$$$$$$$      | $$  \\ $$| $$  | $$| $$| $$| $$$$$$$$" +
                                    "\r\n     | $$   | $$      | $$       /$$__  $$      | $$  | $$| $$  | $$| $$| $$| $$_____/" +
                                    "\r\n     | $$   | $$      | $$      |  $$$$$$$      | $$$$$$$/|  $$$$$$/| $$| $$|  $$$$$$$" +
                                    "\r\n     |__/   |__/      |__/       \\_______/      |_______/  \\______/ |__/|__/ \\_______/" +
                                    "\r\n                                                                                      " +
                                    "\r\n                                                                                      " +
                                    "\r\n                                                                                      " +
                                    "\r\n");

                Console.WriteLine("\nTableau généré :");
                AfficherTableau(tableau);

                TriBulle(tableau);

                Console.WriteLine("\nTableau trié :");
                AfficherTableau(tableau);

                Console.WriteLine("Temps de traitement : " + stopwatch.ElapsedMilliseconds + " ms");

                Console.WriteLine("Voulez vous recommencer avec d'autres valeurs ou une autre méthode de tri ?\n entrez 0 pour recommencer et un autre chiffre pour fermer le programme");
                recom = byte.Parse(Console.ReadLine());
            }

            else if (methodeDeTri == 3) // tri par insertion
            {
                stopwatch.Start();

                for (int i = 0; i < nbVal; i++)
                {
                    tableau[i] = rnd.Next(min, max + 1);
                }

                Console.Clear();

                Console.WriteLine("\r\n    _______          _                              _                               _     _                 " +
                                  "\r\n   |__   __|        (_)                            (_)                             | |   (_)                " +
                                  "\r\n      | |     _ __   _     _ __     __ _   _ __     _   _ __    ___    ___   _ __  | |_   _    ___    _ __  " +
                                  "\r\n      | |    | '__| | |   | '_ \\   / _` | | '__|   | | | '_ \\  / __|  / _ \\ | '__| | __| | |  / _ \\  | '_ \\ " +
                                  "\r\n      | |    | |    | |   | |_) | | (_| | | |      | | | | | | \\__ \\ |  __/ | |    | |_  | | | (_) | | | | |" +
                                  "\r\n      |_|    |_|    |_|   | .__/   \\__,_| |_|      |_| |_| |_| |___/  \\___| |_|     \\__| |_|  \\___/  |_| |_|" +
                                  "\r\n                          | |                                                                               " +
                                  "\r\n                          |_|                                                                               " +
                                  "\r\n");
 
                Console.WriteLine("\nTableau généré :");
                AfficherTableau(tableau);

                TriInsertion(tableau);

                Console.WriteLine("\nTableau trié :");
                AfficherTableau(tableau);

                Console.WriteLine("Temps de traitement : " + stopwatch.ElapsedMilliseconds + " ms");

                Console.WriteLine("Voulez-vous recommencer avec d'autres valeurs ou une autre méthode de tri ?" +
                    "\n Entrez 0 pour recommencer et un autre chiffre pour fermer le programme");
                recom = byte.Parse(Console.ReadLine());
            }


            else if (methodeDeTri == 4) // tri intuitif
            {
                stopwatch.Start();

                for (int i = 0; i < nbVal; i++)
                {
                    tableau[i] = rnd.Next(min, max + 1);
                }

                Console.Clear();

                Console.WriteLine("\r\n                                                                                                                                                                                          " +
                    "\r\n                                                                                                                                                                                          " +
                    "\r\n  TTTTTTTTTTTTTTTTTTTTTTT                      iiii         iiii                             tttt                              iiii           tttt            iiii      ffffffffffffffff  " +
                    "\r\n  T:::::::::::::::::::::T                     i::::i       i::::i                         ttt:::t                             i::::i       ttt:::t           i::::i    f::::::::::::::::f " +
                    "\r\n  T:::::::::::::::::::::T                      iiii         iiii                          t:::::t                              iiii        t:::::t            iiii    f::::::::::::::::::f" +
                    "\r\n  T:::::TT:::::::TT:::::T                                                                 t:::::t                                          t:::::t                    f::::::fffffff:::::f" +
                    "\r\n  TTTTTT  T:::::T  TTTTTTrrrrr   rrrrrrrrr   iiiiiii      iiiiiii nnnn  nnnnnnnn    ttttttt:::::ttttttt    uuuuuu    uuuuuu  iiiiiii ttttttt:::::ttttttt    iiiiiii   f:::::f       ffffff" +
                    "\r\n          T:::::T        r::::rrr:::::::::r  i:::::i      i:::::i n:::nn::::::::nn  t:::::::::::::::::t    u::::u    u::::u  i:::::i t:::::::::::::::::t    i:::::i   f:::::f             " +
                    "\r\n          T:::::T        r:::::::::::::::::r  i::::i       i::::i n::::::::::::::nn t:::::::::::::::::t    u::::u    u::::u   i::::i t:::::::::::::::::t     i::::i  f:::::::ffffff       " +
                    "\r\n          T:::::T        rr::::::rrrrr::::::r i::::i       i::::i nn:::::::::::::::ntttttt:::::::tttttt    u::::u    u::::u   i::::i tttttt:::::::tttttt     i::::i  f::::::::::::f       " +
                    "\r\n          T:::::T         r:::::r     r:::::r i::::i       i::::i   n:::::nnnn:::::n      t:::::t          u::::u    u::::u   i::::i       t:::::t           i::::i  f::::::::::::f       " +
                    "\r\n          T:::::T         r:::::r     rrrrrrr i::::i       i::::i   n::::n    n::::n      t:::::t          u::::u    u::::u   i::::i       t:::::t           i::::i  f:::::::ffffff       " +
                    "\r\n          T:::::T         r:::::r             i::::i       i::::i   n::::n    n::::n      t:::::t          u::::u    u::::u   i::::i       t:::::t           i::::i   f:::::f             " +
                    "\r\n          T:::::T         r:::::r             i::::i       i::::i   n::::n    n::::n      t:::::t    ttttttu:::::uuuu:::::u   i::::i       t:::::t    tttttt i::::i   f:::::f             " +
                    "\r\n        TT:::::::TT       r:::::r            i::::::i     i::::::i  n::::n    n::::n      t::::::tttt:::::tu:::::::::::::::uui::::::i      t::::::tttt:::::ti::::::i f:::::::f           " +
                    " \r\n        T:::::::::T       r:::::r            i::::::i     i::::::i  n::::n    n::::n      tt::::::::::::::t u:::::::::::::::ui::::::i      tt::::::::::::::ti::::::i f:::::::f            " +
                    "\r\n        T:::::::::T       r:::::r            i::::::i     i::::::i  n::::n    n::::n        tt:::::::::::tt  uu::::::::uu:::ui::::::i        tt:::::::::::tti::::::i f:::::::f            " +
                    "\r\n        TTTTTTTTTTT       rrrrrrr            iiiiiiii     iiiiiiii  nnnnnn    nnnnnn          ttttttttttt      uuuuuuuu  uuuuiiiiiiii          ttttttttttt  iiiiiiii fffffffff            " +                                                                                                                                                                               
                    "\r\n");

                Console.WriteLine("\nTableau généré :");
                AfficherTableau(tableau);

                TriIntuitif(tableau);

                Console.WriteLine("\nTableau trié :");
                AfficherTableau(tableau);

                Console.WriteLine("Temps de traitement : " + stopwatch.ElapsedMilliseconds + " ms");

                Console.WriteLine("Voulez-vous recommencer avec d'autres valeurs ou une autre méthode de tri ?" +
                    "\n Entrez 0 pour recommencer et un autre chiffre pour fermer le programme");
                recom = byte.Parse(Console.ReadLine());

            }

            else if (methodeDeTri == 5) //tri shell
            {
                stopwatch.Start();

                for (int i = 0; i < nbVal; i++)
                {
                    tableau[i] = rnd.Next(min, max + 1);
                }

                Console.Clear();

                Console.WriteLine("\r\n      ███        ▄████████  ▄█          ▄████████    ▄█    █▄       ▄████████  ▄█        ▄█       " +
                    "\r\n  ▀█████████▄   ███    ███ ███         ███    ███   ███    ███     ███    ███ ███       ███       " +
                    "\r\n     ▀███▀▀██   ███    ███ ███▌        ███    █▀    ███    ███     ███    █▀  ███       ███       " +
                    "\r\n      ███   ▀  ▄███▄▄▄▄██▀ ███▌        ███         ▄███▄▄▄▄███▄▄  ▄███▄▄▄     ███       ███       " +
                    "\r\n      ███     ▀▀███▀▀▀▀▀   ███▌      ▀███████████ ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀     ███       ███       " +
                    "\r\n      ███     ▀███████████ ███                ███   ███    ███     ███    █▄  ███       ███       " +
                    "\r\n      ███       ███    ███ ███          ▄█    ███   ███    ███     ███    ███ ███▌    ▄ ███▌    ▄ " +
                    "\r\n     ▄████▀     ███    ███ █▀         ▄████████▀    ███    █▀      ██████████ █████▄▄██ █████▄▄██ " +
                    "\r\n                ███    ███                                                    ▀         ▀         " +
                    "\r\n");

                Console.WriteLine("\nTableau généré :");
                AfficherTableau(tableau);

                TriShell(tableau);

                Console.WriteLine("\nTableau trié :");
                AfficherTableau(tableau);

                Console.WriteLine("Temps de traitement : " + stopwatch.ElapsedMilliseconds + " ms");

                Console.WriteLine("Voulez-vous recommencer avec d'autres valeurs ou une autre méthode de tri ?\n Entrez 0 pour recommencer et un autre chiffre pour fermer le programme");
                recom = byte.Parse(Console.ReadLine());
            }
        }
        while (recom == 0);
        Console.WriteLine("Au revoir ;)");
    }
    static void AfficherTableau(int[] tableau)
    {
        for (int i = 0; i < tableau.Length; i++)
        {
            Console.Write("[ " + tableau[i] + " ]" + " ");
        }
        Console.WriteLine();
    }
    static void TriSelection(int[] tableau)
    {
        for (int i = 0; i < tableau.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < tableau.Length; j++)
            {
                if (tableau[j] < tableau[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = tableau[i];
            tableau[i] = tableau[minIndex];
            tableau[minIndex] = temp;
        }
    }
    static void TriBulle(int[] tableau)
    {
        int n = tableau.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (tableau[i - 1] > tableau[i])
                {
                    int temp = tableau[i - 1];
                    tableau[i - 1] = tableau[i];
                    tableau[i] = temp;
                    swapped = true;
                }
            }
            n--;
        } while (swapped);
    }
    static void TriInsertion(int[] tableau)
    {
        int n = tableau.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = tableau[i];
            int j = i - 1;

            while (j >= 0 && tableau[j] > key)
            {
                tableau[j + 1] = tableau[j];
                j = j - 1;
            }
            tableau[j + 1] = key;
        }
    }
    static void TriIntuitif(int[] tableau)
    {
        for (int i = 0; i < tableau.Length - 1; i++)
        {
            for (int j = i + 1; j < tableau.Length; j++)
            {
                if (tableau[j] < tableau[i])
                {
                    int temp = tableau[i];
                    tableau[i] = tableau[j];
                    tableau[j] = temp;
                }
            }
        }
    }
    static void TriShell(int[] tableau)
    {
        int n = tableau.Length;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i += 1)
            {
                int temp = tableau[i];
                int j;
                for (j = i; j >= gap && tableau[j - gap] > temp; j -= gap)
                {
                    tableau[j] = tableau[j - gap];
                }
                tableau[j] = temp;
            }
            gap /= 2;
        }
    }
}

