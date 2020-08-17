#pragma checksum "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31cf258d1c2e583bda81d492d7ca800ca9443e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication.Pages.Pages_Exercise4), @"mvc.1.0.razor-page", @"/Pages/Exercise4.cshtml")]
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Exercise4")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31cf258d1c2e583bda81d492d7ca800ca9443e43", @"/Pages/Exercise4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9173452e213feb50bb0addca674477e742c9787", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Exercise4 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
  
    ViewData["Title"] = "Keona - Exercise 4";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""grid grid-cols-2 mb-20"">
  <div id=""comments"" class="" max-w-7xl mx-auto col-span-2 bg-white overflow-hidden shadow rounded-lg mt-20"">
    <div class=""px-4 py-5 sm:p-6"">
      <h2 class=""text-2xl text-blue-800"">
        Exercise 4 - C#: DataAccess method to get Person Orders by Date
      </h2>
      <p class=""text-gray-700 text-xl "">
      Assumptions - Assuming we wouldn't want duplicate PersonId's. Assuming usage of ORM (EF CORE).
      </p>
    </div>
  </div>


  <div id=""solution"" class="" mx-5 col-span-1 bg-white overflow-hidden shadow rounded-lg mt-10"">
    <div class=""px-4 py-5 sm:p-6"">
      <h2 class=""text-2xl text-blue-800"">
        Answer
      </h2>
      <pre class=""mt-2"">
      <code class=""sql rounded-md shadow-xl"">
        --Stored Procedure in DB

          Create Procedure GetPersonByOrderDate
              &#64;selectedDate Date
              as
          BEGIN
           set nocount on;

          select DISTINCT * from Person where PersonId in (");
            WriteLiteral(@"
                  select PersonId from Orders 
                  where cast(OrderDateTime as Date) = &#64;selectedDate
              )

          END
    </code>
  </pre>
      <pre class=""mt-2""><code class=""c# rounded-md shadow-xl"">
      // C# code snippet pulling the stored proc using the parameter

      var dateParam = orderDateTime.ToString(""yyyy-MM-dd"");
      var sql = $""EXEC GetPersonByOrderDate '{dateParam}'"";
      var personsFromDB = await _CONTEXT.Person.FromSqlRaw(sql).ToListAsync();
    </code></pre>
    </div>
  </div>

  <div id=""output"" class=""col-span-1 mx-5 bg-white overflow-hidden shadow rounded-lg mt-10"">
    <div class=""px-4 py-5 sm:p-6"">
      <h2 class=""text-2xl text-blue-800"">
        Output - is defaulted to 07/01/2020
      </h2>
   
      <div class=""flex flex-col mt-6"">
        <div class=""-my-2 py-2 overflow-x-auto sm:-mx-6 sm:px-6 lg:-mx-8 lg:px-8"">
          <div class=""align-middle inline-block min-w-full shadow overflow-hidden sm:rounded-lg border-");
            WriteLiteral(@"b border-gray-200"">
            <table class=""min-w-full divide-y divide-gray-200"">
              <thead>
              <tr>
                <th class=""px-6 py-3 bg-gray-50  leading-4 text-xs  font-medium text-gray-500  tracking-wider"">
                  PersonId
                </th>
                <th class=""px-6 py-3 bg-gray-50 leading-4 text-xs  font-medium text-gray-500  tracking-wider"">
                  NameFirst
                </th>
                <th class=""px-6 py-3 bg-gray-50 leading-4 text-xs  font-medium text-gray-500  tracking-wider"">
                  NameLast
                </th>
             
              </tr>
              </thead>
              <tbody class=""text-center"">
");
#nullable restore
#line 83 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
               foreach (var person in Model.personsOrders.OrderBy(o => o.PersonId))
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 3086, "\"", 3170, 1);
#nullable restore
#line 85 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
WriteAttributeValue("", 3094, Model.personsOrders.IndexOf(person) % 2 == 0 ? "bg-white" : "bg-gray-50" , 3094, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <td class=\"px-6 py-4 whitespace-no-wrap  text-sm leading-5 font-medium\">\r\n                    ");
#nullable restore
#line 87 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
               Write(person.PersonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n                  <td class=\"px-6 py-4 whitespace-no-wrap text-sm leading-5 font-medium text-gray-900\">\r\n                    ");
#nullable restore
#line 90 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
               Write(person.NameFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n                  <td class=\"px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"
               Write(person.NameLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n              \r\n                </tr>\r\n");
#nullable restore
#line 97 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise4.cshtml"

              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n              </tbody>\r\n       \r\n            </table>\r\n          \r\n          </div>\r\n        </div>\r\n      </div>\r\n\r\n    </div>\r\n  </div>\r\n\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Pages.Exercise4> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Exercise4> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Exercise4>)PageContext?.ViewData;
        public WebApplication.Pages.Exercise4 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
