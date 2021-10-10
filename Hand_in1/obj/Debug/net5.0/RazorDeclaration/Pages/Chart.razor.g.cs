// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
