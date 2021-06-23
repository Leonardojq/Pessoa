

function CriarDataTableListaPessoa()
{
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
            },
            {
                className: "dt-center", title: "", render: function (data, type, row) {
                    return '<button id="btnAlterar" type="button" class="btnAlterar btn btn-primary">Alterar</button>';
                }
            },
            {
                className: "dt-center", title: "", render: function (data, type, row) {
                    return '<button id="btnExcluir" type="button" class="btnExcluir btn btn-danger">Excluir</button>';
                }
            }
        ]        
    });

    return dtListaPessoa;
}


//função de chamada ao serviço de listar pessoa
function servico_TB_LISTA_PESSOA()
{
    var sRetorno = "";
    var sAmbiente = "https://localhost:44309/";

    $.ajax({
        type: 'GET'
        , url: sAmbiente + 'api/pessoa/ListarPessoas'
        , contentType: 'application/json; charset=utf-8'
        , dataType: 'json'        
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


//Função de chamada ao serviço de excluir pessoa
function servico_PESSOA_Excluir(pCpfPessoa) {
    var sRetorno = "";
    var sAmbiente = "https://localhost:44309/";
    var sParametro = '{cpfPessoa:"' + pCpfPessoa + '" }';
    
    $.ajax({
        type: 'DELETE'
        , url: sAmbiente + 'api/pessoa/ExcluirPessoa'
        , contentType: 'application/json; charset=utf-8'
        , dataType: 'json'
        , data: sParametro
        , async: false
        , success: function (oDados, status) {
            
        }
        , error: function (xmlHttpRequest, status, err) {
            alert(Error)
            return Error;
        }
    });

    return sRetorno;
}

