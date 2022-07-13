



$(document).ready(function () {

    $("#btnPoliczhtml").click(function () {

        var liczba1 = $("#txtLiczba1html").val();
        var liczba2 = $("#txtLiczba2html").val();

        //var wynik = parseInt(liczba1) + parseInt(liczba2);

        $.ajax({
            method: "POST",
            url: "DefaultServer.aspx",
            data: { liczba1: liczba1, liczba2: liczba2 }
        })
            .done(function (msg) {
                $("#lblWynikhtml").html(msg);
            });


        //$("#lblWynikhtml").html(wynik);

    });



});