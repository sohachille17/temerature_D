
class Program
{
    public static List<int> Temperature  = 
    new List<int>(){15, 17, 21, 14, 19, 16, 20}; 
    public static List<string> JoursSemaine =
    new List<string>() {"Lundi","Mardi","Mercredi",
    "Jeudi","Vendredi","Samedi","Dimanche"};
    public static int Moyenne = 0;
    public static int TrouveIndex = 0;

    public static List<int> TempSuperieur = new List<int>();

    static void Main(String[] args)
    {
        // Temperature
        CalculerEcart(Temperature);

        RetourneTemperatureSuperieurALaMoyenne(Temperature, TempSuperieur, JoursSemaine);



    }
    public static int CalculerMoyenne(List<int>Temperature)
    {
        int Somme = 0;

        int Taile = Temperature.Count;

        foreach(int Temp in Temperature)
        {
            Somme = Somme + Temp;
        }
         Moyenne = Somme / Taile;
         Console.WriteLine("");
         Console.WriteLine($"Temperature moyenne {Moyenne}°C".ToUpper());
     


        return Moyenne;
    }
    public static void RetourneTemperatureSuperieurALaMoyenne(List<int> Temperature,
    List<int>TemperatureSuperieur, List<string> JourSemains)
    {
        List<int> IndexSuperieur = new List<int>();
        int MoyenneParDefaut = CalculerMoyenne(Temperature);
        for(int i = 0 ; i < Temperature.Count; i++)
        {
            if(Temperature[i] >= MoyenneParDefaut)
            {
                TemperatureSuperieur.Add(Temperature[i]);
                IndexSuperieur.Add(i);
            }
        }

        Console.WriteLine(" ");
        Console.WriteLine("Journées où la température dépasse la moyenne. ".ToUpper());
        /*  ***************AFFICHE MOI LE RESULTAT ICI */
        for(int i = 0; i < TemperatureSuperieur.Count ; i ++)
        {
            /* Ici je recupere la list qui stock les index puis je passe 
            la list d'index comme index a le JourJour Index c'est un peu fou
            mais c'est ma logique */
            // Console.WriteLine($"Index Superieur { IndexSuperieur[i]}");
            Console.WriteLine("");
            Console.WriteLine($"- {JourSemains[  IndexSuperieur[i] ]} : {TemperatureSuperieur[i]}°C");
        }
    }

    public static void CalculerEcart(List<int> Temperature)
    {


        int MaxTemp = Temperature[0];
        int MinTemp = Temperature[0];

        int ConteDeMaxAMin = 0;
        foreach(int Temp in Temperature)
        {
            

            if(Temp > MaxTemp) 
            {
                MaxTemp = Temp;
            } 
            if(Temp < MinTemp) 
            {
                MinTemp = Temp;
            }
            if(MaxTemp >= MinTemp)
            {
                ConteDeMaxAMin++;
            }
            
        }


        Console.WriteLine("");
        Console.WriteLine($"Écart de température de la semaine : {ConteDeMaxAMin}°C".ToUpper());
        // Console.WriteLine($"Max Temp {MaxTemp}");
        // Console.WriteLine($"Min Temp {MinTemp}");



    }
}