namespace DiceRoller;
public class Die
{
    /// <summary>
    /// Represents a die used in games or simulations
    /// with a configurable nubmer of sides.
    /// </summary>
    /// <param name="numSides">
    /// The number of sides for the die. Must be greater than zero
    /// </param>
    
    /// <summary>
    /// Gets the die's number of sides.
    /// </summary>
    public byte NumSides { get; init; }
    private Random random;

    public Die(byte numSides)
    {
        if(numSides < 0)
        {
            throw new ArgumentOutOfRangeException(
                    nameof(numSides),
                    $"{nameof(numSides)} must be greater than 0"
                );
        }
        NumSides = numSides;
        random = new Random();
    }

    public byte Roll()
    {
        return (byte)(((byte)random.Next()) % this.NumSides);
    }
}
