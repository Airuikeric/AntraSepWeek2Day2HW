namespace Week2Day2HW;

public class Ball
{
    public int Size { get; private set; }
    public Color BallColor { get; private set; }
    private int throwCount;

    // Constructor to initialize size and color
    public Ball(int size, Color color)
    {
        Size = size;
        BallColor = color;
        throwCount = 0;
    }

    // Method to pop the ball
    public void Pop()
    {
        Size = 0;
    }

    // Method to throw the ball (only if it hasn't been popped)
    public void Throw()
    {
        if (Size > 0)
        {
            throwCount++;
        }
    }

    // Method to get the throw count
    public int GetThrowCount()
    {
        return throwCount;
    }
}