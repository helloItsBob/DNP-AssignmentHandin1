#pragma checksum "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c998adeb17dff7a38f83f9f133229cb61297b27c"
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
#line 11 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
using Hand_in1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
using Hand_in1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Policy", "SecurityLevel1");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "id", "form-container-filter");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "id", "left");
                __builder2.OpenElement(8, "p");
                __builder2.AddMarkupContent(9, "\r\n                Global search: <br>\r\n                ");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "placeholder", "Filter keyword...");
                __builder2.AddAttribute(13, "style", "width: 150px;height: 30px");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                                                                          Filter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "id", "right");
                __builder2.OpenElement(19, "p");
                __builder2.AddMarkupContent(20, "\r\n                Filter by gender:\r\n                ");
                __builder2.OpenElement(21, "select");
                __builder2.AddAttribute(22, "class", "form-control selectpicker");
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                                                                       FilterByGender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "style", "width: 150px;height: 30px");
                __builder2.OpenElement(25, "option");
                __builder2.AddContent(26, "All");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "option");
                __builder2.AddContent(29, "M");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "option");
                __builder2.AddContent(32, "F");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        <br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n    <hr>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
 if (_adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<p><em>Loading...</em></p>");
#nullable restore
#line 39 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
}
else if (!_adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<p><em>No Adult items, please create some!</em></p>");
#nullable restore
#line 45 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "table");
            __builder.AddAttribute(38, "class", "table");
            __builder.OpenElement(39, "thead");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "<th>ID</th>\r\n            ");
            __builder.AddMarkupContent(42, "<th>Name</th>\r\n            ");
            __builder.AddMarkupContent(43, "<th>Surname</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "Policy", "SensitiveInfo");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(47, "<th>Hair-color</th>\r\n                ");
                __builder2.AddMarkupContent(48, "<th>Eye-color</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddMarkupContent(50, "<th>Age</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(51);
            __builder.AddAttribute(52, "Policy", "SensitiveInfo");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(54, "<th>Weight(kg)</th>\r\n                ");
                __builder2.AddMarkupContent(55, "<th>Height(cm)</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.AddMarkupContent(57, "<th>Sex</th>\r\n            ");
            __builder.AddMarkupContent(58, "<th>Job Title</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(59);
            __builder.AddAttribute(60, "Policy", "SensitiveInfo");
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(62, "<th>Salary</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(64);
            __builder.AddAttribute(65, "Policy", "CanDeleteAdults");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(67, "<th>Remove</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(69);
            __builder.AddAttribute(70, "Policy", "SecurityLevel2");
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(72, "<th>Edit</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.OpenElement(74, "tbody");
#nullable restore
#line 78 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
         foreach (var item in _adultsToShow)
        {
            if (!IsVisible(item))
                continue;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "tr");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 83 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 84 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 85 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(85);
            __builder.AddAttribute(86, "Policy", "SensitiveInfo");
            __builder.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(88, "td");
                __builder2.AddContent(89, 
#nullable restore
#line 87 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                         item.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.OpenElement(91, "td");
                __builder2.AddContent(92, 
#nullable restore
#line 88 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                         item.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "td");
            __builder.AddContent(95, 
#nullable restore
#line 90 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(97);
            __builder.AddAttribute(98, "Policy", "SensitiveInfo");
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(100, "td");
                __builder2.AddContent(101, 
#nullable restore
#line 92 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                         item.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.OpenElement(103, "td");
                __builder2.AddContent(104, 
#nullable restore
#line 93 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                         item.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 95 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 96 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(112);
            __builder.AddAttribute(113, "Policy", "SensitiveInfo");
            __builder.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(115, "td");
                __builder2.AddContent(116, 
#nullable restore
#line 98 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                         item.JobTitle.Salary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(117, "\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(118);
            __builder.AddAttribute(119, "Policy", "CanDeleteAdults");
            __builder.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(121, "td");
                __builder2.OpenElement(122, "button");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                                            () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(124, "<i class=\"oi oi-trash\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(126);
            __builder.AddAttribute(127, "Policy", "SecurityLevel2");
            __builder.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(129, "td");
                __builder2.OpenElement(130, "button");
                __builder2.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
                                            () => EditAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(132, "<i class=\"oi oi-pencil\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 117 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 120 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\slip1\RiderProjects\Hand_in1\Hand_in1\Pages\Adults.razor"
       

    private string Filter { get; set; }

    private bool IsVisible(Adult adult) // global filter
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (adult.FirstName.Contains(Filter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.LastName.Contains(Filter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.JobTitle.JobTitle.Contains(Filter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.HairColor.Contains(Filter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.EyeColor.Contains(Filter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.Id.ToString().StartsWith(Filter) || adult.Age.ToString().StartsWith(Filter))
            return true;

        if (adult.Weight.ToString().StartsWith(Filter) || adult.Height.ToString().StartsWith(Filter))
            return true;

        if (adult.JobTitle.Salary.ToString().StartsWith(Filter))
            return true;

        return false;
    }

    private IList<Adult> _allAdults;
    private static IList<Adult> _adultsToShow;

#nullable enable

    private void FilterByGender(ChangeEventArgs args)
    {
        string? filterByGender = null;
        try
        {
            filterByGender = (string) args.Value!;
        }
        catch (Exception e)
        {
    // ignored
        }

        if (filterByGender != null)
        {
            _adultsToShow = _allAdults.Where(a => a.Sex == filterByGender).ToList();
        }
        if (filterByGender!.Equals("All"))
        {
            filterByGender = null;
            _adultsToShow = _allAdults;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        _allAdults = await _webAdultService.ReadAllAsync();
        _adultsToShow = _allAdults;
    }

    private async Task RemoveAdult(int adultId)
    {
        Adult toRemove = _allAdults.First(a => a.Id == adultId);
        await _webAdultService.DeleteAsync(adultId);
        _allAdults.Remove(toRemove);
    }

    private void EditAdult(int adultId)
    {
        try
        {
            _navigationManager.NavigateTo($"Edit/{adultId}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService _webAdultService { get; set; }
    }
}
#pragma warning restore 1591
