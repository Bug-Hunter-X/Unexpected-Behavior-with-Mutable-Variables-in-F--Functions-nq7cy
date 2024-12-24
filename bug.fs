let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let updatedX = add x y
printf "%d" updatedX

x <- 30 //Trying to change x after passing it to the function
printf "%d %d" x (add x y)