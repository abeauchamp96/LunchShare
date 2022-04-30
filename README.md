LunchShare

Welcome to Lunch & Share. A place to learn many things!

## Remarks on array ([]) which use IList

IList is a descendant of the ICollection interface and is the base interface of all non-generic lists. IList implementations fall into three categories: read-only, fixed-size, and variable-size. A read-only IList cannot be modified. A fixed-size IList does not allow the addition or removal of elements, but it allows the modification of existing elements. A variable-size IList allows the addition, removal, and modification of elements.