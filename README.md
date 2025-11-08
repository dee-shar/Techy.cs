# Techy.cs
Web-API for [techy-api.vercel.app](https://techy-api.vercel.app) a cool little API to output a tech savvy phrase with json and plaintext views

## Example
```cs
using TechyApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Techy();
            string phrase = await api.GetPhrase();
            Console.WriteLine(phrase);
        }
    }
}
```
