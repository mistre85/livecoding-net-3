

StreamReader fileLibri = File.OpenText("libri.txt");
List<Libro> listaLibriValidi = new List<Libro>();
fileLibri.ReadLine();

while (!fileLibri.EndOfStream)
{
    string riga = fileLibri.ReadLine();

    string[] split = riga.Split(',');

    try
    {
        string titolo = split[0];
        string autore = split[1];
        int anno = int.Parse(split[2]);
        titolo = titolo.Replace("- ", "");
        Libro libro = new Libro(titolo, autore, anno);
        listaLibriValidi.Add(libro);
        Console.WriteLine("Libro {0} importato correttamente", titolo);

    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Libro non valido -->" + riga);
    }

    
}

fileLibri.Close();

try
{
    StreamWriter libriWriter = File.CreateText("Libri Preferiti Bello.txt");

    libriWriter.WriteLine("Libri preferiti formato bello");

    foreach (Libro libro in listaLibriValidi)
    {
        Console.WriteLine("Salvataggio {0}", libro.titolo);
        libriWriter.WriteLine();
        libriWriter.WriteLine(libro.ToString());
    }

    libriWriter.Close();

}catch(Exception e)
{
    Console.WriteLine("Qualcosa è andato storto: {0}", e.Message);
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