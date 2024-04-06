// https://leetcode.com/problems/spiral-matrix/

using System.Collections.Generic;

int[][] input = [[1,2,3], [4,5,6], [7,8,9]];
var answer = SpiralOrder(input);


static IList<int> SpiralOrder(int[][] matrix) {
    var result = new List<int>();
    int element_count = matrix.Length * matrix[0].Length;
    int lower = 0;
    int upper = matrix[0].Length - 1;

    // use switch statement within loop --> can check after each movement whether to stop or not
    while (result.Count < element_count) {
        // left --> right
        result.AddRange((IEnumerable<int>)matrix.Skip(lower).Take(upper));
        lower++;

        // top --> bottom
        for (int j = lower; j <= upper; j++) {
            result.Add(matrix[j][upper]);
        }

        // right --> left

        // bottom --> top
    }
}