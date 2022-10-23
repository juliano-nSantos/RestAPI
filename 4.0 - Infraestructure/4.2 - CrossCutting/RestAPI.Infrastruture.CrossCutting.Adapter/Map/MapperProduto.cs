using RestAPI.Application.DTO.DTO;
using RestAPI.Domain.Models;
using RestAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperProduto : IMapperProduto
    {
        List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();


        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            var produto = new Produto
            {
                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor
            };

            return produto;
        }

        public IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                produtoDTOs.Add(new ProdutoDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Valor = item.Valor
                });
            }

            return produtoDTOs;
        }

        public ProdutoDTO MapperToDTO(Produto produto)
        {
            var produtoDTO = new ProdutoDTO
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };

            return produtoDTO;
        }        
    }
}
