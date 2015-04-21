using StackExchange.Redis;

var redis = ConnectionMultiplexer.Connect("localhost");
var db = redis.GetDatabase();
db.StringSet("foo","bar");
var result = db.StringGet("foo");
Console.WriteLine(result);