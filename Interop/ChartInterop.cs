using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DemoBlazorInterop.Interop;

public class ChartInterop
{
    private readonly IJSRuntime jSRuntime;

    public ChartInterop(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
    }

    public async Task ShowFirstChart()
    {
        await jSRuntime.InvokeVoidAsync("firstChart");
    }

    public async Task ShowSecondChart(ElementReference element)
    {
        await jSRuntime.InvokeVoidAsync("secondChart", element);
    }

    public async Task ShowChart(ElementReference element, ChartData chartData, ChartType type)
    {
        await jSRuntime.InvokeVoidAsync("showChart", element, chartData, type.ToString());
    }

    public async Task UpdateChart(ElementReference element, ChartData chartData, ChartType type)
    {
        await jSRuntime.InvokeVoidAsync("updateChart", element, chartData, type);
    }

}
