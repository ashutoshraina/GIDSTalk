using CsvHelper;
using System.IO;

	var reader = new StreamReader("Data.csv");
	var csvReader = new CsvReader(reader);
	var records = csvReader.GetRecords<Sentence>();

	foreach (var record in records) {
	    Console.WriteLine(record);
	}

	class Sentence
	{
		public string Subject { get; set; }
		public string Predicate { get; set; }
		public string Object { get; set; }

		public override string ToString()
		{
			return Subject + " ..." + Predicate + "..." + Object;
		}
	}
