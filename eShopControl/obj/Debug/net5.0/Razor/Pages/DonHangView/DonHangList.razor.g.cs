#pragma checksum "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faea700a51dad2cc4d7bf4bd9eb1cd57f813874e"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopControl.Pages.DonHangView
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
#line 2 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
using eShopShare;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/donhanglist")]
    public partial class DonHangList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Danh sách đơn hàng</h1>");
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
 if(donhangs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th scope=\"col\">Khách hàng</th>\r\n      <th scope=\"col\">Ngày đặt</th>\r\n      <th scope=\"col\">Tổng tiền</th>\r\n      <th scope=\"col\">Trạng thái</th>\r\n      <th scope=\"col\">Ghi chú</th></tr></thead>\r\n  ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 22 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
             foreach(var item in donhangs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<td></td>\r\n      ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 26 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
           item.NgayDat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 27 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
                         item.Tongtien

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
                         item.TrangthaiDonhang

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n      ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
           item.Ghichu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n      ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "btn btn-info");
            __builder.AddAttribute(23, "href", "/donhangdialog/" + (
#nullable restore
#line 30 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
                                                        item.DonHangID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n      ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "btn btn-info");
            __builder.AddAttribute(29, "href", "/donhangdetail/" + (
#nullable restore
#line 31 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
                                                        item.DonHangID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "Chi tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\hp\OneDrive\Máy tính\Ngocduy\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
      
    public List<DonHang> donhangs;
    protected  override void OnInitialized()
    {
        donhangs =  _donhangSvc.GetDonHangAll();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDonHangSvc _donhangSvc { get; set; }
    }
}
#pragma warning restore 1591