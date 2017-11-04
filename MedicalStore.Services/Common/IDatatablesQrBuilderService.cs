using System.Linq;
using System.Web;

namespace MedicalStore.Services.Common
{
    public interface IDatatablesQrBuilderService
    {
        /// <summary>
        /// Buils the query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <param name="queryable">The queryable.</param>
        /// <returns></returns>
        DatatablesQueryResult<T> BuildQuery<T>(HttpRequestBase request, IQueryable<T> queryable);
    }
}