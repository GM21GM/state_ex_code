class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new StopwatchImpl();

        // Use the stopwatch
        stopwatch.LeftButtonPressed();

        // Stopwatch state changed, e.g., to 'RunningState'

        State state = stopwatch.GetState();
        // Perform actions or state transitions based on the state obtained

        stopwatch.RightButtonPressed();

        // Stopwatch state changed, e.g., to 'PausedState'

        state = stopwatch.GetState();
        // Perform actions or state transitions based on the state obtained
    }
}