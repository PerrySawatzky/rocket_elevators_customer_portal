#pragma checksum "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea75b3f94a0de22db431125fe7bd122d95fb89b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Intervention_Index), @"mvc.1.0.view", @"/Views/Intervention/Index.cshtml")]
namespace AspNetCore
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
#line 1 "/Users/officeimac/rocket_elevators_customer_portal/Views/_ViewImports.cshtml"
using rocket_elevators_customer_portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/officeimac/rocket_elevators_customer_portal/Views/_ViewImports.cshtml"
using rocket_elevators_customer_portal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea75b3f94a0de22db431125fe7bd122d95fb89b", @"/Views/Intervention/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c33f9c2bcf8bebfae948ec03cdee5ebb28a15dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Intervention_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/intervention.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return postIntervention()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml"
  
    ViewData["Title"] = "Intervention Form";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ea75b3f94a0de22db431125fe7bd122d95fb89b5687", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 11 "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    var user = await UserManager.GetUserAsync(User);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <h1 hidden id=\"userEmailReally\">");
#nullable restore
#line 15 "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml"
                               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n</div>\n    <main class=\"col-md-9 ms-sm-auto col-lg-10 px-md-4\">\n    <div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom\">\n        <h1 class=\"h2\">Intervention Form</h1>\n    </div>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea75b3f94a0de22db431125fe7bd122d95fb89b7616", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-3"">
                <div >
                    <h4>Your ID:</h4> <h4 id=""intervention_building_id_div""></h4>
                </div>
                <select cols=""40"" onchange=""getBattery()"" class=""form-control"" id=""intervention_building_id"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea75b3f94a0de22db431125fe7bd122d95fb89b8199", async() => {
                    WriteLiteral("Select Building");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                        \n                </select>\n                <select cols=\"40\" onchange=\"getColumn()\" class=\"form-control\" id=\"intervention_battery_id\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea75b3f94a0de22db431125fe7bd122d95fb89b9390", async() => {
                    WriteLiteral("Select Battery");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                        \n                </select>\n                <select cols=\"40\" onchange=\"getElevator()\" class=\"form-control\" id=\"intervention_column_id\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea75b3f94a0de22db431125fe7bd122d95fb89b10581", async() => {
                    WriteLiteral("Select Column");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                       \n                </select>\n                <select cols=\"40\" class=\"form-control\" id=\"intervention_elevator_id\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea75b3f94a0de22db431125fe7bd122d95fb89b11746", async() => {
                    WriteLiteral("Select Elevator");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"               
                </select>
                <div class=""row"">
                    <div class=""col-md-12"">
                        <label for=""textarea"">Report</label><br />
                        <textarea id=""textarea"" rows=""5"" cols=""40""></textarea>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-12"">
                        <button");
                BeginWriteAttribute("onclick", " onclick=\"", 2118, "\"", 2128, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\"><i class=\"fa fa-check\"></i> SUBMIT </button>\n                    </div>\n                </div>\n\n            </div>\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</main>\n");
#nullable restore
#line 57 "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml"


}

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml"
 if (SignInManager.IsSignedIn(User) == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"text-center\">\n        <h1 class=\"display-4\">Please log in</h1>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea75b3f94a0de22db431125fe7bd122d95fb89b15059", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br>\n    </div>\n");
#nullable restore
#line 66 "/Users/officeimac/rocket_elevators_customer_portal/Views/Intervention/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script type=""text/javascript"">
   function postIntervention() {
            var data = {
                customer_id: $('#customerID').html(),
                author_id: $('#customerID').html(),
                building_id: $('#intervention_building_id').val(),
                battery_id: $('#intervention_battery_id').val(),
                column_id: $('#intervention_column_id').val(),
                elevator_id: $('#intervention_elevator_id').val(),
                report: $('#textarea').val(),
            };
                $.ajax({  
                    url: 'http://whispering-tundra-91467.herokuapp.com/api/interventions',  
                    type: 'POST',
                    data: JSON.stringify(data),
                    headers: {
                        ""Access-Control-Allow-Origin"": ""*"",
                        ""Access-Control-Allow-Methods"": ""HEAD, GET, POST, PUT, PATCH, DELETE"",
                        ""Access-Control-Allow-Headers"": ""Content-Type, Access-Control-Allow-Headers, Authorization, ");
                WriteLiteral(@"X-Requested-With"",
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    success: function (data, textStatus, xhr) {
                        console.log('Info updated');
                    },  
                    error: function (data, xhr, textStatus, errorThrown) {  
                        console.log('Error in Operation');
                    }  
                });  
            return false;
        }
$( document ).ready(function() {
         var userEmail = document.getElementById(""userEmailReally"").innerHTML;
         $.ajax({
                cache: false,
                url: 'https://whispering-tundra-91467.herokuapp.com/api/customers/',
                type: 'GET',
                dataType: 'json',
                success: function (obj) {
                    for (var i = 0; i < obj.length; i++){
                        if (obj[i].company_contact_email == userEmail){                            
 ");
                WriteLiteral(@"                           var row = '<h4 id=""customerID"" value=""' + obj[i].id + '"">' + obj[i].id + '</h4>';
                            $(row).appendTo(""#intervention_building_id_div"");
                            setTimeout(getBuildings, 1);
                        }
                    }
                },
                error: function (obj) {
                    console.log('Something happened');
                }
            });
    });
   
    function getElevator() {
    var columnID = document.getElementById(""columnID"").value;
    $.ajax({
        cache: false,
        url: 'https://whispering-tundra-91467.herokuapp.com/api/elevators/',
        type: 'GET',
        dataType: 'json',
        success: function (obj) {
            for (var i = 0; i < obj.length; i++){
                if (obj[i].column_id == columnID){
                    
                    var row = '<option id=""elevatorID"" value=""' + obj[i].id + '"">' + obj[i].id + '</option>';
                    $(row).appendTo(""#intervention_eleva");
                WriteLiteral(@"tor_id"");
                }
            }
        },
        error: function (obj) {
            console.log('Something happened');
        }
    });
    }
    function getColumn() {
    var batteryID = document.getElementById(""batteryID"").value;
    $.ajax({
        cache: false,
        url: 'https://whispering-tundra-91467.herokuapp.com/api/columns/',
        type: 'GET',
        dataType: 'json',
        success: function (obj) {
            for (var i = 0; i < obj.length; i++){
                if (obj[i].battery_id == batteryID){
                    var row = '<option id=""columnID"" value=""' + obj[i].id + '"">' + obj[i].id + '</option>';
                    $(row).appendTo(""#intervention_column_id"");
                }
            }
        },
        error: function (obj) {
            console.log('Something happened');
        }
    });
    }
    function getBattery() {
        var buildingID = document.getElementById(""buildingID"").value;
        $.ajax({
            cache: false,
            url: 'https:");
                WriteLiteral(@"//whispering-tundra-91467.herokuapp.com/api/batteries/',
            type: 'GET',
            dataType: 'json',
            success: function (obj) {
                for (var i = 0; i < obj.length; i++){
                    if (obj[i].building_id == buildingID){
                        var row = '<option id=""batteryID"" value=""' + obj[i].id + '"">' + obj[i].id + '</option>';
                        $(row).appendTo(""#intervention_battery_id"");
                        
                    }
                }
            },
            error: function (obj) {
                console.log('Something happened');
            }
        });
    }
    function getBuildings() {
        var customerID = document.getElementById(""customerID"").innerHTML;
        $.ajax({
            cache: false,
            url: 'https://whispering-tundra-91467.herokuapp.com/api/buildings/',
            type: 'GET',
            dataType: 'json',
            success: function (obj) {
                for (var i = 0; i < obj.length; i++){
     ");
                WriteLiteral(@"               if (obj[i].customer_id == customerID){
                        var row = '<option id=""buildingID"" value=""' + obj[i].id + '"">' + obj[i].address_of_the_building + '</option>';
                        $(row).appendTo(""#intervention_building_id"");
                    }
                }
            },
            error: function (obj) {
                console.log('Something happened');
            }
        });
    }
</script>
");
            }
            );
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
