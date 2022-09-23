



// ------------- Libro.cs -------------------------
public class Libro
{
    public string titolo;
    private string autore;
    private int anno;

    public Libro(string titolo, string autore, int anno)
    {
        this.titolo = titolo;
        this.autore = autore;
        this.anno = anno;
    }
    public override string ToString()
    {
        string stringa = "------ Libro ------\n";
        stringa += "Titolo:\t" + this.titolo + "\n";
        stringa += "Autore:\t" + this.autore + "\n";
        stringa += "Anno:\t" + this.anno + "\n";
        stringa += "-------------------";

        return stringa;
    }
}





















//string path = "../../../example.txt";

//if (File.Exists(path))
//{
//    Creo un file
//   StreamWriter file = new StreamWriter(path, true);

//    scrivo le mie linee di testo
//    string testoUtente = Console.ReadLine();
//    file.WriteLine(testoUtente);

//    chiudo il mio file
//    file.Close();

//}


//// Open the file to read from.
//StreamReader file = File.OpenText("../../../example.txt");

//while (!file.EndOfStream)
//{
//    string riga = file.ReadLine();
//    Console.WriteLine(riga);
//}

/////altre 

//file.Close();


//if (File.Exists("../../../example.txt"))
//{
//    string[] lineeDelFile = File.ReadAllLines("../../../example.txt");

//    foreach (string linea in lineeDelFile)
//    {
//        Console.WriteLine(linea);
//    }
//}
//else
//{
//    Console.WriteLine("il file example non esiste");
//}