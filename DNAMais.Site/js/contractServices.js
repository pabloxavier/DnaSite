$(document).ready(function () {

    //Pessoa Física
    //Clique em CPF, Endereço, Nome ou Telefone
    $('#btnCpf, #btnAddr, #btnName, #btnTel').on('click', function (e) {

        var idClick = e.target.id;

        //Clicando em CPF
        if (idClick == "btnCpf") {

            transitionEffect();

            setTimeout(function () {

                $('#pfCpf').fadeIn(500);
                $('#pfAddr,#pfName,#pfTel').hide();
                $('#txtCpf').focus();

            }, 500);

            //Após Clique em CPF
            $('#btnCpf, #btnAddr, #btnName, #btnTel').on('click', function (e) {

                var idClick = e.target.id;

                if (idClick == "btnCpf") {

                    cpfClickPhaseTwo();

                }

                else if (idClick == "btnAddr") {

                    addressClickPhaseTwo();

                }

                else if (idClick == "btnName") {

                    nameClickPhaseTwo();

                }

                else if (idClick == "btnTel") {

                    telClickPhaseTwo();

                }

            });
        }

        //Clicando em Endereço
        else if (idClick == "btnAddr") {

            transitionEffect();

            setTimeout(function () {

                $('#pfAddr').fadeIn(500);
                $('#pfCpf,#pfName,#pfTel').hide();
                $('#txtAddr').focus();

            }, 500);

            //Após clicar em Endereço
            $('#btnCpf, #btnAddr, #btnName, #btnTel').on('click', function (e) {

                var idClick = e.target.id;

                if (idClick == "btnCpf") {

                    cpfClickPhaseTwo();

                }

                else if (idClick == "btnAddr") {

                    addressClickPhaseTwo();

                }

                else if (idClick == "btnName") {

                    nameClickPhaseTwo();

                }

                else if (idClick == "btnTel") {

                    telClickPhaseTwo();

                }

            });
        }

        //Clicando em Nome
        else if (idClick == "btnName") {

            transitionEffect();

            setTimeout(function () {

                $('#pfName').fadeIn(500);
                $('#pfCpf,#pfAddr,#pfTel').hide();
                $('#txtName').focus();

            }, 500);

            //Após clique em Nome
            $('#btnCpf, #btnAddr, #btnName, #btnTel').on('click', function (e) {

                var idClick = e.target.id;

                if (idClick == "btnCpf") {

                    cpfClickPhaseTwo();

                }

                else if (idClick == "btnAddr") {

                    addressClickPhaseTwo();

                }

                else if (idClick == "btnName") {

                    nameClickPhaseTwo();

                }

                else if (idClick == "btnTel") {

                    telClickPhaseTwo();

                }

            });
        }

        //Clicando em Telefone
        else if (idClick == "btnTel") {

            transitionEffect();

            setTimeout(function () {

                $('#pfTel').fadeIn(500);
                $('#pfCpf,#pfName,#pfAddr').hide();
                $('#txtTel').focus();

            }, 500);

            //Após clique em Telefone
            $('#btnCpf, #btnAddr, #btnName, #btnTel').on('click', function (e) {

                var idClick = e.target.id;

                if (idClick == "btnCpf") {

                    cpfClickPhaseTwo();

                }

                else if (idClick == "btnAddr") {

                    addressClickPhaseTwo();

                }

                else if (idClick == "btnName") {

                    nameClickPhaseTwo();

                }

                else if (idClick == "btnTel") {

                    telClickPhaseTwo();

                }

            });
        }

    });

    //Botão Voltar
    $('#btnBack').on('click', function () {

        $('p').hide();
        $('#divPf').removeClass('effect-sadie-2');
        $('div.grid-pf').removeClass('grid-pf-after');
        $('#divPf').addClass('effect-sadie');
        $('#divPj,#divVehicle,#divFtp').delay(1000).fadeIn(500);
        $('#pfCpf,#pfAddr,#pfName,#pfTel').fadeOut(800);
        $('#btnBack').fadeOut(800);

        setTimeout(function () {

            $('p').show();

        }, 1000);


    });

});