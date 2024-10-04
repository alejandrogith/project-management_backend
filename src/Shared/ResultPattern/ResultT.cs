namespace proyect_Management.src.Shared.ResultPattern;

public class Result<T> : Result
{
    public T? Data { get; }

    public Result(bool isSuccess, Error error, T? data)
        : base(isSuccess, error)
    {
        Data = data;
    }
}
