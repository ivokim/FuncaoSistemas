$(document).ready(function () {
    if (obj) {
        $('#formBeneficiario #Nome').val(obj.Nome);
        $('#formBeneficiario #CPF').val(obj.CPF);
        $('#formBeneficiario #IDCLIENTE').val(obj.IDCLIENTE);
    }
    console.log(obj.Telefone); // Log data to console

    $('#formBeneficiario').submit(function (e) {
        e.preventDefault();

        $.ajax({
            url: urlPost,
            method: "POST",
            data: {
                "NOME": $(this).find("#Nome").val(),
             
                "CPF": $(this).find("#CPF").val(),
                "IDCLIENTE": $(this).find("#IDCLIENTE").val()
            },
            error:
                function (r) {
                    if (r.status == 400)
                        ModalDialog("Ocorreu um erro", r.responseJSON);
                    else if (r.status == 500)
                        ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");
                },
            success:
                function (r) {
                    ModalDialog("Sucesso!", r)
                    $("#formBeneficiario")[0].reset();
                    window.location.href = urlRetorno;
                }
        });
    })

})
