
$(document).ready(function () {
   
    setInterval(function () {
        $(".link span").remove();
        $(".link img").attr("src", "https://www.nubimetrics.com/img/logo.svg");
        $(".link img").attr("alt", "nubimetrics");
        $(".link img").attr("width", "200px");
        $(".link img").attr("height", "50px");
    }, 50);
});