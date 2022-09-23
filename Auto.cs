
// ----------- VARIABILI GLOBALI ------------


public class Auto
{
    string modello;
    int annoDiProduzione;

    public Auto(string modello, int annoDiProduzione)
    {
        this.modello = modello;
        this.annoDiProduzione = annoDiProduzione;
    }

    public string GetModello()
    {
        return this.modello;
    }
}
