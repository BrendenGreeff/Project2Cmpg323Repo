#pragma checksum "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43f29c4efde042fbda1ad6228bb259653f4a9014"
// <auto-generated/>
#pragma warning disable 1591
namespace Project2Cmpg323.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Project2Cmpg323;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Project2Cmpg323.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Project2Cmpg323.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.Extensions.Configuration;

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
            __builder.AddAttribute(2, "b-kjsgvit4mo");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-kjsgvit4mo");
            __builder.OpenComponent<Project2Cmpg323.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-kjsgvit4mo");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4 auth");
            __builder.AddAttribute(13, "b-kjsgvit4mo");
            __builder.OpenElement(14, "LoginDisplay");
            __builder.AddAttribute(15, "b-kjsgvit4mo");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-kjsgvit4mo>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "content px-4");
            __builder.AddAttribute(21, "b-kjsgvit4mo");
            __builder.AddContent(22, 
#nullable restore
#line 15 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
