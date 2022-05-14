namespace UnionFind;

public class QuickFind
{
    private int[] id;
    
    // Constructor
    public QuickFind(int n)
    {
        id = new int[n];
        for (int i = 0; i < n; i++)
        {
            id[i] = i;
        }
    }

    // Find operation to check if two components are connected
    private bool Find(int p, int q)
    {
        return id[p] == id[q];
    }

    private void Union(int p, int q)
    {
        int p_id = id[p];
        int q_id = id[q];
        for (int i = 0; i < id.Length; i++)
        {
            if (p_id == id[i]) id[i] = q_id;
        }
    }
}