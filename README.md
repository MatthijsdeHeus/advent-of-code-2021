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

## Day 2
Parsed input to a list of string's called "input"

### Part 1

```
var depth = 0;
var horizontal = 0;

for (int i = 0; i < input.Count; i++)
{
    var lineSplitted = input[i].Split(' ', 2);

    var command = lineSplitted[0];

    var amount = Int32.Parse(lineSplitted[1]);

    switch (command)
    {
        case "forward":
            horizontal += amount;
            break;

        case "down":
            depth += amount;
            break;

        case "up":
            depth -= amount;
            break;
    }
}

return (horizontal * depth);
```

### Part 2
```
var depth = 0;
var horizontal = 0;
var aim = 0;

for (int i = 0; i < input.Count; i++)
{
    var lineSplitted = input[i].Split(' ', 2);

    var command = lineSplitted[0];

    var amount = Int32.Parse(lineSplitted[1]);

    switch (command)
    {
        case "forward":
            horizontal += amount;
            depth += aim * amount;
            break;

        case "down":
            aim += amount;
            break;

        case "up":
            aim -= amount;
            break;
    }
}

return (horizontal * depth);
```
