// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    showQuantityCart();
})
$(".addtocart").click(function (evt) {
    evt.preventDefault();
    let id = $(this).attr("data-productID")
    $.ajax({
        url: "/Customer/Cart/AddToCartAPI",
        data: { "productID": id },
        success: function (data) {
            Swal.fire({
                title: data.msg,
                text: "You clicked the button",
                icon: "success"
            });
            showQuantityCart();
        }
    })
   // alert(id);
})

$(".btnUpdate").click(function (evt) {
    evt.preventDefault();
    alert("tesst");
    let id = $(this).attr("data-productID")
    let qty = $(this).closest("form").find(".qty").val();
    $.ajax({
        url: "/Customer/Cart/UpdateToCartAPI",
        data: { "productID": id, "qty":qty },
        success: function (data) {
            Swal.fire({
                title: data.msg,
                text: "Cập nhật sản phẩm thành công",
                icon: "success"
            });
            showQuantityCart();
            showTotalPrice();
        }
    })

})
$(".btnPhoneSearch").click(function (evt) {
    evt.preventDefault();
    let qty = $(this).closest("form").find(".Phone").val();
    $.ajax({
        url: "/Admin/ManagementOrder/SearchPhoneAPI",
        data: { "Phone": Phone },
        success: function (data) {
            Swal.fire({
                title: data.msg,
                text: "Cập nhật sản phẩm thành công",
                icon: "success"
            });
            showQuantityCart();
            showTotalPrice();
        }
    })

})

//$(".btnremove").click(function (evt) {
//    evt.preventDefault();
//    let id = $(this).attr("data-productID")
//    $.ajax({
//        url: "/Customer/Cart/DeleteAPI",
//        data: { "productID": id},
//        success: function (data) {
//            Swal.fire({
//                title: data.msg,
//                text: "Xoá sản phẩm thành công",
//                icon: "success"
//            });
//            showTotalPrice();
//        }
//    })
//})


let showTotalPrice = () => {
    $.ajax({
        url: "/Customer/Cart/GetTotalPrice",
        success: function (data) {
            let num = new Intl.NumberFormat('ja-JP', { style: 'currency', currency: 'USD' }).format(
                data.total,
            )
            $(".totalprice").text(num);
        }
    })

}

let showQuantityCart = () => {
    $.ajax({
        url: "/Customer/Cart/GetQuantity",
        success: function (data) {        
            $(".showcart").text(data.qty)
        }
    })
   // alert(id);
}