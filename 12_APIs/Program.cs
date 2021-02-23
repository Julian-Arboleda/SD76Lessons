/*APIs -
*GET  -- read some info from server;

*POST -- add some info to the server;

PUT updating some info in the server;

DELETE -- remove some info from server;

OPTIONS -- tells you what endpoints exist;

HEAD -- tells you what headers responses have

*/

using _12_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIs
{
    class Program
    {
        static void Main(string[] args)
        {
            SWAPIService service = new SWAPIService();
            SWAPIUI UI = new SWAPIUI(service);
            UI.Run();


            // HyperText Transer Protocol
            // HTML = HyperText Markup Language
            
            HttpClient httpClient = new HttpClient();

           HttpResponseMessage response = httpClient.GetAsync("http://swapi.dev/api/people/1/").Result;

            // Async means it's happening asynchronously
            // (on another timeline) aka depends on another computer doing something

            if (response.IsSuccessStatusCode)
            {
                // ReadAsString gives us the raw JSON string
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            // ReadAsSync converts the JSON to C# POCO
            Person person = response.Content.ReadAsAsync<Person>().Result;

            HttpResponseMessage planetResponse = httpClient.GetAsync(person.Homeworld).Result;

            if (planetResponse.IsSuccessStatusCode)
            {
                // POCO Plain Old C# Object
                Planet planet = planetResponse.Content.ReadAsAsync<Planet>().Result;
                
                Console.WriteLine($"\n\n{person.Name} is {person.Height}cm tall and has {person.Eye_Color} eyes. {person.Name} is from {planet.Climate} world of {planet.Name} ");
            }
            else
            {
                Console.WriteLine($"\n\n{person.Name} is {person.Height} cm tall and has {person.Eye_Color} eyes." );
            }


        }
    }
}