

//Função de chamada ao serviço de alterar pessoa
function servico_Alterar_PESSOA(pCpfPessoa, pNomePessoa, pSobrenomePessoa, pNacionalidadePessoa, pCepPessoa, pEstadoPessoa, pCidadePessoa, pLogradouroPessoa, pEmailPessoa, pTelefonePessoa) {
    var sRetorno = "";
    var sAmbiente = "https://localhost:44309/";
    var sParametro = '{nr_cpf:"' + pCpfPessoa + '",ds_nome:"' + pNomePessoa + '",ds_sobrenome:"' + pSobrenomePessoa + '",ds_nacionalidade:"' + pNacionalidadePessoa + '",nr_cep:"' + pCepPessoa + '",ds_estado:"' + pEstadoPessoa + '",ds_cidade:"' + pCidadePessoa + '",ds_logradouro:"' + pLogradouroPessoa + '",ds_email:"' + pEmailPessoa + '",nr_telefone:"' + pTelefonePessoa + '" }';

    $.ajax({
        type: 'PUT'
        , url: sAmbiente + 'api/pessoa/AlterarPessoa'
        , contentType: 'application/json; charset=utf-8'
        , dataType: 'json'
        , data: sParametro
        , async: false
        , success: function (oDados, status) {
            sRetorno = JSON.parse(JSON.stringify(oDados));
        }
        , error: function (xmlHttpRequest, status, err) {
            alert(Error)
            return Error;
        }
    });

    return sRetorno;
}

