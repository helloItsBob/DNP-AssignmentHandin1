#pragma checksum "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d342ebb99a6d4621421c4dad16aa50d7f5eee5"
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
#line 1 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Hand_in1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Hand_in1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
using Hand_in1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
using Hand_in1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
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
#line 9 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
                         _females

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n    <br>\r\n    Total male count: ");
            __builder.AddContent(5, 
#nullable restore
#line 11 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
                       _males

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
#line 17 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
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
#line 22 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
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
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(22);
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(26);
                    __builder3.AddAttribute(27, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 29 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
                                              GetAllGenders()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "XName", "Sex");
                    __builder3.AddAttribute(29, "YName", "Count");
                    __builder3.AddAttribute(30, "Name", "Browser");
                    __builder3.AddAttribute(31, "InnerRadius", "40%");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n \r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(33);
                __builder2.AddAttribute(34, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\slip1\RiderProjects\DNP-AssignmentHandin1\Hand_in1\Pages\Chart.razor"
      
    
    private IList<Adult> _allAdults;
    private int _males;
    private int _females;
    
    protected override async Task OnInitializedAsync()
    {
        try
        {
            _allAdults = await _webAdultService.GetAllAdultsAsync();
            GetAllFemales();
            GetAllMales();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            //throw;
        }
    }

    private void GetAllFemales()
    {
        int tmp = 0;
        tmp = _allAdults.Count(adult => adult.Sex.Equals("F"));
        _females = tmp;
    }

    private void GetAllMales()
    {
        int tmp = 0;
        tmp = _allAdults.Count(adult => adult.Sex.Equals("M"));
        _males = tmp;
    }
    
    private List<object> GetAllGenders()
    {
        return new List<object>
        {
            new
            {
                Sex = "Females",
                Count = _females
            },
            new
            {
                Sex = "Males",
                Count = _males
            }
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService _webAdultService { get; set; }
    }
}
#pragma warning restore 1591
