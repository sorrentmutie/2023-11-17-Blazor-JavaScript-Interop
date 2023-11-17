using DemoBlazorInterop;
using DemoBlazorInterop.Interop;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ModalInterop>();
builder.Services.AddScoped<ChartInterop>();
builder.Services.AddScoped<ChartService>();

await builder.Build().RunAsync();
