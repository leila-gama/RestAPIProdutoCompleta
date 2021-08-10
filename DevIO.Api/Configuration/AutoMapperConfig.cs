using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Configuration
{
    //herda de profile que é uma classe automapper de perfil
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Mapeia de Fornecedor para FornecedorViewModel
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            //Mapeia de Endereco para EnderecoViewModel
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            //Mapeia de Produto para ProdutoViewModel
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }

    }
}
