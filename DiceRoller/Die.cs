namespace DiceRoller;
public class Die
{
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

    private const byte MAX_SIDES = 20;
    private const byte MIN_SIDES = 2;


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
        if(numSides < MIN_SIDES || numSides > MAX_SIDES)
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

    public byte Roll()
    {
        RolledValue = (byte)(random.Next(1, NumSides + 1));
        return RolledValue;
    }
}
