namespace Day1
{
    internal class Sonar
    {
        public readonly List<int> Inputs = new();
        private readonly List<int> windowInputs = new();
        ///<summary>Depth Measurement Increases</summary>
        public int DMI { get; private set; } = 0;

        ///<summary>Windowed Depth Measurement Increases</summary>
        public int WDMI { get; private set; } = 0;

        public void NextInput(int input)
        {
            Inputs.Add(input);

            // Increment DMI if the depth measurement increases
            if (Inputs.Count > 1)
                DMI += input > Inputs[^2] ? 1 : 0;

            if (Inputs.Count > 2)
            {
                windowInputs.Add(Inputs[^1] + Inputs[^2] + Inputs[^3]);

                if (windowInputs.Count > 1)
                    WDMI += windowInputs[^1] > windowInputs[^2] ? 1 : 0;
            }
        }
    }
}
