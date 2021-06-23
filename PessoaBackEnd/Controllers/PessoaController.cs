using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using Newtonsoft.Json.Linq;

namespace PessoaBackEnd.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PessoaController : ApiController
    {

        //Listar Pessoas
        [HttpGet]
        public IHttpActionResult GetListarPessoas()
        {
            List<PessoaDTO> pessoas = null;

            using (var context = new PessoaEntities())
            {
                pessoas = context.Pessoas.Select(s => new PessoaDTO
                {
                    nr_cpf = s.nr_cpf,
                    ds_nome = s.ds_nome,
                    ds_sobrenome = s.ds_sobrenome,
                    ds_nacionalidade = s.ds_nacionalidade,
                    nr_cep = s.nr_cep,
                    ds_estado = s.ds_estado,
                    ds_cidade = s.ds_cidade,
                    ds_logradouro = s.ds_logradouro,
                    ds_email = s.ds_email,
                    nr_telefone = s.nr_telefone
                }).ToList();
            }
            
            return Json(pessoas);
        }


        //Consultar Pessoas
        [HttpPost]
        public IHttpActionResult PostConsultarPessoas([FromBody] Pessoa pessoaConsulta)
        {
            IQueryable<Pessoa> pessoas = null;
            List<Pessoa> pessoasList = null;

            using (var context = new PessoaEntities())
            {
                pessoas = context.Pessoas.AsQueryable();
                
                if (pessoaConsulta.nr_cpf != 0)
                {
                    pessoas = pessoas.Where(s => s.nr_cpf == pessoaConsulta.nr_cpf);
                }
                if (pessoaConsulta.ds_nome != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.ds_nome == pessoaConsulta.ds_nome);
                }
                if (pessoaConsulta.ds_sobrenome != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.ds_sobrenome == pessoaConsulta.ds_sobrenome);
                }
                if (pessoaConsulta.ds_nacionalidade != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.ds_nacionalidade == pessoaConsulta.ds_nacionalidade);
                }
                if (pessoaConsulta.nr_cep != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.nr_cep == pessoaConsulta.nr_cep);
                }
                if (pessoaConsulta.ds_estado != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.ds_estado == pessoaConsulta.ds_estado);
                }
                if (pessoaConsulta.ds_cidade != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.ds_cidade == pessoaConsulta.ds_cidade);
                }
                if (pessoaConsulta.ds_logradouro != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.ds_logradouro == pessoaConsulta.ds_logradouro);
                }
                if (pessoaConsulta.ds_email != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.ds_email == pessoaConsulta.ds_email);
                }
                if (pessoaConsulta.nr_telefone != string.Empty)
                {
                    pessoas = pessoas.Where(s => s.nr_telefone == pessoaConsulta.nr_telefone);
                }

                pessoasList = pessoas.ToList();
            }

            return Json(pessoasList);
        }


        //Incluir Pessoa
        [HttpPost]
        public JsonResult<ResultadoJson> PostIncluirPessoa(Pessoa pessoa)
        {            
            using (var context = new PessoaEntities())
            {
                if (context.Pessoas.Any(o => o.nr_cpf == pessoa.nr_cpf))
                {                        
                    var result = new ResultadoJson { Resultado = "Fracasso" };
                    return Json(result);
                }
                else
                {
                    context.Pessoas.Add(new Pessoa()
                    {
                        nr_cpf = pessoa.nr_cpf,
                        ds_nome = pessoa.ds_nome,
                        ds_sobrenome = pessoa.ds_sobrenome,
                        ds_nacionalidade = pessoa.ds_nacionalidade,
                        nr_cep = pessoa.nr_cep,
                        ds_estado = pessoa.ds_estado,
                        ds_cidade = pessoa.ds_cidade,
                        ds_logradouro = pessoa.ds_logradouro,
                        ds_email = pessoa.ds_email,
                        nr_telefone = pessoa.nr_telefone
                    });

                    context.SaveChanges();

                    var result = new ResultadoJson { Resultado = "Sucesso" };
                    return Json(result);
                }                
            }                                                      
        }


        //Alterar Pessoa
        [HttpPut]
        public JsonResult<ResultadoJson> PutAlterarPessoa(Pessoa pessoa)
        {            
            using (var context = new PessoaEntities())
            {
                var pessoaExistente = context.Pessoas.Where(s => s.nr_cpf == pessoa.nr_cpf).FirstOrDefault<Pessoa>();

                if (pessoaExistente != null)
                {
                    //Pessoa encontrada
                    pessoaExistente.ds_nome = pessoa.ds_nome;
                    pessoaExistente.ds_sobrenome = pessoa.ds_sobrenome;
                    pessoaExistente.ds_nacionalidade = pessoa.ds_nacionalidade;
                    pessoaExistente.nr_cep = pessoa.nr_cep;
                    pessoaExistente.ds_estado = pessoa.ds_estado;
                    pessoaExistente.ds_cidade = pessoa.ds_cidade;
                    pessoaExistente.ds_logradouro = pessoa.ds_logradouro;
                    pessoaExistente.ds_email = pessoa.ds_email;
                    pessoaExistente.nr_telefone = pessoa.nr_telefone;

                    context.SaveChanges();

                    var result = new ResultadoJson { Resultado = "Sucesso" };
                    return Json(result);
                }
                else
                {
                    //Pessoa não encontrada
                    var result = new ResultadoJson { Resultado = "Fracasso" };
                    return Json(result);
                }
            }            
        }


        //Excluir Pessoa
        [HttpDelete]
        public void DeletePessoa(PessoaExclusao pessoaExclusao)
        {            
            using (var context = new PessoaEntities())
            {
                long intCpfPessoa = Convert.ToInt64(pessoaExclusao.cpfPessoa);

                var pessoa = context.Pessoas
                    .Where(s => s.nr_cpf == intCpfPessoa)
                    .FirstOrDefault();

                context.Entry(pessoa).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }            
        }
    }
}
