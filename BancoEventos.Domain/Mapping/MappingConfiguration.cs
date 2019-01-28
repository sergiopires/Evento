using AutoMapper;
using BancoEventos.Domain.Dto;

namespace BancoEventos.Domain.Mapping
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<Pergunta, PerguntaDto>().ReverseMap();
        }
    }
}
