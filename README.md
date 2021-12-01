# Advent of Code 2021
My C# solutions to the puzzles

## Day 1
Parsed input to a list of int's called "input"

### Part 1

```
var counter = 0;

for (int i = 0; i < input.Count - 1; i++)
{

    if (input[i] < input[i + 1])
    {
        counter += 1;
    }
}

return counter;
```

### Part 2
```
var counter = 0;

for (int i = 0; i < input.Count - 3; i++)
{
    if (input[i] + input[i + 1] + input[i + 2] < input[i + 1] + input[i + 2] + input[i + 3])
    {
        counter += 1;
    }
}

return counter;
```
