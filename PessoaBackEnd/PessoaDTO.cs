using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PessoaBackEnd
{
    public class PessoaDTO
    {
        public long nr_cpf { get; set; }
        public string ds_nome { get; set; }
        public string ds_sobrenome { get; set; }
        public string ds_nacionalidade { get; set; }
        public string nr_cep { get; set; }
        public string ds_estado { get; set; }
        public string ds_cidade { get; set; }
        public string ds_logradouro { get; set; }
        public string ds_email { get; set; }
        public string nr_telefone { get; set; }
    }
}
