using System.Diagnostics;

namespace gi_und_de.time;

public class MyStopwatch:IStopwatch
{
    private readonly Stopwatch _stopwatch = new Stopwatch();

    public virtual void Start()
    {
        _stopwatch.Start();
    }

    public virtual void Stop()
    {
     
        _stopwatch.Stop();
    }

    public virtual TimeSpan Elapsed => _stopwatch.Elapsed;
    public void Reset()
    {
        _stopwatch.Reset();
    }
}