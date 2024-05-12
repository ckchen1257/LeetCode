namespace LeetCode.TopInterview150._380;

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
public class RandomizedSet
{
    private readonly HashSet<int> _hashSet = [];
    public RandomizedSet()
    {

    }

    public bool Insert(int val)
    {
        return _hashSet.Add(val);
    }

    public bool Remove(int val)
    {
        return _hashSet.Remove(val);
    }

    public int GetRandom()
    {
        var index = Random.Shared.Next(0, _hashSet.Count);
        return _hashSet.Skip(index).First();
    }
}
