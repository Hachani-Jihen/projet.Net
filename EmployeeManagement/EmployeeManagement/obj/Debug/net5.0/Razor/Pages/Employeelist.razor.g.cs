#pragma checksum "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291ef4000bd2b6c45b5453cbf83ec49ba213e0ed"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\_Imports.razor"
using EmployeeManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employeelist")]
    public partial class Employeelist : EmployeelistBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmployeeList</h3>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 13 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
     foreach (var employee in Employees)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card m-3");
            __builder.AddAttribute(5, "style", "min-width: 18rem; max-width: 30.5%;");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.OpenElement(8, "h3");
            __builder.AddContent(9, 
#nullable restore
#line 17 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
                     employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 17 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
                                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 19 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
                                                           employee.photoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-footer text-center");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 21 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
                           $"EmployeeDetails/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-primary m-1");
            __builder.AddContent(22, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 23 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
                           $"EditEmployee/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "btn btn-primary m-1");
            __builder.AddContent(27, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 25 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
                           $"deleteemployee/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "btn btn-primary m-1");
            __builder.AddContent(32, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\Employeelist.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
