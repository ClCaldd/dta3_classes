public interface IGlobalState
{
    void SetFlag(string key, bool value);
    bool GetFlag(string key);
    void ApplyAll(Action<BaseOBject> apply);
}