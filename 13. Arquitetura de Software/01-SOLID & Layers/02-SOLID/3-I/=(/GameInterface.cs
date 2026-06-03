public interface GameInterface
{
    public void Run();
    public void SpawnObject(int x, int y);
    public void DestroyObject(int x, int y);
    public void DestroyAll();
    public int GetPlace(int x, int y);
    public int? GetPlaceOrDefault(int x, int y);
    public void SetFlag(string key, bool value);
    public bool GetFlag(string key);
    public void ApplyAll(Action<BaseOBject> apply);
}