using Dapper.FluentMap.Dommel.Mapping;

namespace Solution.Dapper.Repository.Mapper
{
    public class ClienteDTOMapper : DommelEntityMap<ClienteDTO>
    {
        public ClienteDTOMapper()
        {
            ToTable("CLIENTE");
            Map(x => x.Id).ToColumn("IDCLIENTE").IsKey();
            Map(x => x.Nome).ToColumn("NOME");
        }
    }
}
