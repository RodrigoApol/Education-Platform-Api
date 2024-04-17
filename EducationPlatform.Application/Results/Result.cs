using EducationPlatform.Application.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Results;
public class Result
{
    public Result(bool isSucess, Error error)
    {
        if (isSucess && error != Error.None
            || !isSucess && error == Error.None)
        {
            throw new ArgumentException("Invalid Error", nameof(error));
        }

        IsSucess = isSucess;
        Error = error;
    }
    public bool IsSucess { get; }
    public bool IsFailure => !IsSucess;
    public Error Error { get; }
    public static Result Success() => new(true, Error.None);
    public static Result<T> Success<T>(T value) => new(value, true, Error.None);
    public static Result Fail(Error error) => new(false, error);
    public static Result<T> Fail<T>(Error error) => new(default, false, error);
}

public class Result<T> : Result
{
    private readonly T _value;
    public T Value
    {
        get
        {
            if (!IsSucess)
            {
                throw new InvalidOperationException();
            }

            return _value;
        }

    }
    public Result(T value, bool isSucess, Error error) : base(isSucess, error)
    {
        _value = value;
    }
}
