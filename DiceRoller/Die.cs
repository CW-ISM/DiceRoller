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

        // Force an initial roll
        Roll();
    }

    /// <summary>
    /// Gets the die's number of sides.
    /// </summary>
    public byte NumSides { get; init; }

    /// <summary>
    /// The current rolled value of the die.
    /// </summary>
    public byte RolledValue { get; private set; }

    /// <summary>
    /// A private random number generator used to simulate die rolls.
    /// </summary>
    private readonly static Random random = new();

    public byte Roll()
    {
        RolledValue = (byte)(random.Next(1, NumSides + 1));
        return RolledValue;
    }
}
