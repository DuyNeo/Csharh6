#pragma checksum "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f514b3c420e24806f265938affb814f9eead7f"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopControl.Pages.Monan
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using eShopControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\_Imports.razor"
using eShopControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
using eShopShare;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monanlist")]
    public partial class MonAnList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Danh sách món ăn</h1>");
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
 if(monans == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<a class=\"btn btn-info p-10\" href=\"/monandialog/0\">Thêm</a>\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th scope=\"col\">Tên</th>\r\n      <th scope=\"col\">Giá</th>\r\n      <th scope=\"col\">Phân loại</th>\r\n      <th scope=\"col\">Hình</th>\r\n      <th scope=\"col\">Trạng thái</th></tr></thead>\r\n  ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 23 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
             foreach(var item in monans)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 26 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
            item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n      ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 27 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
           item.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 28 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                         switch (@item.phanLoai)
                        {
                            case MonAn.PhanLoai.DoAnNhanh:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<span>Đồ ăn nhanh</span>");
#nullable restore
#line 32 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                                break;
                            default:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<span>Combo</span>");
#nullable restore
#line 35 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                                break;
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 37 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                         if (item.Photos.Any())
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", "images/food/" + (
#nullable restore
#line 39 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                                           item.Photos.FirstOrDefault().FileName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "alt");
            __builder.AddAttribute(22, "style", "width:150px;border-radius:0px");
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<img src=\"~/images/nophoto.png\" alt style=\"width:150px;border-radius:0px\">");
#nullable restore
#line 44 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n      ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 46 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
           item.TrangThai

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n      ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-info");
            __builder.AddAttribute(31, "href", "/monandialog/" + (
#nullable restore
#line 47 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                                                      item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n      ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "class", "btn btn-info");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
                                              ()=>Delete(@item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "Xóa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\Monan\MonAnList.razor"
      
    public List<MonAn> monans;
    protected  override void OnInitialized()
    {
        monans =  _monanSvc.GetMonAnAll();
    }
    private void Delete(int id)
    {
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonAnSvc _monanSvc { get; set; }
    }
}
#pragma warning restore 1591
