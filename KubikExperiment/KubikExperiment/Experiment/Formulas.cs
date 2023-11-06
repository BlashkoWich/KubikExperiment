namespace KubikExperiment.Experiment;

public static class Formulas
{
    public static float GetStatisticalProbability(int repetitions, int all)
    {
        return (float)repetitions / all;
    }

    public static double GetInaccuracy(float statisticalProbability, int repetitions)
    {
        return Math.Sqrt(statisticalProbability * (1 - statisticalProbability) / repetitions);
    }

    public static float GetRealProbability(int from, int to)
    {
        return (float) from / to;
    }
}