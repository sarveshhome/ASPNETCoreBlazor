#pragma checksum "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14dc84cd569621dcdfeaaf88bbfaa3f1dc71d5eb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplicationBlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\_Imports.razor"
using WebApplicationBlazorDemo;

#line default
#line hidden
#line 7 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\_Imports.razor"
using WebApplicationBlazorDemo.Shared;

#line default
#line hidden
#line 3 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\Pages\FetchData.razor"
using WebApplicationBlazorDemo.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 39 "e:\Practice\ASPNETCoreBlazor\WebApplicationBlazorDemo\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
