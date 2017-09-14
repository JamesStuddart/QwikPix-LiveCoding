namespace QwikPix.Business.Services
{
    public interface IQwikDelete<TEntity> where TEntity : class, new()
    {
        bool Delete(TEntity entity, bool forceDelete = false);
    }
}
