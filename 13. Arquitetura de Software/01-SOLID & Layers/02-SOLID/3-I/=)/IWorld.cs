public interface IWorld : IGetPlace
{
    void SpawnObject(int x, int y);
    void DestroyObject(int x, int y);
    void DestroyAll();
}