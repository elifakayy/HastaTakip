// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".chosen-select").chosen({
    no_results_text: "Oops, nothing found!"
})
//seçim kısmı id-> radioid,seçimler->id , seçimlerin style kısmı display olacak, choice inine myFunc()
function myFunc(radioid, id) {


    if (radioid.checked == true) {
        id.style.display = "block";

    }
    else {
        id.style.display = "none";
    }
}


function myFunc1(checkbox, id) {


    if (checkbox.checked == true) {
        id.style.display = "block";

    }
    else {
        id.style.display = "none";
    }
}