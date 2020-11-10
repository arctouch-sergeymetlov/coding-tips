// Tip CS3:
// When taking the first element of the collection you expect to be not empty
// prefer using First() over FirstOrDefault() because it produces more
// descriptive exception.

// Let's say by the contract you expect `list` to be not empty.
// If though it happens, the following code will produce
// "System.NullReferenceException: Object reference not set to an instance of an object.":
var item = list.FirstOrDefault();
item.M();

// And the following would throw "System.InvalidOperationException: Sequence contains no elements":
var item = list.First();
item.M();

// Which is more descriptive and narrows down the problem comparing to NullReferenceException
// which is way too general in this situation.
