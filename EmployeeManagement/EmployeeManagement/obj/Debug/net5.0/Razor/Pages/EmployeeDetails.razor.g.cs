#pragma checksum "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d648a458edde1adefe2e44153c519c0a764524aa"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EmployeeDetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EmployeeDetails")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
 if (Employee == null || Employee.Department == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 8 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-8");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h1");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body text-center");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "class", "card-img-top");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 18 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                                                    Employee.photoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n                    ");
            __builder.OpenElement(20, "h4");
            __builder.AddContent(21, "Employee ID : ");
            __builder.AddContent(22, 
#nullable restore
#line 20 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                                       Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "h4");
            __builder.AddContent(25, "Email : ");
            __builder.AddContent(26, 
#nullable restore
#line 21 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                                 Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "h4");
            __builder.AddContent(29, "BirthDate : ");
            __builder.AddContent(30, 
#nullable restore
#line 22 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                                     Employee.DateOfBirth.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "h4");
            __builder.AddContent(33, "Departement : ");
            __builder.AddContent(34, 
#nullable restore
#line 23 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                                       Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card-footer text-center");
            __builder.AddMarkupContent(38, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                    ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 29 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
                               $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "class", "btn btn-primary m-1");
            __builder.AddContent(42, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\msi\Desktop\projet.net\EmployeeManagement\EmployeeManagement\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591