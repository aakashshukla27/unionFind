namespace UnionFind;

public class QuickFind
{
    private int[] id;

    // Constructor
    public QuickFind(int n) => id = Enumerable.Range(0, n).ToArray(); // n array accesses

    // Operation to check if two components are connected
    public bool Connected(int p, int q) => id[p] == id[q];  // 2 array accesses

    // Change first entry to match the second one
    public void Union(int p, int q)
    {
        int p_id = id[p];
        int q_id = id[q];
        // Change every entry with id equivalent of p to point to id of q
        for (int i = 0; i < id.Length; i++)
        {
            if (id[i] == p_id) id[i] = q_id; // 2n+2 array accesses
        }
    }
}