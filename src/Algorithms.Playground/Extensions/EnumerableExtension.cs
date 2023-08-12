namespace Algorithms.Playground.Extensions;

public static class EnumerableExtension
{
    public static string PrintToString(this int[] array)
    {
        return $"[ {string.Join(", ", array)} ]";
    }
}