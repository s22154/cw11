#pragma checksum "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a02bb46358323d602228beecd78f63de46fea0"
// <auto-generated/>
#pragma warning disable 1591
namespace cw11.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11.Data.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-puo1a66tmv");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-puo1a66tmv");
            __builder.OpenComponent<cw11.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-puo1a66tmv");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-puo1a66tmv><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-puo1a66tmv>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-puo1a66tmv");
#nullable restore
#line 14 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/Shared/MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
