let swap x y = 
    let temp = x
    (y, temp)

let x, y = swap 10 20
printf "%d %d" x y