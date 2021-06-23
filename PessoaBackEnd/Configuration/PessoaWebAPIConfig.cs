using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PessoaBackEnd.Configuration
{
    public static class PessoaWebAPIConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Rotas do Web API
            config.MapHttpAttributeRoutes();

            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "ConsultarPessoasApi",
                routeTemplate: "api/pessoa/ConsultarPessoas",
                defaults: new { controller = "Pessoa", action = "PostConsultarPessoas" }
            );

            config.Routes.MapHttpRoute(
                name: "IncluirPessoaApi",
                routeTemplate: "api/pessoa/IncluirPessoa",
                defaults: new { controller = "Pessoa", action = "PostIncluirPessoa" }
            );

            config.Routes.MapHttpRoute(
                name: "AlterarPessoaApi",
                routeTemplate: "api/pessoa/AlterarPessoa",
                defaults: new { controller = "Pessoa", action = "PutAlterarPessoa" }
            );

            config.Routes.MapHttpRoute(
                name: "ListarPessoasApi",
                routeTemplate: "api/pessoa/ListarPessoas",
                defaults: new { controller = "Pessoa", action = "GetListarPessoas" }
            );

            config.Routes.MapHttpRoute(
                name: "DeletarPessoaApi",
                routeTemplate: "api/pessoa/ExcluirPessoa",
                defaults: new { controller = "Pessoa", action = "DeletePessoa" }
            );

            //Removendo a formatação XML
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
