// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Text.RegularExpressions;

using (HttpClient client = new HttpClient())
{
    string bUrl = "https://jsonplaceholder.typicode.com/posts";
    HttpResponseMessage message = await client.GetAsync(bUrl);

    string responce = await message.Content.ReadAsStringAsync();

  
    var users = JsonConvert.DeserializeObject<List<User>>(responce);
    
    users.ForEach(x=>Console.WriteLine(x.title));
    

}

class User
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
}