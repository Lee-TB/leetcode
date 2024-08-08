var sln = new Solution();
var result = sln.SpiralMatrixIII(1, 4, 0, 0);
foreach (var item in result)
{
  System.Console.WriteLine(item[0] + " " + item[1]);
}
public class Solution
{
  public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
  {
    var directionMap = new Dictionary<string, int[]>{
      {"right", new int[]{0, 1}},
      {"down", new int[]{1, 0}},
      {"left", new int[]{0, -1}},
      {"up", new int[]{-1, 0}}
    };
    var changeDirectionMap = new Dictionary<string, string>{
      {"right", "down"},
      {"down", "left"},
      {"left", "up"},
      {"up", "right"}
    };

    int[] currentState = [rStart, cStart];
    var action = "right";
    int steps = 1;
    int lenOfMatrix = rows * cols;
    int countToIncreaseSteps = 2;

    List<int[]> visitedPath = new List<int[]>();
    visitedPath.Add(currentState);

    while (visitedPath.Count < lenOfMatrix)
    {
      for (int i = 1; i <= steps; i++)
      {
        currentState = [currentState[0] + directionMap[action][0], currentState[1] + directionMap[action][1]];
        if (
          currentState[0] >= 0 && currentState[0] < rows
          && currentState[1] >= 0 && currentState[1] < cols)
        {
          visitedPath.Add(currentState);
        }
      }
      action = changeDirectionMap[action];
      countToIncreaseSteps -= 1;
      if (countToIncreaseSteps % 2 == 0)
      {
        steps += 1;
        countToIncreaseSteps = 2;
      }
    }
    return visitedPath.ToArray();
  }
}
