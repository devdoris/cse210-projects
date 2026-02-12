public class EternalGoal : Goal
{
    private int _streak;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _streak = 0;
    }

    public EternalGoal(string name, string description, int points, int streak)
        : base(name, description, points)
    {
        _streak = streak;
    }

    public override int RecordEvent()
    {
        _streak++;
        int bonus = 0;

        if (_streak % 5 == 0)
        {
            bonus = 100; // streak bonus
            Console.WriteLine("🔥 5-Day Streak Bonus! +100 points!");
        }

        return _points + bonus;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_shortName} ({_description}) - Streak: {_streak}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points},{_streak}";
    }
}
