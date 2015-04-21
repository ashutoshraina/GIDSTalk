#r System.Net.Http;

void Start()
{
	var httpClient = new HttpClient();
	var response = httpClient.GetAsync("http://thoughtworks.com").Result;
	Console.WriteLine(response);
}

Start();