

$(document).ready(function () {
    zaladujZawodnikow(1);
});

function ustawStrone(wartosc) {
    var str = parseInt($("#txtStrona").val());
    var maxLiczbaStron = parseInt($("#lblLiczbaStron").html());
    str = str + wartosc;

    if (str <= maxLiczbaStron && str > 0) {
        $("#txtStrona").val(str);
        zaladujZawodnikow(str);
       
    }    
}
function zaladujZawodnikow(str) {
    $.ajax({
        method: "POST",
        url: "ZawodnicyServer.aspx",
        data: { nrStrony: str }
    })
        .done(function (msg) {
            $("#dvZawodnicyContent").html(msg);

            $("#btnLewo").click(function () {
                ustawStrone(-1);
            });
            $("#btnPrawo").click(function () {
                ustawStrone(+1);
            });
        });
}