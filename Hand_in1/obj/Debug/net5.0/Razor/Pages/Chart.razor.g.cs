#pragma checksum "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b04b545cd3de495fa586246363bfa8b14cbca359"
// <auto-generated/>
#pragma warning disable 1591
namespace Hand_in1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Hand_in1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Hand_in1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
using Hand_in1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
using Hand_in1.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
           [Authorize(Policy = "SecurityLevel3")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "color:#fff;");
            __builder.AddMarkupContent(2, "\r\n    Total female count: ");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                         GetAllFemales()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n    <br>\r\n    Total male count: ");
            __builder.AddContent(5, 
#nullable restore
#line 14 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                       GetAllMales()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    <hr>");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(8);
            __builder.AddAttribute(9, "Title", "Gender distribution");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(13);
                    __builder3.AddAttribute(14, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 20 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                              GetAllGenders()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "XName", "Sex");
                    __builder3.AddAttribute(16, "YName", "Count");
                    __builder3.AddAttribute(17, "Name", "Gender");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(19);
                __builder2.AddAttribute(20, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(22);
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(24);
                __builder2.AddAttribute(25, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 31 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                  Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(27);
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(29);
                    __builder3.AddAttribute(30, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 33 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                  GetAllGenders()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "XName", "Sex");
                    __builder3.AddAttribute(32, "YName", "Count");
                    __builder3.AddAttribute(33, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 33 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                                                                   ChartSeriesType.Column

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(35);
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(37);
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(39);
                    __builder3.AddAttribute(40, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 42 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                              GetAllGenders()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "XName", "Sex");
                    __builder3.AddAttribute(42, "YName", "Count");
                    __builder3.AddAttribute(43, "Name", "Browser");
                    __builder3.AddAttribute(44, "InnerRadius", "40%");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n \r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(46);
                __builder2.AddAttribute(47, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(49);
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(51);
                __builder2.AddAttribute(52, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 53 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                  Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(54);
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(56);
                    __builder3.AddAttribute(57, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 55 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                  GetAllGenders()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "XName", "Sex");
                    __builder3.AddAttribute(59, "YName", "Count");
                    __builder3.AddAttribute(60, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 55 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
                                                                                   ChartSeriesType.Bar

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Chart.razor"
      
    
    private IList<Adult> _allAdults;
    
    protected override async Task OnInitializedAsync()
    {
        _allAdults = _fileContext.Adults;
    }
    
    private int GetAllFemales()
    {
        int femaleCount = 0;

        foreach (var adult in _allAdults)
        {
            if (adult.Sex.Equals("F"))
            {
                femaleCount++;
            }
        }
        return femaleCount;
    }

    private int GetAllMales()
    {
        int maleCount = 0;

        foreach (var adult in _allAdults)
        {
            if (adult.Sex.Equals("M"))
            {
                maleCount++;
            }
        }
        return maleCount;
    }

    private List<object> GetAllGenders()
    {
        return new List<object>
        {
            new
            {
                Sex = "Females",
                Count = GetAllFemales()
            },
            new
            {
                Sex = "Males",
                Count = GetAllMales()
            }
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext _fileContext { get; set; }
    }
}
#pragma warning restore 1591