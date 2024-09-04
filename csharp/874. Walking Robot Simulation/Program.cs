using System.Linq;

var sln = new Solution();
int[] commands = [1, 2, -2, 5, -1, -2, -1, 8, 3, -1, 9, 4, -2, 3, 2, 4, 3, 9, 2, -1, -1, -2, 1, 3, -2, 4, 1, 4, -1, 1, 9, -1, -2, 5, -1, 5, 5, -2, 6, 6, 7, 7, 2, 8, 9, -1, 7, 4, 6, 9, 9, 9, -1, 5, 1, 3, 3, -1, 5, 9, 7, 4, 8, -1, -2, 1, 3, 2, 9, 3, -1, -2, 8, 8, 7, 5, -2, 6, 8, 4, 6, 2, 7, 2, -1, 7, -2, 3, 3, 2, -2, 6, 9, 8, 1, -2, -1, 1, 4, 7];
int[][] obstacles = [[-57, -58], [-72, 91], [-55, 35], [-20, 29], [51, 70], [-61, 88], [-62, 99], [52, 17], [-75, -32], [91, -22], [54, 33], [-45, -59], [47, -48], [53, -98], [-91, 83], [81, 12], [-34, -90], [-79, -82], [-15, -86], [-24, 66], [-35, 35], [3, 31], [87, 93], [2, -19], [87, -93], [24, -10], [84, -53], [86, 87], [-88, -18], [-51, 89], [96, 66], [-77, -94], [-39, -1], [89, 51], [-23, -72], [27, 24], [53, -80], [52, -33], [32, 4], [78, -55], [-25, 18], [-23, 47], [79, -5], [-23, -22], [14, -25], [-11, 69], [63, 36], [35, -99], [-24, 82], [-29, -98], [-50, -70], [72, 95], [80, 80], [-68, -40], [65, 70], [-92, 78], [-45, -63], [1, 34], [81, 50], [14, 91], [-77, -54], [13, -88], [24, 37], [-12, 59], [-48, -62], [57, -22], [-8, 85], [48, 71], [12, 1], [-20, 36], [-32, -14], [39, 46], [-41, 75], [13, -23], [98, 10], [-88, 64], [50, 37], [-95, -32], [46, -91], [10, 79], [-11, 43], [-94, 98], [79, 42], [51, 71], [4, -30], [2, 74], [4, 10], [61, 98], [57, 98], [46, 43], [-16, 72], [53, -69], [54, -96], [22, 0], [-7, 92], [-69, 80], [68, -73], [-24, -92], [-21, 82], [32, -1], [-6, 16], [15, -29], [70, -66], [-85, 80], [50, -3], [6, 13], [-30, -98], [-30, 59], [-67, 40], [17, 72], [79, 82], [89, -100], [2, 79], [-95, -46], [17, 68], [-46, 81], [-5, -57], [7, 58], [-42, 68], [19, -95], [-17, -76], [81, -86], [79, 78], [-82, -67], [6, 0], [35, -16], [98, 83], [-81, 100], [-11, 46], [-21, -38], [-30, -41], [86, 18], [-68, 6], [80, 75], [-96, -44], [-19, 66], [21, 84], [-56, -64], [39, -15], [0, 45], [-81, -54], [-66, -93], [-4, 2], [-42, -67], [-15, -33], [1, -32], [-74, -24], [7, 18], [-62, 84], [19, 61], [39, 79], [60, -98], [-76, 45], [58, -98], [33, 26], [-74, -95], [22, 30], [-68, -62], [-59, 4], [-62, 35], [-78, 80], [-82, 54], [-42, 81], [56, -15], [32, -19], [34, 93], [57, -100], [-1, -87], [68, -26], [18, 86], [-55, -19], [-68, -99], [-9, 47], [24, 94], [92, 97], [5, 67], [97, -71], [63, -57], [-52, -14], [-86, -78], [-17, 92], [-61, -83], [-84, -10], [20, 13], [-68, -47], [7, 28], [66, 89], [-41, -17], [-14, -46], [-72, -91], [4, 52], [-17, -59], [-85, -46], [-94, -23], [-48, -3], [-64, -37], [2, 26], [76, 88], [-8, -46], [-19, -68]];
Console.WriteLine(sln.RobotSim(commands, obstacles));


public class Solution
{
    private static readonly int HASH_MULTIPLIER = 60001; // Slightly larger than 2 * max coordinate value
    public int RobotSim(int[] commands, int[][] obstacles)
    {
        // Store obstacles in an HashSet for efficient lookup
        HashSet<int> obstacleSet = new HashSet<int>();
        foreach (int[] obstacle in obstacles)
        {
            obstacleSet.Add(HashCoordinates(obstacle[0], obstacle[1]));
        }

        int[][] directions = [
            [0, 1],
            [1, 0],
            [0, -1],
            [-1, 0],
        ];

        int maxDistance = 0;
        int[] position = [0, 0];
        int currentDirection = 0; // 0: Up, 1: Right, 2: Down, 3: Left;

        foreach (int command in commands)
        {
            // turn right
            if (command == -1)
            {
                currentDirection = (currentDirection + 1) %4;
            }
            // turn left
            if (command == -2)
            {
                currentDirection = (currentDirection + 3) % 4;
            }

            int[] direction = directions[currentDirection];

            for (int step = 0; step < command; step++)
            {
                int nextX = position[0] + direction[0];
                int nextY = position[1] + direction[1];
                if (obstacleSet.Contains(HashCoordinates(nextX, nextY))) {
                    break;
                }
                position[0] = nextX;
                position[1] = nextY;
            }

            maxDistance = Math.Max(maxDistance, position[0] * position[0] + position[1] * position[1]);
        }

        return maxDistance;
    }

    private int HashCoordinates(int x, int y)
    {
        return x * HASH_MULTIPLIER + y;
    }
}

//public class Solution
//{
//    public enum Direction
//    {
//        Up,
//        Right,
//        Down,
//        Left
//    }
//    public int RobotSim(int[] commands, int[][] obstacles)
//    {
//        int maxDistance = 0;
//        int[] position = [0, 0];
//        int[] prevPosition = [0, 0];
//        Dictionary<Direction, int[]> DirectMap = new()
//        {
//            { Direction.Up, [0, 1] },
//            { Direction.Right, [1, 0] },
//            { Direction.Down, [0, -1] },
//            { Direction.Left, [-1, 0] },
//        };
//        Direction CurrentDirection = Direction.Up;

//        foreach (int command in commands)
//        {
//            // turn 
//            if (command < 0)
//            {
//                switch (CurrentDirection)
//                {
//                    case Direction.Up:
//                        CurrentDirection = command == -1 ? Direction.Right : Direction.Left;
//                        break;
//                    case Direction.Right:
//                        CurrentDirection = command == -1 ? Direction.Down : Direction.Up;
//                        break;
//                    case Direction.Down:
//                        CurrentDirection = command == -1 ? Direction.Left : Direction.Right;
//                        break;
//                    case Direction.Left:
//                        CurrentDirection = command == -1 ? Direction.Up : Direction.Down;
//                        break;
//                }
//            }
//            else
//            {
//                prevPosition[0] = position[0];
//                prevPosition[1] = position[1];
//                position[0] = position[0] + DirectMap[CurrentDirection][0] * command;
//                position[1] = position[1] + DirectMap[CurrentDirection][1] * command;
//                // handle obstacles (you need to know 3 condition: 1. is position in a line with obstacle? 2. is position direction? 3. is robot passed obstacles?)
//                foreach (var obstacle in obstacles)
//                {
//                    if (position[0] == obstacle[0])
//                    {
//                        if (CurrentDirection == Direction.Up && position[1] > obstacle[1] && prevPosition[1] < obstacle[1])
//                        {
//                            position[1] = obstacle[1] - 1;
//                        }
//                        else if (CurrentDirection == Direction.Down && position[1] < obstacle[1] && prevPosition[1] > obstacle[1])
//                        {
//                            position[1] = obstacle[1] + 1;
//                        }
//                    }
//                    else if (position[1] == obstacle[1])
//                    {
//                        if (CurrentDirection == Direction.Left && position[0] < obstacle[0] && prevPosition[0] > obstacle[0])
//                        {
//                            position[0] = obstacle[0] + 1;
//                        }
//                        else if (CurrentDirection == Direction.Right && position[0] > obstacle[0] && prevPosition[0] < obstacle[0])
//                        {
//                            position[0] = obstacle[0] - 1;
//                        }
//                    }
//                }

//                maxDistance = Math.Max(maxDistance, (int)Math.Pow(position[0], 2) + (int)Math.Pow(position[1], 2));
//            }
//        }

//        return maxDistance;
//    }
//}