$(document).ready(function () {
    // Seleciona o input de CEP
    var cepInput = $('#cep');

    // Evento disparado quando o campo de CEP perde o foco
    cepInput.blur(function () {
        // Obtém o valor do CEP digitado
        var cepValue = $(this).val().replace(/\D/g, '');

        if (cepValue !== '') {
            // Faz uma requisição AJAX para a API do ViaCEP
            $.getJSON(`https://viacep.com.br/ws/${cepValue}/json/`, function (data) {
                if (!data.erro) {
                    // Preenche o campo de endereço com os dados obtidos
                    $('#endereco').val(`${data.logradouro}, ${data.bairro}, ${data.localidade}, ${data.uf}`);
                }
            });
        }
    });
});