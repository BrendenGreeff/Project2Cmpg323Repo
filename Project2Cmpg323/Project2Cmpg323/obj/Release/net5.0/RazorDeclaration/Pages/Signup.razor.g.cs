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
#line 1 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Project2Cmpg323;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\_Imports.razor"
using Project2Cmpg323.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Signup.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Signup.razor"
using Project2Cmpg323.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Signup.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Signup_Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class Signup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Signup.razor"
       

    UsersModels users = new UsersModels();

    private string Users_Fname { get; set; }
    private string Users_Lname { get; set; }
    private string Users_Username { get; set; }
    private string Users_Email { get; set; }
    private string Users_PhoneNumber { get; set; }
    private string Users_DOB { get; set; }
    private string ConfirmPassword { get; set; }
    private string Users_Password { get; set; }



    string Color = "black";
    string text = "";




    private async Task Submit()
    {


        if (users.Users_Password == ConfirmPassword)
        {
            if (users.Users_Fname != "" && users.Users_Lname != "" && users.Users_Username != "" && users.Users_Email != "" && users.Users_DOB != null && users.Users_Password != null && ConfirmPassword != null)
            {

                string sql = "INSERT INTO users (Users_Fname, Users_Lname, Users_Username, Users_Email, Users_PhoneNumber, Users_DOB, Users_Password) values (@FirstName, @LastName, @Username, @Email, @PhoneNumber, @DateOfBirth, @Password)";
                await _data.SaveData(sql, new { FirstName = users.Users_Fname, LastName = users.Users_Lname, Username = users.Users_Username, Email = users.Users_Email, PhoneNumber = users.Users_PhoneNumber, DateOfBirth = users.Users_DOB, Password = users.Users_Password }, _config.GetConnectionString("default"));

                Color = "green";
                text = "Welcome Guest!";

                UriHelper.NavigateTo("/");

            }
            else
            {
                Color = "red";
                text = "Please fill in all the fields!";

            }

        }
        else
        {
            Color = "red";
            text = "Passwords dont match, retry!";

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591