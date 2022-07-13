

$(document).ready(function () {

    $("#dvLadowanie")
        .clone()
        .show()
        .appendTo("#dvZawodnicyContent");

  //  $("#dvZawodnicyContent #dvLadowanie").show();

    zaladujZawodnikow(1);

    $("#btnSzukaj").click(function () {
        $("#dvLadowanie")
            .clone()
            .show()
            .prependTo("#dvZawodnicyContent");
        zaladujZawodnikow(1);
    });

    $("#txtFiltr").on('keydown', function (e) {
        if (e.key === 'Enter' || e.keyCode === 13) {
            e.preventDefault();
            $("#dvLadowanie")
                .clone()
                .show()
                .prependTo("#dvZawodnicyContent");
            zaladujZawodnikow(1);
        }
    });

});

function ustawStrone(wartosc) {
    $("#dvLadowanie")
        .clone()
        .show()
        .prependTo("#dvZawodnicyContent");

    var str = parseInt($("#txtStrona").val());
    var maxLiczbaStron = parseInt($("#lblLiczbaStron").html());
    str = str + wartosc;

    if (str <= maxLiczbaStron && str > 0) {
        //$("#txtStrona").val(str);
        zaladujZawodnikow(str);
    }    
}
function zaladujZawodnikow(str) {
    var filtr = $("#txtFiltr").val();
    $.ajax({
        method: "POST",
        url: "ZawodnicyServer.aspx",
        data: { nrStrony: str, filtr: filtr }
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