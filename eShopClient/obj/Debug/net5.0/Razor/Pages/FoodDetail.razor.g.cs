#pragma checksum "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ea2b72c3c5c646aab5fb25964f640a47663813"
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
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/food-detail/{id}")]
    public partial class FoodDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "page-content");
            __builder.AddAttribute(2, "class", "page-content");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "product-detail");
            __builder.AddAttribute(5, "style", " margin-left: 202px; ");
            __builder.AddMarkupContent(6, "<h3>Detail Product</h3>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-6");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "slider-zoom");
#nullable restore
#line 16 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                         try
                        {
                            if (monan.Photos != null)
                            {
                                temp = imgUrl + monan.Photos.FirstOrDefault().FileName;
                            }
                            else
                            {
                                temp = imgUrl + "/nophoto.png";
                            }

                        }
                        catch
                        {

                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "cloud-zoom");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "alt", "Detail Zoom thumbs image");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 33 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                                                                      temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "data-zoom-image", 
#nullable restore
#line 33 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                                                                                              temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "style", "width: 100%;border-radius: 5%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-sm-6");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "\r\n                        Name: ");
            __builder.AddContent(27, 
#nullable restore
#line 39 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                               monan.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-sm-6");
            __builder.OpenElement(33, "p");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class");
            __builder.AddContent(36, "Price: ");
            __builder.AddContent(37, 
#nullable restore
#line 45 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                                                       monan.Gia.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " VND");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.AddMarkupContent(40, "<div class=\"col-sm-6 text-right\"><p></p></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.AddMarkupContent(42, "<p class=\"mb-1\"><strong>Quantity</strong></p>\r\n                    ");
            __builder.AddMarkupContent(43, "<div class=\"product_variant quantity\"><label>quantity</label></div>\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-sm-5");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "class", "vertical-spin");
            __builder.AddAttribute(50, "min", "1");
            __builder.AddAttribute(51, "max", "100");
            __builder.AddAttribute(52, "type", "number");
            __builder.AddAttribute(53, "data-bts-button-down-class", "btn btn-primary");
            __builder.AddAttribute(54, "data-bts-button-up-class", "btn btn-primary");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                                                                                                       quantity

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => quantity = __value, quantity, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        <div class=\"col-sm-6\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "product_meta");
#nullable restore
#line 69 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                         switch (monan.phanLoai)
                        {
                            case MonAn.PhanLoai.Combo:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "<span>Category: <a>Combo</a></span>");
#nullable restore
#line 73 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                                break;
                            default:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "<span>Category: <a>Đồ ăn nhanh</a></span>");
#nullable restore
#line 76 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                                break;
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "mt-3 btn btn-primary btn-lg");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
                                                                          () => AddCart(monan.Id,quantity)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "<i class=\"fa fa-shopping-basket\"></i> Add to Cart\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopClient\Pages\FoodDetail.razor"
      
    public List<MonAn> monAns = null;
    public MonAn monan = null;
    protected string imgUrl = "";
    protected string temp = "";
    public int quantity = 1;
    [Parameter]
    public string id { get; set; }
    protected override async Task OnInitializedAsync()
    {
        //sessionStorage.SetItem("name", "John Smith");
        //var name = sessionStorage.GetItem<string>("name");

        //monAns = _monAnService.GetMonAnAll();

        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();

        //monAns = new List<MonAn>();
        monan = new MonAn();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("MonAn/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                monan = Newtonsoft.Json.JsonConvert.DeserializeObject<MonAn>(apiResponse);
            }
        }
        temp = imgUrl + "nophoto.png";
        //monan = monAns.FirstOrDefault(x=>x.Id == int.Parse(id));
        Console.WriteLine(monan);

    }
    private void AddCart(int id, int soluong)
    {
        int sl = 1;
        //_cartSvc.AddToCart(id, monAns);
        if (soluong > 0)
        {
            sl = soluong;
        }

        //var cart = HttpContext.Session.GetString("cart");//get key cart
        var cart = sessionStorage.GetItem<string>("cart");//get key cart
        if (cart == null)
        {

            //var monAn = monAns.Where(u=>u.Id==id).FirstOrDefault();
            List<CartItem> listCart = new List<CartItem>()
            {
                    new CartItem
                    {
                        product = monan,
                        quantity = sl,
                        Sotien= (double)monan.Gia
                    }
            };

            PostCartModel giohang = new PostCartModel()
            {
                cartItems = listCart,
                TongTien = Tinhtien(listCart)
            };

            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        }
        else
        {
            //var monAn = monAns.Where(u => u.Id == id).FirstOrDefault();

            PostCartModel giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
            //List <ViewCart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
            bool check = true;
            for (int i = 0; i < giohang.cartItems.Count; i++)
            {
                if (giohang.cartItems[i].product.Id == id)
                {
                    giohang.cartItems[i].quantity += sl;
                    giohang.cartItems[i].Sotien = (double)monan.Gia * giohang.cartItems[i].quantity;
                    check = false;
                }
            }

            if (check)
            {
                //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
                giohang.cartItems.Add(new CartItem
                {
                    product = monan,
                    quantity = quantity + sl,
                    Sotien = (double)monan.Gia * 1
                });
            }
            giohang.TongTien = Tinhtien(giohang.cartItems);
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));

            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
        }
        _toastSvc.ShowSuccess($"Success");
        _OCSvc.Invoke();
        this.StateHasChanged();
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591