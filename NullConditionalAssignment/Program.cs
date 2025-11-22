Dictionary<string, string> dict = null; // new();

/* C# 13 way
if (dict is null)
{
   dict["chave"] = "valor";
}
*/

// C# 14
dict?["chave"] = "valor";


User? user = new User("Name", "Second Name");

/* C# 13 way
if (user is not null)
{
    user.Name = "Test";
}
*/

// C# 14
user?.Name = "Test";

Console.WriteLine(user?.Name ?? "No user...");

internal class User(string name, string lastName)
{
    public string Name { get; set; } = name;
    public string LastName { get; set; } = lastName;
}