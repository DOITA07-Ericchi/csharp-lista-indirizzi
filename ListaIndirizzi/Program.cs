// See https://aka.ms/new-console-template for more information
using ListaIndirizzi;

Console.WriteLine("Hello, World!");

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();
bool corretto = true;

try
{
	StreamReader file = File.OpenText("../../../Files/addresses.csv");

	while (!file.EndOfStream)
	{
		string riga = file.ReadLine();

		string[] infoIndirizzo = riga.Split(",");

		string name = infoIndirizzo[0];
		string surname = infoIndirizzo[1];
		string street = infoIndirizzo[2];
		string city = infoIndirizzo[3];
		string province = infoIndirizzo[4];
		string zip = infoIndirizzo[5];


		for (int i = 0; i < infoIndirizzo.Length; i++)
		{
			if (infoIndirizzo[i] == "")
			{
				corretto = false;
				Console.WriteLine("Attenzione: Il campo " + i + " è vuoto.");
			}
		}

		Indirizzo indirizzoEstratto = new Indirizzo(name, surname, street, city, province, zip);
		listaIndirizzi.Add(indirizzoEstratto);
		Console.WriteLine(riga);
	}
	if (corretto == false)
	{
		throw new Exception("Il file CSV ha qualche problema. Risolvi dove c'è scritto \"Attenzione\".");
	}

}
catch (IndexOutOfRangeException e)
{
	Console.WriteLine("Formatta meglio quel CSV e riprova. Qualche campo va oltre i limiti. (" + e.Message + ")");
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}

Console.ReadLine();