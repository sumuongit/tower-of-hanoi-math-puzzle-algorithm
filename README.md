## Table of Contents
* [General Info](#general-info)
* [Solving Procedure](#solving-procedure)
* [Technologies](#technologies)
* [Setup](#setup)
* [Contributing](#contributing)
* [License](#license)

## General Info
Solving the Tower of Hanoi mathematical puzzle by implementing a recursive algorithm

>The Tower of Hanoi is a mathematical puzzle. It consists of three towers and a number of discs (3 in this puzzle)
 of different sizes, which can slide onto any tower. The puzzle starts with the discs in a neat stack in ascending order 
 of size on one tower (first tower in this puzzle), the smallest at the top, thus making a conical shape.

>The purpose of this puzzle is to move the discs one by one from the first tower to the last tower knowing the only
 condition is that smaller disc will always be on top of the bigger disc.
 
>In case of 3 discs we can solve the puzzle in minimum ((2 to the power 3) - 1 = 7) 7 movements.

## Solving Procedure
Let us say the following procedure to solve this puzzle which will be called recursively.
```
P(noOfDiscs, nameOfFirstTower, nameOfSecondTower, nameOfThirdTower) ---------- (i)
```
From (i) let us say,
```
N = First Parameter
T1 = Second Parameter
T2 = Third Parameter
T3 = Fourth Parameter
```
Now we get,
```
P(N, T1, T2, T3) ---------- (ii)
```
From (i) for simplicity let us say again,
```
3 = noOfDiscs
A = nameOfFirstTower
B = nameOfSecondTower
C = nameOfThirdTower
```
From here we get,
```
P(3, A, B, C) ---------- (iii)
```
With reference to (ii) we get the following three steps which will be used accordingly while (iii) is recursively called.
```
Step 1: P(N-1, T1, T3, T2)
Step 2: P(1, T1, T2, T3)
Step 3: P(N-1, T2, T1, T3)
```
After implementing the steps in (iii) and so on (until the number of discs is equal to 1) we get the following moves, as shown in the below figure:
```
A -> C (Move a disc from Tower A to Tower C)
A -> B (Move a disc from Tower A to Tower B)
C -> B (Move a disc from Tower C to Tower B)
A -> C (Move a disc from Tower A to Tower C)
B -> A (Move a disc from Tower B to Tower A)
B -> C (Move a disc from Tower B to Tower C)
A -> C (Move a disc from Tower A to Tower C)
```

**Finding the Moves:**<br/>
![Tower of Hanoi](https://github.com/sumuongit/tower-of-hanoi-math-puzzle-algorithm/blob/master/TowerOfHanoi/Images/TowerOfHanoi-1.PNG
)

Now let us move the discs, as shown in the following figure, using the resultant moves and thus we get all the discs are finally moved from Tower A to Tower C one by one maintaining the smaller disc on top of the larger disc.

**Applying the Moves:**<br/>
![Tower of Hanoi](https://github.com/sumuongit/tower-of-hanoi-math-puzzle-algorithm/blob/master/TowerOfHanoi/Images/TowerOfHanoi-2.PNG
)
![Tower of Hanoi](https://github.com/sumuongit/tower-of-hanoi-math-puzzle-algorithm/blob/master/TowerOfHanoi/Images/TowerOfHanoi-3.PNG
)

## Technologies
This application is created with:
* Visual Studio 2013
* C# 
	
## Setup
To run this application, building the source locally using git:

```
$ git clone https://github.com/sumuongit/tower-of-hanoi-math-puzzle-algorithm.git
```

## Contributing
* Fork the repository
* Create a topic branch
* Implement your feature or bug fix
* Add, commit, and push your changes
* Submit a pull request

## License
[MIT License](https://github.com/sumuongit/tower-of-hanoi-math-puzzle-algorithm/blob/master/LICENSE)

