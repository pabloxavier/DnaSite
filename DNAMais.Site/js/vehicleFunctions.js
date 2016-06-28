function vehicleTransitionEffect() {

    $('#divPf, #divPj, #divFtp').hide();
    $('#btnDefaultVehicle').hide();
    $('#btnVehiclePhaseTwo').show();
    $('div.grid-vehicle').addClass('grid-vehicle-after-1');
    $('#divVehicle').removeClass('effect-dexter');
    $('#divVehicle').addClass('effect-dexter-2');

    setTimeout(function () {

        $('#btnBackVehicle').fadeIn(800);

    }, 1000);

}