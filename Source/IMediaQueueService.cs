namespace Source
{
    public interface IMediaQueueService
    {
        void Add(string query);
        void Add(IMediaItemQuery query);
        void Add(object query);
        string GetNextStringQuery();
        IMediaItemQuery GetNextMediaItemQuery();
        object GetNextObjectQuery();
    }
}