// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project2Cmpg323.Pages
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
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Login.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Login.razor"
using Project2Cmpg323.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Login.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Login_Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Login.razor"
      

    UsersModels users = new UsersModels();

    List<UsersModels> user;

    private string Users_Fname { get; set; }
    private string Users_Lname { get; set; }
    private string Users_Username { get; set; }
    private string Users_Email { get; set; }
    private string Users_PhoneNumber { get; set; }
    private string Users_DOB { get; set; }
    private string ConfirmPassword { get; set; }
    private string Users_Password { get; set; }
    public static string Name;

    string Color = "black";
    string text = "";

    protected override async Task OnInitializedAsync()
    {
        string sql = "SELECT Users_Username, Users_Password FROM users";
        user = await _data.LoadData<UsersModels, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

    public void Submit()
    {
        foreach (var u in user)
        {
            if (u.Users_Username == users.Users_Username && u.Users_Password == users.Users_Password)
            {
                Color = "green";
                text = "Welcome Guest!";

                Name = users.Users_Username;

                UriHelper.NavigateTo("/index");

            }
            else
            {
                Color = "red";
                text = "User Password Wrong!";


            }

        }

    }

    private void Navigate()
    {
        UriHelper.NavigateTo("/signup");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
