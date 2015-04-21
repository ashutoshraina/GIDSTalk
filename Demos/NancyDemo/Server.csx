var r = Require<NancyPack>();

public class IndexModule : NancyModule
{
	public IndexModule()
	{
		Get["/"] = _ => "Hello World";
		Get["/view"] = _ => View["index"];
	}
}

r.Host();
