
var addresses = Saver.Read();

Saver.Write(addresses);


public static class Saver
{
    public const string InputFile = "..\\..\\..\\addresses.csv";
    public const string OutputFile = "..\\..\\..\\output.txt";

    public static IEnumerable<Address> Read()
    {
        using var input = File.OpenText(InputFile);

        var addresses = new List<Address>();
        input.ReadLine();
        while (!input.EndOfStream)
        {
            string? line = input.ReadLine();

            if (line != "")
            {

                var chunks = line.Split(',')!;

                string name = "";
                string secondName = "";
                string surname = "" ;
                string street = "" ;
                string city = "" ;
                string province = "" ;
                string zip = "";

                if (chunks.Length == 6)
                {
                    name = chunks[0];
                    surname = chunks[1];
                    street = chunks[2];
                    city = chunks[3];
                    province = chunks[4];
                    zip = chunks[5];
                }else if(chunks.Length == 7)
                {
                    name = chunks[0];
                    secondName = chunks[1];
                    surname = chunks[2];
                    street = chunks[3];
                    city = chunks[4];
                    province = chunks[5];
                    zip = chunks[6];
                }

                else
                {
                    //name = chunks[0];
                    //secondName = chunks[1];
                    //surname = chunks[2];
                    //street = chunks[3];
                    //city = chunks[4];
                    //province = chunks[5];
                    //zip = chunks[6];

                    Console.WriteLine("L'indirizzo ha dati mancanti: " + line);
                }


                var address = new Address(name, surname, street, city, province, zip);
                addresses.Add(address);

            }
            else
            {
                Console.WriteLine("Riga totalmente vuota!");
            }
        }

        return addresses;
    }
    public static void Write(IEnumerable<Address> addresses)
    {
        using var output = File.CreateText(OutputFile);
        output.WriteLine("Name,Surname,Street,City,Province,ZIP:");

        foreach (var address in addresses)
        {
            output.WriteLine();
            output.WriteLine($"{address.Name}, {address.SecondName}, {address.Surname}, {address.Street}, {address.City}, {address.Province}, {address.Zip}");
            output.WriteLine();
        }
    }
}


public class Address
{
    public Address(string name, string surname, string street, string city, string province, string zip, string secondName = "NA")
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }


    public string Name { get; set; }
    public string Surname { get; set; }
    public string SecondName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Zip { get; set; }
}
