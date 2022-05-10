//Lab 10.05.2022
//structura de date de tip Fifo(first in , first out)
//Fifo queue

using System.Runtime.Serialization;

[Serializable]
internal class QueueFullException : Exception
{
    public QueueFullException()
    {
    }

    public QueueFullException(string? message) : base(message)
    {
    }

    public QueueFullException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected QueueFullException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}