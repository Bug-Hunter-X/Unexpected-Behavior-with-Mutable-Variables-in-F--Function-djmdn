# Unexpected Behavior with Mutable Variables in F# Function

This example demonstrates a common issue when working with mutable variables and function scope in F#.  The `swap` function intends to swap the values of `x` and `y`, but it doesn't produce the expected result because F#'s mutability is localized to each scope.

**Files:**

* `bug.fs`: Contains the buggy code.
* `bugSolution.fs`: Shows the corrected code.

**How to reproduce:**

1. Compile and run `bug.fs`. Observe that the values of x and y are not swapped as expected. 
2. Run `bugSolution.fs` to see the corrected approach.

**Solution:**

The solution involves returning the new swapped values from the function rather than relying on changes in scope to effect mutation.