#pragma checksum "C:\Users\Hoc\Documents\Zalo Received Files\ShopPhone\ShopPhone\Views\Chitietdonhangs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee78e771819e305df97868767076da53df57f447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chitietdonhangs_Create), @"mvc.1.0.view", @"/Views/Chitietdonhangs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee78e771819e305df97868767076da53df57f447", @"/Views/Chitietdonhangs/Create.cshtml")]
    public class Views_Chitietdonhangs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopPhone.Models.Chitietdonhang>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hoc\Documents\Zalo Received Files\ShopPhone\ShopPhone\Views\Chitietdonhangs\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Chitietdonhang</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""MaSanPham"" class=""control-label""></label>
                <select asp-for=""MaSanPham"" class =""form-control"" asp-items=""ViewBag.MaSanPham""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""MaDon"" class=""control-label""></label>
                <select asp-for=""MaDon"" class =""form-control"" asp-items=""ViewBag.MaDon""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""SoLuong"" class=""control-label""></label>
                <input asp-for=""SoLuong"" class=""form-control"" />
                <span asp-validation-for=""SoLuong"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label a");
            WriteLiteral(@"sp-for=""DonGia"" class=""control-label""></label>
                <input asp-for=""DonGia"" class=""form-control"" />
                <span asp-validation-for=""DonGia"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Hoc\Documents\Zalo Received Files\ShopPhone\ShopPhone\Views\Chitietdonhangs\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopPhone.Models.Chitietdonhang> Html { get; private set; }
    }
}
#pragma warning restore 1591
