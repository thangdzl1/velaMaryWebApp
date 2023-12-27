//show product của update button
$(document).ready(function () {
  $(document).on("click", ".btn-update-show", function () {
    let row = $(this).closest('tr');
    let id = $(this).closest('tr').find(".btn-danger").data("product-id");
    // trỏ đến tag tr gần nhất
    /*returns array of all elements with "td-data"" class within the row with given id*/
    let data = row.find(".td-data");
    targetRow = data;

    console.log(data)

    let name = data[0].innerHTML;
    let price = data[1].innerHTML;
    let quantity = data[2].innerHTML;
    let collectionId = data[3].innerHTML;

    document.getElementById("Product_id").value = id;
    document.getElementById("Product_name").value = name;
    document.getElementById("Price").value = price;
    document.getElementById("Quantity").value = quantity;
    document.getElementById("Collection").value = collectionId;
    $("#myModal").modal("show");
  })


  //Sử dụng ajax để send request
  // $(".btn-update-product").click(function () {
  //   var formData = $("#updateForm").serialize();
  //   console.log("button clicked");

  //   $.ajax({
  //     url: 'https://localhost:44319/Admin/Product/Update',
  //     type: 'POST',
  //     contentType: 'application/json; charset=utf-8', // Change content type
  //     data: JSON.stringify(formData),
  //     success: function (result) {
  //       // Handle success response
  //       console.log(result);
  //       // Optionally, you can close the modal or perform other actions.
  //     },
  //     error: function (error) {
  //       // Handle error response
  //       console.log(error);
  //     }
  //   });
  // });

})


