#pragma checksum "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247a6f20d337202e5faa68f03b9bf28a9f752ede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\_ViewImports.cshtml"
using WebBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\_ViewImports.cshtml"
using WebBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247a6f20d337202e5faa68f03b9bf28a9f752ede", @"/Areas/Customer/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9b40104a8c380410ce2d32e392dfb7796ecd5e", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnremove btn btn-light border text-danger icon-hover-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""bg-light my-5"">
    <div class=""container"">
        <div class=""row"">
            <!-- cart -->
            <div class=""col-lg-9"">
                <div class=""card border shadow-0"">
                    <div class=""m-4"">
                        <h4 class=""card-title mb-4"">Your shopping cart</h4>
");
#nullable restore
#line 10 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "247a6f20d337202e5faa68f03b9bf28a9f752ede5754", async() => {
                WriteLiteral("\n                <input type=\"hidden\" name=\"productID\" class=\"productID\"");
                BeginWriteAttribute("value", " value=\"", 566, "\"", 590, 1);
#nullable restore
#line 13 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
WriteAttributeValue("", 574, item.Product.Id, 574, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""row gy-3 mb-4"">
                    <div class=""col-lg-5"">
                        <div class=""me-lg-5"">
                            <div class=""d-flex"">
                                <div class=""card h-50"">
                                    <img");
                BeginWriteAttribute("src", " src=\"", 873, "\"", 902, 2);
                WriteAttributeValue("", 879, "/", 879, 1, true);
#nullable restore
#line 19 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
WriteAttributeValue("", 880, item.Product.ImageUrl, 880, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                </div>\n                                <div");
                BeginWriteAttribute("class", " class=\"", 982, "\"", 990, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                    <a href=\"#\" class=\"nav-link\">");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                                                            Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-2 col-sm-6 col-6 d-flex flex-row flex-lg-column flex-xl-row text-nowrap"">
                        <div");
                BeginWriteAttribute("class", " class=\"", 1355, "\"", 1363, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                            <input type=\"text\" name=\"qty\"");
                BeginWriteAttribute("value", " value=\"", 1423, "\"", 1445, 1);
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1431, item.Quantity, 1431, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control qty\" />\n                        </div>\n                        <div class=\"ml-2\">\n                            <text class=\"h6\">");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                                        Write(string.Format("${0:#,##0}", item.Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</text> <br />
                        </div>
                    </div>

                    <div class=""col-lg col-sm-6 d-flex justify-content-sm-center justify-content-md-start justify-content-lg-center justify-content-xl-end mb-2"">
                        <div class=""float-md-end"">
                            <button type=""submit"" class=""btnUpdate btn btn-light border text-primary icon-hover-primary"" data-productID=""");
#nullable restore
#line 39 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                                                                    Write(item.Product.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Update</button>\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "247a6f20d337202e5faa68f03b9bf28a9f752ede10032", async() => {
                    WriteLiteral("Remove");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productID", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                       WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["productID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["productID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                                                                                                                                     Write(item.Product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-productID", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 44 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <!-- cart -->
            <!-- summary -->
            <div class=""col-lg-3"">
                <div class=""card shadow-0 border"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between"">
                            <p class=""mb-2"">Total price:</p>
                            <p class=""mb-2 totalprice"">");
#nullable restore
#line 56 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                                                  Write(string.Format("${0:#,##0}", Model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                        </div>

                        <div class=""d-flex justify-content-between"">

                            <p class=""mb-2"">Discount:</p>
                            <p class=""mb-2 text-success"">-$0</p>
                        </div>
                        <div class=""d-flex justify-content-between"">
                            <p class=""mb-2"">TAX:</p>
                            <p class=""mb-2"">$0.00</p>
                        </div>
                        <hr />

                        <div class=""d-flex justify-content-between"">
                            <p class=""mb-2"">Total price:</p>
                            <p class=""mb-2 fw-bold totalprice"">
                                ");
#nullable restore
#line 74 "C:\Users\ADMIN\Desktop\WebBanHang_1-master\WebBanHang\Areas\Customer\Views\Cart\Index.cshtml"
                           Write(string.Format("${0:#,##0}",
                                          Model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                        <div class=""mt-3"">
                            <a href=""/customer/order/index"" class=""btn btn-success w-100 shadow-0 mb-2"">
                                Make
                                Purchase
                            </a>
                            <a href=""/customer/home/index"" class=""btn btn-light w-100 border mt-2""> Back to shop </a>
                        </div>

                    </div>
                </div>
            </div>
            <!-- summary -->
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
