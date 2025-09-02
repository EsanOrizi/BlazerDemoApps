using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(x =>  
       new HttpClient { BaseAddress = new Uri("http://thesampleapi.com") });

await builder.Build().RunAsync();
