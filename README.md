# Unexpected Behavior with Mutable Variables in F# Functions

This example demonstrates a common misunderstanding in F# related to mutable variables and their behavior within functions.  F# values are immutable by default. This code attempts to modify a variable after it's been passed to a function, leading to unexpected results because the original variable outside the function is not updated.