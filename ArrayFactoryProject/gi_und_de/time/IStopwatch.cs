namespace gi_und_de.time;

public interface IStopwatch
{
    void Start();
    void Stop();
    void Reset();
    TimeSpan Elapsed { get; } // Fehlerverhalten
}