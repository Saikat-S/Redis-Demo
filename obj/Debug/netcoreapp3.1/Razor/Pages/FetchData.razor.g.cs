#pragma checksum "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba076b7a4b2ffe06d8fb67cbef376172a639883"
// <auto-generated/>
#pragma warning disable 1591
namespace Redis_Demo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Redis_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Redis_Demo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\WokStation\Redis\Redis-Demo\_Imports.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
using Redis_Demo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
using Redis_Demo.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
                                          LoadForecast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Load Forecast");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 14 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
 if(forecasts is null && loadLocation == "")
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p> <em>Click the button to load the forecast data. </em></p>\r\n");
#nullable restore
#line 17 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
}
else if (forecasts is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 21 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "h3" + " " + (
#nullable restore
#line 24 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
                    isCacheData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 24 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
                                  loadLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.AddContent(16, "    ");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 36 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 39 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 40 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 41 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 42 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 44 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 47 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "G:\WokStation\Redis\Redis-Demo\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;
    private string loadLocation = "";
    private string isCacheData = "";

    //protected override async Task OnInitializedAsync()
    //{
    //    forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    //}

    private async Task LoadForecast()
    {
        forecasts = null;
        loadLocation = null;

        string recordKey = "WetherForecast_" + DateTime.Now.ToString("yyyyMMdd_hhmm");

        forecasts = await cache.GetRecordAsync<WeatherForecast[]>(recordKey);

        if(forecasts is null)
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);

            loadLocation = $"Loaded from API at {DateTime.Now}";
            isCacheData = "";

            await cache.SetRecordAsync(recordKey, forecasts);
        }
        else
        {
            loadLocation = $"Loaded from Cache at {DateTime.Now}";
            isCacheData = "text-danger";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDistributedCache cache { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
