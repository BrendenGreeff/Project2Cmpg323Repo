#pragma checksum "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2e8f2136888c3dcea4a82b8855743556ceb4ac4"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor"
using Project2Cmpg323.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/images")]
    public partial class Images : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ImagesUploadDiv");
            __builder.AddMarkupContent(2, "<h3>Images</h3>\r\n    <hr>\r\n    ");
            __builder.AddMarkupContent(3, "<label>Welcom, UName</label>\r\n    <img src=\"Image\" style=\"width: 250px; height: 250px\"> <br>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(4);
            __builder.AddAttribute(5, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor"
                         HandleFile

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "multiple", true);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<button type=\"submit\" class=\"btn-primary\">Insert</button>\r\n    <br>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\Project2Cmpg323\Project2Cmpg323\Pages\Images.razor"
       

    ModelImage imgmodel = new ModelImage();

    List<ModelImage> pictures;

    private string UName = Login.Name;

    public string Image { get; set; }
    public string Name { get; }

    protected override async Task OnInitializedAsync()
    {
        string sql2 = "select * from images";
        pictures = await _data.LoadData<ModelImage, dynamic>(sql2, new { }, _config.GetConnectionString("default"));

    }



    public async Task HandleFile(InputFileChangeEventArgs e)
    {
        var file = e.File;

        var buffer = new byte[file.Size];

        await file.OpenReadStream(1512000).ReadAsync(buffer);

        Image = $"data:image/png;base64,{Convert.ToBase64String(buffer)}";


        string sql = "insert into images(Images_Name,Images_Path,Images_Username) values (@ImageName,@ImagePath,@ImageUsername); ";
        await _data.SaveData(sql, new { ImageName = file.Name, ImagePath = imgmodel.Images_Path, ImageUsername = imgmodel.Images_Username }, _config.GetConnectionString("default"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
