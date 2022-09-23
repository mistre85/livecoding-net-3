
public class Autorimessa
{
    List<Auto> autoPresenti;
    private int postiOccupati;

    public int CapienzaMassima  { get; }

    public Autorimessa()
    {
        autoPresenti = new List<Auto>();
    }

    public Autorimessa(int numeroPostiAutoMassimo)
    {
        this.CapienzaMassima = numeroPostiAutoMassimo;
    }

    public int GetNumeroPostiLiberi()
    {
        //return autoPresenti.Length - postiOccupati;
        return CapienzaMassima - autoPresenti.Count();

     }

    public void AggiungiAuto(Auto auto)
    {
        if (GetNumeroPostiLiberi() < CapienzaMassima)
        {
            autoPresenti.Add(auto);
        }
        else
        {
            Console.WriteLine("Mi dispiace hai usato tutti i posti auto");
        }
    }

    public void DecrementareAuto()
    {
        if (autoPresenti.Count() > 0)
        {
            autoPresenti.RemoveAt(autoPresenti.Count() - 1); 
        }
        else
        {
            Console.WriteLine("Mi dispiace ma non hai più auto!");
        }
    }

    public void StampaAutoPresenti()
    {
        for (int i = 0; i < autoPresenti.Count(); i++)
        {
            Console.WriteLine("\t" + autoPresenti[i].GetModello());
        }
        Console.WriteLine();
    }
}
