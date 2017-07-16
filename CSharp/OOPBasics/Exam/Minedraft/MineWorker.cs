public abstract class MineWorker
{
    protected MineWorker(string id)
    {
        this.Id = id;
    }

    public string Id { get; protected set; }
}
