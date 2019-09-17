// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function(){
  $('[data-toggle="tooltip"]').tooltip();
});

document.querySelectorAll("#petcreator img").forEach(item => {
  item.addEventListener("click", event => {
    document.getElementById("namefield").style.display = "table-row";
    document.getElementById("colorfield").style.display = "table-row";
    document.querySelector("#petwindow image").setAttribute("xlink:href", item.getAttribute("src"));
    document.querySelector("#petwindow h5").textContent = item.getAttribute("species_name");
    document.querySelector("#petwindow p").textContent = item.getAttribute("species_desc");
    document.querySelector("#speciesname").setAttribute("value", item.getAttribute("species_name"));
    document.querySelector("#petwindow h6").textContent = item.getAttribute("species_stats");
  })
 });

document.getElementById("colorpicker").addEventListener("change", () => {
  document.querySelector("#petwindow feFlood").setAttribute("flood-color", document.getElementById("colorpicker").value);
});