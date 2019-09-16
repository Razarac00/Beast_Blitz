// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function(){
  $('[data-toggle="tooltip"]').tooltip();
});

$("#petcreator img").on("click", function(){
  $("#petwindow image").attr("xlink:href", $(this).attr("src"));
  $("#petwindow h5").html($(this).attr("species_name"));
  $("#petwindow p").html($(this).attr("species_desc"));
});


$(document).on("change", "input", function(){
  $("#petwindow feFlood").attr("flood-color", document.getElementById("colorpicker").value);
})