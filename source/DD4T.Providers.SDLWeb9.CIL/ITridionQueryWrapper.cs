using DD4T.ContentModel.Querying;
using Tridion.ContentDelivery.DynamicContent.Query;

namespace DD4T.Providers.SDLWeb9.CIL
{
    public interface ITridionQueryWrapper : IQuery
    {
        Query ToTridionQuery();
    }
}
