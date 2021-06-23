

function CriarDataTableListaPessoa() {
    var dtListaPessoa = $("#id_LISTA_PESSOA").DataTable({
        retrieve: true,
        data: null,
        paging: true,
        searching: false,
        pageLength: 30,
        autoWidth: true,
        columns: [
            {
                className: "dt-center", title: "CPF", data: "nr_cpf"
            },
            {
                className: "dt-center", title: "Nome", data: "ds_nome"
            },
            {
                className: "dt-center", title: "Sobrenome", data: "ds_sobrenome"
            },
            {
                className: "dt-center", title: "Nacionalidade", data: "ds_nacionalidade"
            },
            {
                className: "dt-center", title: "CEP", data: "nr_cep"
            },
            {
                className: "dt-center", title: "Estado", data: "ds_estado"
            },
            {
                className: "dt-center", title: "Cidade", data: "ds_cidade"
            },
            {
                className: "dt-center", title: "Logradouro", data: "ds_logradouro"
            },
            {
                className: "dt-center", title: "E-mail", data: "ds_email"
            },
            {
                className: "dt-center", title: "Telefone", data: "nr_telefone"
            }           
        ]
    });

    return dtListaPessoa;
}


//Função de chamada ao serviço de consultar pessoa
function servico_Consultar_PESSOA(pCpfPessoa, pNomePessoa, pSobrenomePessoa, pNacionalidadePessoa, pCepPessoa, pEstadoPessoa, pCidadePessoa, pLogradouroPessoa, pEmailPessoa, pTelefonePessoa) {
    var sRetorno = "";
    var sAmbiente = "https://localhost:44309/";
    var sParametro = '{nr_cpf:"' + pCpfPessoa + '",ds_nome:"' + pNomePessoa + '",ds_sobrenome:"' + pSobrenomePessoa + '",ds_nacionalidade:"' + pNacionalidadePessoa + '",nr_cep:"' + pCepPessoa + '",ds_estado:"' + pEstadoPessoa + '",ds_cidade:"' + pCidadePessoa + '",ds_logradouro:"' + pLogradouroPessoa + '",ds_email:"' + pEmailPessoa + '",nr_telefone:"' + pTelefonePessoa + '" }';

    $.ajax({
        type: 'POST'
        , url: sAmbiente + 'api/pessoa/ConsultarPessoas'
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

