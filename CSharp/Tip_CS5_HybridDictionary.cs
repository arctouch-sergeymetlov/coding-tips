// Tip CS5:
// Use System.Collections.Specialized.HybridDictionary if your dictionary needs to
// work with either large or relatively small amount of data at the same time.

/*
HybridDictionary Class
Namespace:
System.Collections.Specialized
Assembly:
System.Collections.Specialized.dll
Implements IDictionary by using a ListDictionary while the collection is small, and then switching to a Hashtable when the collection gets large.

This class is recommended for cases where the number of elements in a dictionary is unknown.
It takes advantage of the improved performance of a ListDictionary with small collections,
and offers the flexibility of switching to a Hashtable which handles larger collections better than ListDictionary.

https://docs.microsoft.com/en-us/dotnet/api/system.collections.specialized.hybriddictionary?view=netcore-3.1
*/
