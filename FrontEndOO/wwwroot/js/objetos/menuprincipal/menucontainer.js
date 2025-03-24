//---menucontainer.js---
$("#menu_containers").css("margin-left","1%");
$("#menu_containers").text("Container");
$("#menu_containers").on("click", function () {
    AjaxAsync(
        "GET",
        "/Principal/PaginaContainers",
        null,
        "text",
        "application/x-www-form-urlencoded; charset=UTF-8",
        function (data) {
            $("script#containers_exemplo").remove();
            $("#corpo_principal").html("");
            $("head").append(data);
        },
        function (data) {
            $("#corpo_principal").append('<img id="loading" class="animation--Gl63I" srcset="https://cdn.pixabay.com/animation/2023/11/09/03/05/03-05-45-320_256.gif 1x, https://cdn.pixabay.com/animation/2023/11/09/03/05/03-05-45-320_512.gif 2x" src="https://cdn.pixabay.com/animation/2023/11/09/03/05/03-05-45-320_512.gif" alt="Cinza, Gradiente, Carregador, Carregando" style="max-width: 20%; max-height: 20%;margin-left:40%;margin-right:40%;margin-top:15%;">');

        },
        function (data) {
            $("#corpo_principal > #loading").remove();
        });
});
//---menucontainer.js---