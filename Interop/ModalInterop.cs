using Microsoft.JSInterop;

namespace DemoBlazorInterop.Interop;

public class ModalInterop
{
    private readonly IJSRuntime jSRuntime;

    public ModalInterop(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
    }

    public async Task ShowModal(string id)
    {
        await jSRuntime.InvokeVoidAsync("apriModale", id);
    }

    public async Task HideModal()
    {
        await jSRuntime.InvokeVoidAsync("chiudiModale");
    }
}
