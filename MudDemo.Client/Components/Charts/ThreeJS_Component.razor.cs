using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using MudBlazor.Utilities;
using MudDemo.Client.Models.Charts;

namespace MudDemo.Client.Components.Charts;

public partial class ThreeJS_Component : MudComponentBase
{
    private string Classname =>
        new CssBuilder()
            .AddClass(Class)
            .Build();

    [Inject] private IJSRuntime JsRuntime { get; set; } = null!;
    [EditorRequired] [Parameter] public string NameId { get; set; } = string.Empty;
    //[EditorRequired] [Parameter] public ChartOptionsModel<TSeries, TCategory>? ChartOptions { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Console.WriteLine("Trying to load...");
            await JsRuntime.InvokeVoidAsync("threeTutorial.drawLine", NameId);
        }
    }




}