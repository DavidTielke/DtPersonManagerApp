using System.Runtime.Serialization;

namespace DataStoring.Contract.Exceptions;

[Serializable]
public class DataStoringInsertException : Exception
{
    public DataStoringInsertException()
    {
    }

    public DataStoringInsertException(string message) : base(message)
    {
    }

    public DataStoringInsertException(string message, Exception inner) : base(message, inner)
    {
    }

    protected DataStoringInsertException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {
    }
}