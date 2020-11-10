// Tip CS4:
// Optimize Contains() checks using ISet.

// Consider the following example:

private List<T> _allItems;

public IEnumerable<T> GetItemsByIds(List<int> ids)
{
    return _allItems.Where(x => ids.Contains(x.Id));
}

// The code above contains a nested loop iterating by two collections (_allItems x ids),
// effectively making the complexity of the algorythm as O(N*M) ~ O(N^2).

// You can simplyfy the complexity close to linear (almost equal to the single loop run vs nested)
// by using HashSet:

public IEnumerable<T> GetItemsByIds(List<int> ids)
{
    ISet<int> idsSet = new HashSet<int>(ids);
    return _allItems.Where(x => idsSet.Contains(x.Id));
}

// TLDR: this optimization might not be impactful if your collections are
// relatively small. Some analysis can be found here https://stackoverflow.com/questions/150750/hashset-vs-list-performance
// However keep this scenario in mind if you suspect your code may one day receive larger collections.
