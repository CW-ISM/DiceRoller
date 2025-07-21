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
    /// <exception cref="ArgumentOutOfRangeException">Thrown when invalid number of sides is provided</exception>
    public Die(byte numSides)
    {
        if(numSides == 0 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(
                    nameof(numSides),
                    $"{nameof(numSides)} must be greater than 0 and less than 21"
                );
        }
        NumSides = numSides;
        random = new Random();
    }

    /// <summary>
    /// Gets the die's number of sides.
    /// </summary>
    public byte NumSides { get; init; }
    private Random random;

    public byte Roll()
    {
        return (byte)(random.Next() % this.NumSides);
    }
}
