#pragma checksum "C:\Workspace\INET 2005 Web Application Programming\INET2005-Boilerplate-with-MySQL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17570b5e57474a85847cf08b5ea45eb6a90ebc66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Workspace\INET 2005 Web Application Programming\INET2005-Boilerplate-with-MySQL\Views\_ViewImports.cshtml"
using Boilerplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\INET 2005 Web Application Programming\INET2005-Boilerplate-with-MySQL\Views\_ViewImports.cshtml"
using Boilerplate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17570b5e57474a85847cf08b5ea45eb6a90ebc66", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30aae7c3adee80583d4473b6cee61b98915a9ba0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div>
    <h1 class=""text-success"">Boilerplate Template</h1>
    <h5 class=""text-success"">INET2005 Web Appplication Programming I</h5>
    <p>
    This Boilerplate is a scaled version of the web app generated with ""dotnet new mvc"" with all unnecessary code removed.
    </p>
    <p>
    Boilerplate template usage:
    <ol>
        <li>Delete /bin and /obj from the project folder</li>
        <li>change name of Boilerplate.csproj to [YOUR PROJECT NAME].csproj</li>
        <li>using VS Code, find and replace all occurances of the name Boilerplate throughout the code and config files and change to YOUR PROJECT NAME</li>
        <li>change name of project folder itself to YOUR PROJECT NAME</li>
    </ol>
    </p>
    <p>
    MySQL usage:
    <ol>
        <li>Database credentials is in docker-compose.yml - change them to your own credentials</li>
        <li>Access Myadminer via http://localhost:8080 and enter in server / username / password</li>
        <li>Since MySQL spins up in a docker cont");
            WriteLiteral("ainer, start up app with: docker compose build / docker compose up</li>\r\n    </ol>\r\n    </p>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
