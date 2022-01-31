using System.Runtime.Serialization;

namespace PersonManagement.Contract.Exceptions;

[Serializable]
public class PersonAddException : Exception
{

    public PersonAddException()
    {
    }

    public PersonAddException(string message) : base(message)
    {
    }

    public PersonAddException(string message, Exception inner) : base(message, inner)
    {
    }

    protected PersonAddException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {
    }
}