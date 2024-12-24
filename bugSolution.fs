let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

// Instead of trying to modify x after the function call, update x directly
let updatedX = add x y
printf "%d" updatedX
x <- 30 
printf "%d %d" x (add x y)

//Alternatively, if you want to return an updated value from a function
let addAndReturnUpdatedX x y =
    let updatedX = x + y
    updatedX, x //Returning the updated sum and the original x value

let updatedX, originalX = addAndReturnUpdatedX x y
printfn "%A" updatedX //Print updatedX
printfn "%A" originalX //Print originalX