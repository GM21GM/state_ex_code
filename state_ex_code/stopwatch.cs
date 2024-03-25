interface Stopwatch
{
    void LeftButtonPressed();
    void RightButtonPressed();
    State GetState();
    void SetState(State state);
}
interface State
{
    void LeftButtonPressed(Stopwatch stopwatch);
    void RightButtonPressed(Stopwatch stopwatch);
}
class RunningState : State
{
    public void LeftButtonPressed(Stopwatch stopwatch) { }
    public void RightButtonPressed(Stopwatch stopwatch) { }
}
class ReadyState : State
{
    public void LeftButtonPressed(Stopwatch stopwatch) { }
    public void RightButtonPressed(Stopwatch stopwatch) { }
}
class PausedState : State
{
    public void LeftButtonPressed(Stopwatch stopwatch) { }
    public void RightButtonPressed(Stopwatch stopwatch) { }
}
class StoppedState : State
{
    public void LeftButtonPressed(Stopwatch stopwatch) { }
    public void RightButtonPressed(Stopwatch stopwatch) { }
}
class StopwatchImpl : Stopwatch
{
    private State _state;
    public StopwatchImpl()
    {
        _state = new ReadyState();
    }
    public void LeftButtonPressed()
    {
        _state.LeftButtonPressed(this);
    }
    public void RightButtonPressed()
    {
        _state.RightButtonPressed(this);
    }
    public State GetState()
    {
        return _state;
    }
    public void SetState(State state)
    {
        _state = state;
    }
}