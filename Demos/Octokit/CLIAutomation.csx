#load ConsoleUtil.csx

string userName = Env.ScriptArgs[0];
string command = Env.ScriptArgs[1];

var octokit = Require<OctokitPack>();

var client = octokit.CreateWithOAuth("GitHubClient", "ashutoshraina", "f7ede3a3af4423e73a160877a55d25af4ca3bec8");
//var client = octokit.CreateWithBasicAuth("GithubClient","ashutoshraina","arcaneraina1989");

switch(command)
{
  case "u" :
    PrintUser(userName);
    break;
  case "i" :
    PrintIssue(userName);
    break;
  case "I" :
    PrintIssues(userName);
    break;
  case "b" :
    PrintBranches(userName);
    break;
  case "n":
    PrintNotifications(userName);
  default:
    break;
}

void PrintUser(string userName)
{
  var user = client.User.Get(userName).Result;
  Console.WriteLine(user.Email);
}

void PrintIssues(string userName)
{
  string repository = Env.ScriptArgs[2];
  int numberOfIssues = Int32.Parse(Env.ScriptArgs[3]);
  var issues = client.Issue.GetForRepository(userName, repository).Result;
  
  foreach (var issue in issues.Take(numberOfIssues))
  {
    Console.WriteLine(issue.User.Login + " Raised " + issue.Number + " " + issue.Title);
  }
}

void PrintIssue(string userName)
{
  string repository = Env.ScriptArgs[2];
  int issueNumber = Int32.Parse(Env.ScriptArgs[3]);
  var issue = client.Issue.Get(userName, repository, issueNumber).Result;
  
  WriteToConsoleWithColor(issue.Url.ToString(), ConsoleColor.Blue);
  WriteToConsoleWithColor("@" + issue.User.Login + " Raised " + issue.Number + " " + issue.Title, ConsoleColor.Green);
  WriteToConsoleWithColor("Assigned To : " + issue.Assignee, ConsoleColor.Red);
  WriteToConsoleWithColor(issue.Body, ConsoleColor.Cyan);
}

void PrintBranches(string userName)
{
  string repository = Env.ScriptArgs[2];
  var branches =  client.Repository.GetAllBranches(userName, repository).Result;
  
  Console.WriteLine(branches.Count);
  foreach(var branch in branches)
  {
    Console.WriteLine(branch.Name);
  }
}

void PrintNotifications(string userName)
{
  var notifications = client.Notification.GetAllForCurrent().Result;
  if(!notifications.Any())
  {
  	WriteToConsoleWithColor("Hurray No notifications !!!", ConsoleColor.Green);
  }
  var groupedByRepository = notifications.GroupBy(n => n.Repository.Name);
  foreach (var groupedNotification in groupedByRepository) {
    WriteToConsoleWithColor(groupedNotification.Key, ConsoleColor.Blue);
    int i = 0;
    foreach (var notification in groupedNotification) {
        WriteToConsoleWithColor(i++ + "--> " + notification.Subject.Title, ConsoleColor.Green);		    
    }
  }
}