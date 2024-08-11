var sln = new Solution();
var image = new int[][]
{
    new int[] {1, 1, 1},
    new int[] {1, 1, 0},
    new int[] {1, 0, 1}
};

var result = sln.FloodFill(image, 1, 1, 2);
foreach (var row in result)
{
  Console.WriteLine(string.Join(", ", row));
}

public class Solution
{
  public int[][] FloodFill(int[][] image, int sr, int sc, int color)
  {
    DFS(image, sr, sc, image[sr][sc], color);
    return image;
  }

  private void DFS(int[][] image, int sr, int sc, int oldColor, int newColor)
  {
    // Check if the current pixel is out of bounds or if the current pixel is already the new color or if the current pixel is not the old color
    if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[0].Length || image[sr][sc] == newColor || image[sr][sc] != oldColor)
    {
      return;
    }

    image[sr][sc] = newColor;

    DFS(image, sr + 1, sc, oldColor, newColor);
    DFS(image, sr - 1, sc, oldColor, newColor);
    DFS(image, sr, sc + 1, oldColor, newColor);
    DFS(image, sr, sc - 1, oldColor, newColor);
  }
}