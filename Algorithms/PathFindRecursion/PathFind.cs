using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Algorithms;

public static class PathFind
{
    public static char[][] Map =
    [
        ['S', ' ', '#', '#'],
        [' ', '#', '#', '#'],
        [' ', ' ', '#', 'E'],
        ['#', ' ', ' ', ' ']
    ];

    public static bool[][] Visited =
    [
        [..Enumerable.Repeat(false, 4)],
        [..Enumerable.Repeat(false, 4)],
        [..Enumerable.Repeat(false, 4)],
        [..Enumerable.Repeat(false, 4)],
    ];

    public static (int, int)[] Path = [];

    private static bool SolveRecurse(char[][] m, int r, int c, int nR, int nC)
    {
        // check boundaries
        if (r < 0 || c < 0 || r > nR - 1 || c > nC - 1)
            return false;


        if (m[r][c] == '#')                         // check if wall
            return false;
        
        if (m[r][c] == 'E')                         // check if end
        {
            Path = Path.Prepend((r, c)).ToArray();
            return true;
        }

        // check if visited
        if (Visited[r][c])
            return false;

        Visited[r][c] = true;

        bool found =
            SolveRecurse(m, r, c - 1, nR, nC) ||    // left 
            SolveRecurse(m, r, c + 1, nR, nC) ||    // right
            SolveRecurse(m, r - 1, c, nR, nC) ||    // up
            SolveRecurse(m, r + 1, c, nR, nC);      // down

        if (found)
            Path = Path.Prepend((r, c)).ToArray();  // add followed path if end is found

        return found;
    }

    public static void Begin()
    {
        bool found = SolveRecurse(Map, 0, 0, 4, 4);

        if (found)
        {
            foreach ((int r, int c) in Path)
            {
                Console.WriteLine($"{r}, {c}");
            }
        }
    }
}
