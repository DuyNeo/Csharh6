#pragma checksum "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4922153c6c547479b581bcce4ff19d11429565a2"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopClient.Pages
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
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "page-content");
            __builder.AddAttribute(2, "class", "page-content");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "banner");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "jumbotron jumbotron-bg text-center rounded-0 bg-white text-dark");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.AddMarkupContent(9, "<h1 class=\"pt-5\">\r\n                    Login Page\r\n                </h1>\r\n                ");
            __builder.AddMarkupContent(10, "<p class=\"lead\">\r\n                    Save time and leave the groceries to us.\r\n                </p>\r\n\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card card-login mb-5");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-horizontal");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group row mt-3");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-12");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "required", "");
            __builder.AddAttribute(25, "placeholder", "Username");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
                                                                                                                        Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group row");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-12");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "type", "password");
            __builder.AddAttribute(36, "required", "");
            __builder.AddAttribute(37, "placeholder", "Password");
            __builder.AddAttribute(38, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
                                                                                                                                                  Enter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
                                                                                                                           password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.AddMarkupContent(42, @"<div class=""form-group row""><div class=""col-md-12 d-flex justify-content-between align-items-center""><div class=""checkbox""><input id=""checkbox0"" type=""checkbox"" name=""remember"">
                                        <label for=""checkbox0"" class=""mb-0""> Remember Me? </label></div>
                                    <a href=""/login"" class><i class=""fa fa-bell""></i> Forgot password?</a></div></div>
                            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group row text-center mt-4");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-md-12");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "type", "submit");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
                                                                    CheckLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn btn-primary btn-block text-uppercase");
            __builder.AddContent(51, "Log In");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
                                 if (!string.IsNullOrEmpty(error))
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "alert alert-danger mt-3 mb-0");
            __builder.AddContent(54, 
#nullable restore
#line 54 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
                                                                                (MarkupString)error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\Login.razor"
       
 
    private string error;
    string Email = "";
    string password = "";

  
    protected override void OnInitialized()
    {
    }

    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }

    public void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            if (password != "")
            {
                CheckLogin();
            }
        }
    }

    private async Task CheckLogin()
    {
        error = "";
        if (Email == "")
        {
            error = " - Bạn cần nhập email.";
        }
        if (password == "")
        {
            error += (error == "" ? "" : "<br/>") + " - Bạn cần nhập password.";
        }
        if (error == "")
        {

            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            using (var client = new HttpClient())
            {
                ViewWebLogin viewWebLogin = new ViewWebLogin() { Email = Email, Password = password };
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                //client.DefaultRequestHeaders.Authorization =new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(viewWebLogin), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl + "Token", content);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    error += (error == "" ? "" : "<br/>") + " - Lỗi khi gọi API";
                    //xu ly loi
                    //return Content(response.ToString());
                }
                else
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    var viewToken = Newtonsoft.Json.JsonConvert.DeserializeObject<ViewToken>(apiResponse);

                    var accessToken = viewToken.Token;
                    sessionStorage.SetItem("KhachhangId", viewToken.KhachhangId);
                    sessionStorage.SetItem("Email", viewToken.Email);
                    sessionStorage.SetItem("UserName", Email);
                    //Console.WriteLine("email: " + viewToken.Email);
                    sessionStorage.SetItem("AccessToken", accessToken);
                    await auth.GetAuthenticationStateAsync();
                    //await JSRuntime.InvokeAsync<object>("refreshMenu", new {email= email});
                    //await JSRuntime.InvokeAsync<object>("CalledJSFunctionWithParameter", "Jignesh Trivedi");
                    _toastSvc.ShowSuccess($"Login Success {viewToken.Email}");
                    _OCSvc.Invoke();
                    NavigationManager.NavigateTo("/");
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
