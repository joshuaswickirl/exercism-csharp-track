using System;

public class CircularBuffer<T>
{
    T[] buffer;
    readonly int bufferLength;
    int currentLoad = 0;
    int currentReadIndex = 0;
    int currentWriteIndex = 0;

    public CircularBuffer(int capacity)
    {
        buffer = new T[capacity];
        bufferLength = capacity; 
    }

    public T Read()
    {
        if (currentLoad == 0)
        {
            throw new InvalidOperationException("Cannot read an empty buffer.");
        }
        T value = buffer[currentReadIndex];
        buffer[currentReadIndex] = default(T);
        currentLoad--;
        currentReadIndex = (currentReadIndex + 1) % bufferLength;
        return value;
    }

    public void Write(T value)
    {
        if (currentLoad == bufferLength)
        {
            throw new InvalidOperationException("Cannot write to full buffer.");
        }
        buffer[currentWriteIndex] = value;
        currentLoad++;
        currentWriteIndex = (currentWriteIndex + 1) % bufferLength;
    }

    public void Overwrite(T value)
    {
        if (currentLoad == bufferLength)
        {
            buffer[currentWriteIndex] = value;
            currentWriteIndex = (currentWriteIndex + 1) % bufferLength;
            currentReadIndex = (currentReadIndex + 1) % bufferLength;
        }
        else
        {
            Write(value);
        }
    }

    public void Clear()
    {
        for(int i = 0; i < bufferLength; i++)
        {
            buffer[i] = default(T);
            currentLoad = 0;
        }
    }
}