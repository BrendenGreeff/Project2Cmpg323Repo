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
#line 3 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Index.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Index.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Index.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Index.razor"
using Project2Cmpg323.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\Project2Cmpg323Repo\Project2Cmpg323Repo\Project2Cmpg323\Project2Cmpg323\Pages\Index.razor"
      


    ImagesModels imgmodel = new ImagesModels();

    List<ImagesModels> pictures;
    List<UsersModels> users;

    List<Images> imgDisplayObj;

    public string Username = Login.Name;
    public string Profileimg = Login.ProfileImg;
    public string Image { get; set; }
    public string Images_Name { get; }
    private static string img;

    protected override async Task OnInitializedAsync()
    {

        string sql = "SELECT * FROM images";
        pictures = await _data.LoadData<ImagesModels, dynamic>(sql, new { }, _config.GetConnectionString("default"));

        string sql2 = "SELECT Users_ProfileImg FROM users WHERE Users_Username = @username";
        users = await _data.LoadData<UsersModels, dynamic>(sql2, new { username = Username }, _config.GetConnectionString("default"));

        //Login.ProfileImg = Image;
        Image = Login.ProfileImg;



    }


    private async Task HandleFileSelected(InputFileChangeEventArgs fileChangeEvent)
    {
        var file = fileChangeEvent.File;
        if (file != null)
        {
            var buffer = new byte[file.Size];

            await file.OpenReadStream(1512000).ReadAsync(buffer);

            Image = $"data:image/png;base64,{Convert.ToBase64String(buffer)}";

            img = $"data:image/png;base64,{Convert.ToBase64String(buffer)}";

        }


    }

    private async Task Submit()
    {


        string sql2 = "UPDATE users SET Users_ProfileImg = @image WHERE Users_Username = @username";
        await _data.SaveData(sql2, new { image = Image, username = Username }, _config.GetConnectionString("default"));

        //Image = Login.ProfileImg;
        Login.ProfileImg = Image;


    }

    //Service to fetch images
    public List<UsersModels> DisplayImages()
    {
        return users.ToList();
    }

    string convertImageToDisplay(byte[] img)
    {
        if (img != null)
        {
            var base64 = Convert.ToBase64String(img);
            var fs = string.Format("data: image/jpeg; base64,{0}", base64);
            return fs;
        }
        return "";
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
