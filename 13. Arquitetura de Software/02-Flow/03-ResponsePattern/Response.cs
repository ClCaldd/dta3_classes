public class Response<T>
(
    string message,
    bool success,
    T? value
)
{
    public string Message { get; } = message;
    public T? Value { get; } = value;

    [MemberNotNullWhen(true, nameof(Value))]
    public bool IsSuccess => success;


    public static Response<T> Ok(T value) 
        => new Response<T>(string.Empty, true, value);
    public static Response<T> Fail(string message) 
        => new Response<T>(message, false, default);

    public static implicit operator Response<T>(T value) 
        => Ok(value);
}