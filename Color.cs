namespace Week2Day2HW;

public class Color
{
    // Properties for red, green, blue, and alpha values
    public int Red { get; private set; }
    public int Green { get; private set; }
    public int Blue { get; private set; }
    public int Alpha { get; private set; }

    // Constructor to initialize red, green, blue, and alpha
    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    // Method to get grayscale value (average of RGB)
    public int GetGrayscale()
    {
        return (Red + Green + Blue) / 3;
    }
}