namespace KubikExperiment.Experiment;

public static class ExperimentMain
{
    public static void Play()
    {
        var random = new Random();

        var repetitionsTarget = 0;
        for (var i = 0; i < ExperimentConfig.Repetitions; i++)
        {
            var next = random.Next(ExperimentConfig.MinKubikValue, ExperimentConfig.MaxKubikValue + 1);

            if (next == ExperimentConfig.TargetValue) 
                repetitionsTarget += 1;
        }
        
        var statisticalProbability = Formulas.GetStatisticalProbability(repetitionsTarget, ExperimentConfig.Repetitions);
        var inaccuracy = Formulas.GetInaccuracy(statisticalProbability, ExperimentConfig.Repetitions);
        var realProbability = Formulas.GetRealProbability(ExperimentConfig.MinKubikValue, ExperimentConfig.MaxKubikValue);

        Console.WriteLine($"Статистическая вероятность: {statisticalProbability}");
        Console.WriteLine($"Погрешность: {inaccuracy}");
        Console.WriteLine($"Реальная вероятность: {realProbability}");
    }
}