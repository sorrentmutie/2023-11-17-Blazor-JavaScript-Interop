using Microsoft.JSInterop;

namespace DemoBlazorInterop.Interop;

public class MyJavaScriptInterop: IDisposable
{
    private readonly IJSRuntime jSRuntime;
    private DotNetObjectReference<HelloHelper>? dotNetObjectReference;

    public MyJavaScriptInterop(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
    }

    public async Task EseguiPrimaFunzione()
    {
        await jSRuntime.InvokeVoidAsync("miaPrimaFunzione");
    }

    public async Task<int> EseguiSecondaFunzione(int a, int b)
    {
        return await jSRuntime.InvokeAsync<int>("somma", a, b);
    }

    public async Task EseguiTerzaFunzione()
    {
        await jSRuntime.InvokeVoidAsync("miaTerzaFunzione");
    }

    public async Task EseguiSayHello(string name)
    {
        var helloHelper = new HelloHelper(name);
        dotNetObjectReference = DotNetObjectReference.Create(helloHelper);
        await jSRuntime.InvokeAsync<string>("sayHello", dotNetObjectReference);
    }


    [JSInvokable]
    public static string TerzaFunzioneDotNet(string nome)
    {
        return $"Ciao, {nome}!";
    }

    public void Dispose()
    {
        dotNetObjectReference?.Dispose();
    }
}
