using MongoDB.Driver;
using signal.Entities;

namespace signal.Repositories;

public class WoocommerceRepository : IWoocommerceRepository
{
    private const string collectionName = "weebhooks";
    private readonly IMongoCollection<Webhook> dbCollecion;
    private readonly FilterDefinitionBuilder<Webhook> filterDefinitionBuilder = Builders<Webhook>.Filter;

    public WoocommerceRepository(IMongoDatabase database)
    {
        dbCollecion = database.GetCollection<Webhook>(collectionName);
    }
    public async Task CreateAsync(Webhook weebhook)
    {
        if (weebhook == null)
            throw new ArgumentException(nameof(Webhook));
        await dbCollecion.InsertOneAsync(weebhook);
    }
}