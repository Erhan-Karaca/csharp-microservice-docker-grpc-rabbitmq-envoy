using System.Threading.Tasks;
using Web.HttpAggregator.Models;

namespace Web.HttpAggregator.Services
{
    public interface ICatalogService
    {
        Task<CatalogData> GetById(string id);
    }
}
