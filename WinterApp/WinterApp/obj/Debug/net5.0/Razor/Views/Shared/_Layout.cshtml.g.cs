#pragma checksum "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework06.12\WinterApp\WinterApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4069df891e330547b3b09c60f363e8158341acb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework06.12\WinterApp\WinterApp\Views\_ViewImports.cshtml"
using WinterApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework06.12\WinterApp\WinterApp\Views\_ViewImports.cshtml"
using WinterApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4069df891e330547b3b09c60f363e8158341acb0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf7d3b42be694a26974fff057bc64c567407c3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-between search-inner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://spondonit.us12.list-manage.com/subscribe/post?u=1462626880ade1ac87bd9c93a&amp;id=92a4423d01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe_form relative mail_part"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n<!-- Mirrored from preview.colorlib.com/theme/winter/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Mon, 06 Dec 2021 14:15:08 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4069df891e330547b3b09c60f363e8158341acb05308", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport""
          content=""width=device-width, initial-scale=1, shrink-to-fit=no"" />
    <title>winter</title>
    <link rel=""icon"" href=""img/xfavicon.png"" />
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""css/style.css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4069df891e330547b3b09c60f363e8158341acb06614", async() => {
                WriteLiteral(@"
    <header class=""main_menu home_menu"">
        <div class=""container-fluid"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-lg-11"">
                    <nav class=""navbar navbar-expand-lg navbar-light"">
                        <a class=""navbar-brand"" href=""index.html""> <img src=""img/xlogo.png.pagespeed.ic.eaB5aFJS3b.png"" alt=""logo""> </a>
                        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                            <span class=""menu_icon""><i class=""fas fa-bars""></i></span>
                        </button>
                        <div class=""collapse navbar-collapse main-menu-item"" id=""navbarSupportedContent"">
                            <ul class=""navbar-nav"">
                                <li class=""nav-item"">
                                    <a class=""nav-link""");
                WriteLiteral(@" href=""index.html"">Home</a>
                                </li>
                                <li class=""nav-item dropdown"">
                                    <a class=""nav-link dropdown-toggle"" href=""blog.html"" id=""navbarDropdown_1"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        Shop
                                    </a>
                                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown_1"">
                                        <a class=""dropdown-item"" href=""category.html""> shop category</a>
                                        <a class=""dropdown-item"" href=""single-product.html"">product details</a>
                                    </div>
                                </li>
                                <li class=""nav-item dropdown"">
                                    <a class=""nav-link dropdown-toggle"" href=""blog.html"" id=""navbarDropdown_3"" role=""button"" data-toggle=""dropdow");
                WriteLiteral(@"n"" aria-haspopup=""true"" aria-expanded=""false"">
                                        pages
                                    </a>
                                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown_2"">
                                        <a class=""dropdown-item"" href=""login.html"">
                                            login
                                        </a>
                                        <a class=""dropdown-item"" href=""tracking.html"">tracking</a>
                                        <a class=""dropdown-item"" href=""checkout.html"">product checkout</a>
                                        <a class=""dropdown-item"" href=""cart.html"">shopping cart</a>
                                        <a class=""dropdown-item"" href=""confirmation.html"">confirmation</a>
                                        <a class=""dropdown-item"" href=""elements.html"">elements</a>
                                    </div>
                                </li>
     ");
                WriteLiteral(@"                           <li class=""nav-item dropdown"">
                                    <a class=""nav-link dropdown-toggle"" href=""blog.html"" id=""navbarDropdown_2"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        blog
                                    </a>
                                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown_2"">
                                        <a class=""dropdown-item"" href=""blog.html""> blog</a>
                                        <a class=""dropdown-item"" href=""single-blog.html"">Single blog</a>
                                    </div>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""contact.html"">Contact</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""hearer_icon d-fl");
                WriteLiteral(@"ex"">
                            <div class=""dropdown cart"">
                                <a class=""dropdown-toggle"" href=""#"" id=""navbarDropdown3"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""ti-bag""></i>
                                </a>

                            </div>
                            <a id=""search_1"" href=""javascript:void(0)""><i class=""ti-search""></i></a>
                        </div>
                    </nav>
                </div>
            </div>
        </div>
        <div class=""search_input"" id=""search_input_box"">
            <div class=""container "">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4069df891e330547b3b09c60f363e8158341acb011999", async() => {
                    WriteLiteral(@"
                    <input type=""text"" class=""form-control"" id=""search_input"" placeholder=""Search Here"">
                    <button type=""submit"" class=""btn""></button>
                    <span class=""ti-close"" id=""close_search"" title=""Close Search""></span>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </header>\r\n    ");
#nullable restore
#line 89 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework06.12\WinterApp\WinterApp\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer class=""footer_part"">
        <div class=""container"">
            <div class=""row justify-content-between"">
                <div class=""col-sm-6 col-lg-2"">
                    <div class=""single_footer_part"">
                        <h4>Category</h4>
                        <ul class=""list-unstyled"">
                            <li><a href=""#"">Male</a></li>
                            <li><a href=""#"">Female</a></li>
                            <li><a href=""#"">Shoes</a></li>
                            <li><a href=""#"">Fashion</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-sm-6 col-lg-2"">
                    <div class=""single_footer_part"">
                        <h4>Company</h4>
                        <ul class=""list-unstyled"">
                            <li><a href=""#"">About</a></li>
                            <li><a href=""#"">News</a></li>
                            <li><a href=""#"">FAQ</a></li>
 ");
                WriteLiteral(@"                           <li><a href=""#"">Contact</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-sm-6 col-lg-3"">
                    <div class=""single_footer_part"">
                        <h4>Address</h4>
                        <ul class=""list-unstyled"">
                            <li><a href=""#"">200, Green block, NewYork</a></li>
                            <li><a href=""#"">+10 456 267 1678</a></li>
                            <li><span><a href=""https://preview.colorlib.com/cdn-cgi/l/email-protection"" class=""__cf_email__"" data-cfemail=""41222e2f3520223579780136282f3524336f222e2c"">[email&#160;protected]</a></span></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-sm-6 col-lg-4"">
                    <div class=""single_footer_part"">
                        <h4>Newsletter</h4>
                        <div id=""mc_embed_signup"">
                          ");
                WriteLiteral("  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4069df891e330547b3b09c60f363e8158341acb016160", async() => {
                    WriteLiteral(@"
                                <input type=""email"" name=""email"" id=""newsletter-form-email"" placeholder=""Email Address"" class=""placeholder hide-on-focus"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = ' Email Address '"">
                                <button type=""submit"" name=""submit"" id=""newsletter-submit"" class=""email_icon newsletter-submit button-contactForm"">subscribe</button>
                                <div class=""mt-10 info""></div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""social_icon"">
                            <a href=""#""><i class=""ti-facebook""></i></a>
                            <a href=""#""><i class=""ti-twitter-alt""></i></a>
                            <a href=""#""><i class=""ti-instagram""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row justify-content-center"">
                <div class=""col-lg-12"">
                    <div class=""copyright_text"">
                        <P>
                            Copyright &copy;
                            <script data-cfasync=""false"" src=""../../cdn-cgi/scripts/5c5dd728/cloudflare-static/email-decode.min.js""></script>
                            <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""ti-heart"" aria-hidden=""true""></i> by <a href=""https://colorlib.com/"" target=""_blank"">Colorlib</a>
    ");
                WriteLiteral(@"                    </P>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <script src=""js/jquery-1.12.1.min.js""></script>

    <script src=""js/popper.min.js%2bbootstrap.min.js.pagespeed.jc.ZWMFEn8lZ1.js""></script>
    <script>
        eval(mod_pagespeed_dxyRlYrtvE);
    </script>

    <script>
        eval(mod_pagespeed_Hn$GnOENg2);
    </script>

    <script src=""js/jquery.magnific-popup.js""></script>

    <script src=""js/swiper.min.js""></script>

    <script src=""js/mixitup.min.js""></script>

    <script src=""js/owl.carousel.min.js%2bjquery.nice-select.min.js%2bslick.min.js%2bjquery.counterup.min.js%2bwaypoints.min.js.pagespeed.jc.ze094Zozg5.js""></script>
    <script>
        eval(mod_pagespeed_hxG02cVh3V);
    </script>
    <script>
        eval(mod_pagespeed_ueTBKpOz$t);
    </script>

    <script>
        eval(mod_pagespeed_S25ttLLG4v);
    </script>
    <script>
        eval(mod_pagespeed_otMkWM3vyI);
    </script>");
                WriteLiteral(@"
    <script>
        eval(mod_pagespeed_Is2zdZ3I3j);
    </script>
    <script src=""js/contact.js%2bjquery.ajaxchimp.min.js%2bjquery.form.js%2bjquery.validate.min.js%2bmail-script.js%2bcustom.js.pagespeed.jc.hMwjWN0xZX.js""></script>
    <script>
        eval(mod_pagespeed_87rnHIvtt$);
    </script>
    <script>
        eval(mod_pagespeed_cq3D5gZ0$b);
    </script>
    <script>
        eval(mod_pagespeed_YT$R9a375s);
    </script>
    <script>
        eval(mod_pagespeed_mBypHroDZo);
    </script>
    <script>
        eval(mod_pagespeed_MFtf9Rgw0h);
    </script>

    <script>
        eval(mod_pagespeed_wLslHVcp1B);
    </script>

    <script async
            src=""https://www.googletagmanager.com/gtag/js?id=UA-23581568-13""></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() {
            dataLayer.push(arguments);
        }
        gtag(""js"", new Date());

        gtag(""config"", ""UA-23581568-13"");
    </script>
    <script defer");
                WriteLiteral(@"
            src=""https://static.cloudflareinsights.com/beacon.min.js/v64f9daad31f64f81be21cbef6184a5e31634941392597""
            integrity=""sha512-gV/bogrUTVP2N3IzTDKzgP0Js1gg4fbwtYB6ftgLbKQu/V8yH2+lrKCfKHelh4SO3DPzKj4/glTO+tNJGDnb0A==""
            data-cf-beacon='{""rayId"":""6b961f1c19eb6b4a"",""token"":""cd0b4b3a733644fc843ef0b185f98241"",""version"":""2021.11.0"",""si"":100}'
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from preview.colorlib.com/theme/winter/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Mon, 06 Dec 2021 14:15:17 GMT -->\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
