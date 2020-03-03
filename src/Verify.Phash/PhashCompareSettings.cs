class PhashCompareSettings
{
    public float Threshold { get; }
    public float Sigma { get; }
    public float Gamma { get; }
    public int Angles { get; }

    public PhashCompareSettings(float threshold, float sigma, float gamma, int angles)
    {
        Threshold = threshold;
        Sigma = sigma;
        Gamma = gamma;
        Angles = angles;
    }
}