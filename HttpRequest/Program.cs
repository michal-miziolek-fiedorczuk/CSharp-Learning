using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Collections.Generic;

namespace HttpRequest
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            // var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var stringTask = client.GetStringAsync("https://api-shipx-pl.easypack24.net/v1/tracking/637450638105070127332959");
            var repositories = JsonSerializer.Deserialize<Repository>(await stringTask);

                Console.WriteLine("Tracking number: " + repositories.TrackingNumber);
                Console.WriteLine("Status: " + repositories.Status);
                Console.WriteLine("Target machine: " + repositories.TargetMachineID);
                //Console.WriteLine("Kurs: " + repositories.Rate);

        }
    }
}
