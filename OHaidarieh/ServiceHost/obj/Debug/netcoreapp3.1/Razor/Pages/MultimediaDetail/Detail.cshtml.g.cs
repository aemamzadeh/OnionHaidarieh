#pragma checksum "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1855c0b144e98e0bda7e7ea3572594e4a91c0bf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.MultimediaDetail.Pages_MultimediaDetail_Detail), @"mvc.1.0.razor-page", @"/Pages/MultimediaDetail/Detail.cshtml")]
namespace ServiceHost.Pages.MultimediaDetail
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
#line 1 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1855c0b144e98e0bda7e7ea3572594e4a91c0bf2", @"/Pages/MultimediaDetail/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MultimediaDetail_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
  
    //Layout = "_Layout2";
    ViewData["title"] = "فایلهای چندرسانه ای مراسم";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""gap remove-gap"">
    <div class=""page-title-wrap"">
        <h2>فایلهای چندرسانه ای </h2>
    </div>
    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-lg-12"">
                <div class=""sec-title"">
                    <div class=""sec-title2 text-center"">
                        <h3>مراسم<span> ");
#nullable restore
#line 18 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                                   Write(Model.ceremonyGuest.Ceremony);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                        <h5><span> ");
#nullable restore
#line 19 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                              Write(Model.ceremonyGuest.CeremonyDateFa);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n                        <h5><span> ");
#nullable restore
#line 20 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                              Write(Model.ceremonyGuest.Guest);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"evnt-wrap remove-ext5\">\r\n                    <div class=\"row mrg20\">\r\n");
#nullable restore
#line 27 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                         foreach (var item in Model.ceremonyGuest.Multimedias)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 col-sm-4 col-lg-4\">\r\n                                <div class=\"evnt-box\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1136, "\"", 1159, 1);
#nullable restore
#line 31 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
WriteAttributeValue("", 1142, item.FileAddress, 1142, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1160, "\"", 1183, 1);
#nullable restore
#line 31 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
WriteAttributeValue("", 1168, item.FileTitle, 1168, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1184, "\"", 1203, 1);
#nullable restore
#line 31 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
WriteAttributeValue("", 1190, item.FileAlt, 1190, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 42 "D:\NetCoreProjects\repos\OHaidarieh\OHaidarieh\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div><!-- Events Wrap -->\r\n            </div>\r\n");
            WriteLiteral("        </div><!-- Events & Prayer Wrap -->\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultimediaDetail.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MultimediaDetail.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MultimediaDetail.DetailModel>)PageContext?.ViewData;
        public MultimediaDetail.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
