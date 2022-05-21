namespace UnionFind;

public class QuickFind
{
    private int[] id;
    
    // Constructor
    public QuickFind(int n)
    {
        id = Enumerable.Range(0, n).ToArray(); // n array accesses
    }

    // Operation to check if two components are connected
    private bool Connected(int p, int q)
    {
        return id[p] == id[q];  // 2 array accesses
    }

    // Change first entry to match the second one
    private void Union(int p, int q)
    {
        int p_id = id[p];
        int q_id = id[q];
        for (int i = 0; i < id.Length; i++)
        {
            if (id[i] == p_id) id[i] = q_id; // 2n+2 array accesses
        }
    }
}