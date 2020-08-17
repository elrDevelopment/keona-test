#pragma checksum "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e2814331addd6dde8931472db45f251b57d6719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication.Pages.Pages_Exercise1), @"mvc.1.0.razor-page", @"/Pages/Exercise1.cshtml")]
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
#line 2 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Exercise1")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2814331addd6dde8931472db45f251b57d6719", @"/Pages/Exercise1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9173452e213feb50bb0addca674477e742c9787", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Exercise1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
  
    ViewData["Title"] = "Keona - Exercise 1";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""grid grid-cols-2 mb-20 px-4 md:px-0"">
<div id=""comments"" class="" max-w-7xl mx-auto col-span-2 bg-white overflow-hidden shadow rounded-lg mt-20"">
  <div class=""px-4 py-5 sm:p-6"">
    <h2 class=""text-2xl text-blue-800"">
        Exercise 1 - Get last order info for all persons
    </h2>
    <p class=""text-gray-700 text-xl "">
      I would more than likely use the second option. Most people seem to understand that a bit better than Common Table 
      Expressions. I do like the flow of the CTE a bit more.
    </p>
  </div>
</div>


<div id=""solution"" class=""mx-0 p-1 md:px-4 md:mx-5 col-span-2 md:col-span-1 bg-white overflow-hidden shadow rounded-lg mt-10"">
  <div class=""px-0 p-0 sm:px-4 py-5 sm:p-6"">
    <h2 class=""text-2xl text-blue-800"">
            Answer
        </h2>
    <pre class=""mt-2""><code class=""sql rounded-md text-xs md:text-base"">
WITH PersonOrderDates as (
    select ROW_NUMBER() over (PARTITION BY PersonId ORDER BY OrderDateTime desc) as rn,  
OrderId as Last");
            WriteLiteral(@"OrderId, PersonId, OrderDateTime as LastOrderDateTime from Orders
),
 PersonLastOrderDates as (
    select * from PersonOrderDates where rn = 1
)
select P.PersonId, NameFirst, NameLast, LastOrderId,  LastOrderDateTime
from Person p
Left outer join  PersonLastOrderDates pld on pld.PersonId = P.PersonId

-- OR reduced

select ROW_NUMBER() over (PARTITION BY PersonId ORDER BY OrderDateTime desc) as rn,  
OrderId as LastOrderId, PersonId, OrderDateTime as LastOrderDateTime into #tmpOrders from Orders

select P.PersonId, NameFirst, NameLast, LastOrderId,  LastOrderDateTime
from Person p
Left outer join  (select * from #tmpOrders where rn = 1) pld on pld.PersonId = P.PersonId
</code></pre>

  </div>
</div>

<div id=""output"" class=""col-span-2 md:col-span-1 mx-5 bg-white overflow-hidden shadow rounded-lg mt-10"">
  <div class=""px-4 py-5 sm:p-6"">
    <h2 class=""text-2xl text-blue-800"">
        Output
    </h2>
    <div class=""flex flex-col mt-2"">
      <div class=""-my-2 py-2 overflow-x-auto ");
            WriteLiteral(@"sm:-mx-6 sm:px-6 lg:-mx-8 lg:px-8"">
        <div class=""align-middle inline-block min-w-full shadow overflow-hidden sm:rounded-lg border-b border-gray-200"">
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
              <th class=""px-6 py-3 bg-gray-50 leading-4 text-xs  font-medium text-gray-500 tracking-wider"">
                LastOrderId
              </th>
              <th class=""px-6 py-3 bg-gray-50 leading-4 text-xs font-medium text-gray-500  tracking-wider"">
                LastOr");
            WriteLiteral("derDateTime\r\n              </th>\r\n            </tr>\r\n            </thead>\r\n            <tbody class=\"text-center\">\r\n");
#nullable restore
#line 84 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
             foreach (var person in Model.personOrderList.OrderBy(o => o.PersonId).Take(10))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr");
            BeginWriteAttribute("class", " class=\"", 3459, "\"", 3523, 1);
#nullable restore
#line 86 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
WriteAttributeValue("", 3467, person.PersonId % 2 == 0 ? "bg-white" : "bg-gray-50" , 3467, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td class=\"px-6 py-4 whitespace-no-wrap  text-sm leading-5 font-medium\">\r\n                  ");
#nullable restore
#line 88 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
             Write(person.PersonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"px-6 py-4 whitespace-no-wrap text-sm leading-5 font-medium text-gray-900\">\r\n                  ");
#nullable restore
#line 91 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
             Write(person.NameFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500\">\r\n                  ");
#nullable restore
#line 94 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
             Write(person.NameLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500\">\r\n                  ");
#nullable restore
#line 97 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
              Write( person.LastOrderId.HasValue ? person.LastOrderId.ToString() : "No Data - Null" );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"px-6 py-4 whitespace-no-wrap text-sm leading-5 text-gray-500\">\r\n                  ");
#nullable restore
#line 100 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"
              Write(person.LastOrderDateTime.HasValue ? person.LastOrderDateTime.Value.ToShortDateString() : "No Data - Null"   );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n              </tr>\r\n");
#nullable restore
#line 104 "C:\Users\elrde\Documents\projects\test-deleteme\WebApplication\WebApplication\Pages\Exercise1.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          
            </tbody>
       
          </table>
          
        </div>
      </div>
    </div>

  </div>
</div>


</div>



<script>
document.addEventListener('DOMContentLoaded', (event) => {
  document.querySelectorAll('pre code').forEach((block) => {
    hljs.highlightBlock(block);
  });
});


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Pages.Exercise1> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Exercise1> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Exercise1>)PageContext?.ViewData;
        public WebApplication.Pages.Exercise1 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
