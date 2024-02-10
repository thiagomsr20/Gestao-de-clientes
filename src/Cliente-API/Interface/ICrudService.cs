namespace Cliente_REST_API.Interface
{
    interface ICrudService<T>
    {
        void InsertElement(T entity);
        T GetElementById(int id);
        List<T> GetElementList();
        void DeleteElementById(int id);
        void UpdateElement(int id, T entity);
    }
}
