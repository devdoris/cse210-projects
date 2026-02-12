using System;

/*
CREATIVITY FEATURES ADDED:

1. Leveling System:
   - Player levels up every 1000 points.

2. Eternal Goal Streak Bonus:
   - Every 5 completions gives +100 bonus points.

3. Negative Goals:
   - Lose points for bad habits.

*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
