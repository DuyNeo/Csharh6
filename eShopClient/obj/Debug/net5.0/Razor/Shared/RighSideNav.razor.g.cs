#pragma checksum "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04f77915305790838d631316a740de041e7bf21f"
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
#line 1 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    public partial class RighSideNav : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "class", "navbar fixed-top navbar-expand-md navbar-dark bg-transparent");
            __builder.AddAttribute(3, "id", "page-navigation");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "<a href=\"/\" class=\"navbar-brand\"><img src=\"assets/img/logo/logofood.png\" alt></a>\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(7, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarcollapse\" aria-controls=\"navbarCollapse\" aria-expanded=\"false\" aria-label=\"Toggle navigation\"><span class=\"navbar-toggler-icon\"></span></button>\r\n\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "collapse navbar-collapse");
            __builder.AddAttribute(10, "id", "navbarcollapse");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "navbar-nav ml-auto");
            __builder.AddMarkupContent(13, "<li class=\"nav-item\"><a href=\"/\" class=\"nav-link\">Shop</a></li>");
#nullable restore
#line 32 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                     if (CheckLogin() != null && CheckLogin() != "")
                    {



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, @"<li class=""nav-item dropdown""><a class=""nav-link dropdown-toggle"" href=""javascript:void(0)"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><div class=""avatar-header""><img src=""assets/img/logo/avatar.jpg""></div></a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown""><a class=""dropdown-item"" href=""/History"">Transactions History</a>
                                <a class=""dropdown-item"" href>Settings</a>
                                <a href=""/register"" class=""dropdown-item"">Register</a>
                                <a class=""dropdown-item"" href=""/logout"">Logout</a></div></li>");
#nullable restore
#line 48 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<li class=\"nav-item\"><a href=\"/register\" class=\"nav-link\">Register</a></li>\r\n                        ");
            __builder.AddMarkupContent(16, "<li class=\"nav-item\"><a href=\"/login\" class=\"nav-link\">Login</a></li>");
#nullable restore
#line 57 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item dropdown");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "javascript:void(0)");
            __builder.AddAttribute(21, "class", "nav-link dropdown-toggle");
            __builder.AddAttribute(22, "data-toggle", "dropdown");
            __builder.AddAttribute(23, "aria-haspopup", "true");
            __builder.AddAttribute(24, "aria-expanded", "false");
            __builder.AddMarkupContent(25, "<i class=\"fa fa-shopping-basket\"></i> ");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "badge badge-primary");
            __builder.AddContent(28, 
#nullable restore
#line 62 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                                                                     GetCountCart()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "dropdown-menu shopping-cart");
            __builder.OpenElement(32, "ul");
            __builder.AddMarkupContent(33, "<li><div class=\"drop-title\">Your Cart</div></li>\r\n                                ");
            __builder.OpenElement(34, "li");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "shopping-cart-list");
#nullable restore
#line 71 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                         if (IsGioHangNotNull())
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                             foreach (var item in giohang.cartItems)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "media");
#nullable restore
#line 76 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                      
                                                        if (item.product.Photos.Any())
                                                        {
                                                            temp = imgUrl + item.product.Photos.FirstOrDefault().FileName;
                                                        }
                                                        else
                                                        {
                                                            temp = imgUrl + "/nophoto.png";
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "class", "d-flex mr-3");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 86 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                                                   temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "width", "60");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "media-body");
            __builder.OpenElement(46, "p");
            __builder.AddContent(47, "Name: ");
            __builder.AddContent(48, 
#nullable restore
#line 88 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                                  item.product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                                        ");
            __builder.OpenElement(50, "p");
            __builder.AddAttribute(51, "class");
            __builder.AddMarkupContent(52, "\r\n\r\n                                                            Price: ");
            __builder.AddContent(53, 
#nullable restore
#line 91 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                                    item.product.Gia.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(54, " VND\r\n                                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                                        ");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "class", "text-muted");
            __builder.AddContent(58, "Quantity: ");
            __builder.AddContent(59, 
#nullable restore
#line 93 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                                                         item.quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                             



                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "<div style=\" text-align: center; font-size: 20px;\">Cart is empty</div>");
#nullable restore
#line 104 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "li");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "drop-title d-flex justify-content-between");
            __builder.AddMarkupContent(65, "<span>Total:</span>\r\n                                        ");
            __builder.OpenElement(66, "span");
            __builder.AddAttribute(67, "class", "text-primary");
            __builder.OpenElement(68, "strong");
            __builder.AddContent(69, 
#nullable restore
#line 110 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                                            giohang.TongTien

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, " VND");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.OpenElement(72, "li");
            __builder.AddAttribute(73, "class", "d-flex justify-content-between  pr-3 ");
            __builder.AddMarkupContent(74, "<a href=\"/cart\" class=\"btn btn-primary\" style=\"margin-right: 13px; margin-left: 3px; \">View Cart</a>");
#nullable restore
#line 115 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                     if (@emailAddress != null && @emailAddress != "")
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "href", "");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                                             ()=>OrderCart()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "class", "btn btn-primary");
            __builder.AddMarkupContent(79, "\r\n\r\n                                            Checkout\r\n\r\n                                        ");
            __builder.CloseElement();
#nullable restore
#line 122 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "<a href=\"/login\" class=\"btn btn-primary\">\r\n                                            You need to login to order\r\n                                        </a>");
#nullable restore
#line 129 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"


                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.AddMarkupContent(82, "<div class=\"banner\"><div class=\"jumbotron jumbotron-video text-center bg-dark mb-0 rounded-0\"><div class=\"container\"><h1 class=\"pt-5\">\r\n                Save time and leave the<br>\r\n                groceries to us.\r\n            </h1>\r\n            <p class=\"lead\">\r\n                Always Fresh Everyday.\r\n            </p>\r\n\r\n            <div class=\"row\"><div class=\"col-md-4\"><div class=\"card border-0 text-center\"><div class=\"card-icon\"><div class=\"card-icon-i\"><i class=\"fa fa-shopping-basket\"></i></div></div>\r\n                        <div class=\"card-body\"><h4 class=\"card-title\">\r\n                                Buy\r\n                            </h4>\r\n                            <p class=\"card-text\">\r\n                                Simply click-to-buy on the product you want and submit your order when you\'re done.\r\n                            </p></div></div></div>\r\n                <div class=\"col-md-4\"><div class=\"card border-0 text-center\"><div class=\"card-icon\"><div class=\"card-icon-i\"><i class=\"fas fa-leaf\"></i></div></div>\r\n                        <div class=\"card-body\"><h4 class=\"card-title\">\r\n                                Harvest\r\n                            </h4>\r\n                            <p class=\"card-text\">\r\n                                Our team ensures the produce quality is up to our standard and delivers to your door within 24 hours of harvest day.\r\n                            </p></div></div></div>\r\n                <div class=\"col-md-4\"><div class=\"card border-0 text-center\"><div class=\"card-icon\"><div class=\"card-icon-i\"><i class=\"fa fa-truck\"></i></div></div>\r\n                        <div class=\"card-body\"><h4 class=\"card-title\">\r\n                                Delivery\r\n                            </h4>\r\n                            <p class=\"card-text\">\r\n                                Farmers receive your orders two days in advance so they can prepare for harvest exactly as your orders – no wasted produce.\r\n                            </p></div></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 212 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Shared\RighSideNav.razor"
      
    string emailAddress;
    string Name;
    public PostCartModel giohang;
    protected string imgUrl = "";
    string cart;
    int cartItemCount = 0;
    protected string temp = "";
    protected override void OnInitialized()
    {
        CheckLogin();
        //cart = sessionStorage.GetItem<string>("cart");
        _OCSvc.OnChange += StateHasChanged;
        emailAddress = sessionStorage.GetItem<string>("Email");//get key cart
        getGioHang();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
    }
    public void Dispose()
    {
        _OCSvc.OnChange -= StateHasChanged;
    }
    public void getGioHang()
    {
        var cart = sessionStorage.GetItem<string>("cart");//get key cart

        if (cart == null)
        {
            giohang = new PostCartModel();
        }
        else
        {
            giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
        }
    }
    private async Task OrderCart()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var khachhangId = sessionStorage.GetItem<string>("KhachhangId");

        if (giohang.cartItems.Count <= 0 || giohang.cartItems == null)
        {
            _toastSvc.ShowError($"Cart Empty");
            return ;
        }
        giohang.khachHangId = khachhangId;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(giohang), System.Text.Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "Cart", content);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                //error += (error == "" ? "" : "<br/>") + " - Lỗi khi gọi API.";
                //xu ly loi
                //return Content(response.ToString());
            }
            else
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                if (apiResponse == "-1")
                {

                }
                else // luu thanh cong
                {
                    sessionStorage.RemoveItem("cart");
                    //await JSRuntime.InvokeAsync<object>("clearCart", "");
                    NavigationManager.NavigateTo("/history");
                }
            }
        }
        _OCSvc.Invoke();
    }
    private bool IsGioHangNotNull()
    {
        getGioHang();
        if (giohang.cartItems != null)
            return true;
        return false;
    }
    private void DeleteCart(CartItem item)
    {
        giohang.cartItems.Remove(item);
        giohang.TongTien = Tinhtien(giohang.cartItems);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
        _OCSvc.Invoke();
    }
    public string CheckLogin()
    {
        return emailAddress = sessionStorage.GetItem<string>("Email");
    }

    private double Tinhtien(List<CartItem> listCart)
    {
        double tongtien = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                tongtien += listCart[i].Sotien;
            }
        }
        return tongtien;
    }
    public int GetCountCart()
    {
        cart = sessionStorage.GetItem<string>("cart");
        if (cart != null)
        {
            PostCartModel giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
            var temp = cartItemCount = giohang.cartItems.Count;
            return temp;
        }
        return 0;
    }
    protected void o()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        cart = sessionStorage.GetItem<string>("cart");
    }

    protected void Logout()
    {
        sessionStorage.RemoveItem("AccessToken");
        sessionStorage.RemoveItem("Email");
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
