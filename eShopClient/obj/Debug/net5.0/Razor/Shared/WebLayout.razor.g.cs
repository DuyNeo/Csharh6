#pragma checksum "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\WebLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a40408a6006c2ea766da47ced0e872a1e1a24e72"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using eShopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using eShopClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using eShopClient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\WebLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class WebLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"off_canvars_overlay\" b-54ym07er1g></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page-header");
            __builder.AddAttribute(3, "b-54ym07er1g");
            __builder.OpenComponent<eShopClient.Shared.RighSideNav>(4);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddAttribute(8, "b-54ym07er1g");
            __builder.OpenElement(9, "main");
            __builder.AddAttribute(10, "role", "main");
            __builder.AddAttribute(11, "class", "pb-3");
            __builder.AddAttribute(12, "b-54ym07er1g");
            __builder.AddContent(13, 
#nullable restore
#line 16 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\WebLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.AddMarkupContent(15, "<footer b-54ym07er1g><div class=\"container\" b-54ym07er1g><div class=\"row\" b-54ym07er1g><div class=\"col-md-3\" b-54ym07er1g><h5 b-54ym07er1g>About</h5>\r\n                <p b-54ym07er1g>Nisi esse dolor irure dolor eiusmod ex deserunt proident cillum eu qui enim occaecat sunt aliqua anim eiusmod qui ut voluptate.</p></div>\r\n            <div class=\"col-md-3\" b-54ym07er1g><h5 b-54ym07er1g>Links</h5>\r\n                <ul b-54ym07er1g><li b-54ym07er1g><a href=\"about.html\" b-54ym07er1g>About</a></li>\r\n                    <li b-54ym07er1g><a href=\"contact.html\" b-54ym07er1g>Contact Us</a></li>\r\n                    <li b-54ym07er1g><a href=\"faq.html\" b-54ym07er1g>FAQ</a></li>\r\n                    <li b-54ym07er1g><a href=\"javascript:void(0)\" b-54ym07er1g>How it Works</a></li>\r\n                    <li b-54ym07er1g><a href=\"terms.html\" b-54ym07er1g>Terms</a></li>\r\n                    <li b-54ym07er1g><a href=\"privacy.html\" b-54ym07er1g>Privacy Policy</a></li></ul></div>\r\n            <div class=\"col-md-3\" b-54ym07er1g><h5 b-54ym07er1g>Contact</h5>\r\n                <ul b-54ym07er1g><li b-54ym07er1g><a href=\"tel:+620892738334\" b-54ym07er1g><i class=\"fa fa-phone\" b-54ym07er1g></i> 08272367238</a></li>\r\n                    <li b-54ym07er1g><a href=\"mailto:hello@domain.com\" b-54ym07er1g><i class=\"fa fa-envelope\" b-54ym07er1g></i> hello@domain.com</a></li></ul>\r\n\r\n                <h5 b-54ym07er1g>Follow Us</h5>\r\n                <ul class=\"social\" b-54ym07er1g><li b-54ym07er1g><a href=\"javascript:void(0)\" target=\"_blank\" b-54ym07er1g><i class=\"fab fa-facebook-f\" b-54ym07er1g></i></a></li>\r\n                    <li b-54ym07er1g><a href=\"javascript:void(0)\" target=\"_blank\" b-54ym07er1g><i class=\"fab fa-instagram\" b-54ym07er1g></i></a></li>\r\n                    <li b-54ym07er1g><a href=\"javascript:void(0)\" target=\"_blank\" b-54ym07er1g><i class=\"fab fa-youtube\" b-54ym07er1g></i></a></li></ul></div>\r\n            <div class=\"col-md-3\" b-54ym07er1g><h5 b-54ym07er1g>Get Our App</h5>\r\n                <ul class=\"mb-0\" b-54ym07er1g><li class=\"download-app\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><img src=\"assets/img/playstore.png\" b-54ym07er1g></a></li>\r\n                    <li style=\"height: 200px\" b-54ym07er1g><div class=\"mockup\" b-54ym07er1g><img src=\"assets/img/mockup.png\" b-54ym07er1g></div></li></ul></div></div></div>\r\n    <p class=\"copyright\" b-54ym07er1g>&copy; Duynnps17015@fpt.edu.vn </p></footer>\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(16);
            __builder.AddAttribute(17, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 92 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\WebLayout.razor"
                          ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 93 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\WebLayout.razor"
                         3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 94 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\WebLayout.razor"
                          IconType.FontAwesome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(21, "ErrorIcon", "fa fa-bug");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
