using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Solution.Dapper.Repository.Mapper;

namespace Solution.Dapper.Repository
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new ClienteDTOMapper());
                
                config.ForDommel();
            });
        }
    }
}
