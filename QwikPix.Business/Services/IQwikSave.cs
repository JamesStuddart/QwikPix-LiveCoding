namespace QwikPix.Business.Services
{
    public interface IQwikSave<TEntity> where TEntity : class, new()
    {
        bool Insert(TEntity entity);

        bool Update(TEntity entity);
    }
}
