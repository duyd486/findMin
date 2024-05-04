internal class Program
{

    public static int Min(int []arr) {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] < min) {
                min = arr[i];
            }
        }
        return min;
    }
    private static void Main(string[] args)
    {
        int []arr = {4, 12, 7, 8, 1, 6, 9};
        Console.WriteLine("So nho nhat trong day la: " + Min(arr));
    }
}