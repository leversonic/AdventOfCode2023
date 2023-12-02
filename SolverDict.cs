namespace ADL.AdventOfCode2023;

static class SolverDict {
    public static Dictionary<int, ISolver> Solvers = new()
    {
        { 1, new CalibrationSolver() }
    };
}