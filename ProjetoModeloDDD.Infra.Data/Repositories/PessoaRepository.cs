using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
    }
}
