using System.Collections.Generic;

public abstract class Factory
{
    public abstract MineWorker CreateInstance(List<string> args);
}

