# DSAL1-KFS
> by Kristian Flejsborg Sørensen (cph-kf96)

## Assignment
the assignment is to finish the problems from the book, specifically number 1.4.44 1.4.45 and 2.1.13

## 1.4.44 Birthday Problem
Code looks as follows   
![](https://i.gyazo.com/91c25ecb820f4e3efd23fff5950b0030.png)   
BirthdayProblem(int N) starts the program and runs the expected(int N) to state what the program is suppose to achive with N.   

BirthdayProblemInt(int N, Random rnd) makes a list, it then runs N times in a for loop to simulate running all theoretical N times, making a new random value in the process, check if the value already exist and then either stops the cycle and returns the amount of numbers in the list, or adds the new random number to the list and repeats the loop.   

after running the code 100.000 times the expected value and the actual value with the use of N defined as 10.000 comes out as this.   
![](https://i.gyazo.com/bb4ec2f21197d88ce68441c8d6a22f54.png)   

## 1.4.45 Coupon Collector Problem
Code looks as follows   
![](https://i.gyazo.com/3bcbe8f38f7e445182abe9478907b281.png)   
CouponCollectorProblem(int N) starts the program and runs the expected(int N) to state what the program is suppose to achive with N.   

CouponCollectorProblemInt(int N, Random rnd) sets initial variables to track the progress thoughout the function, it then starts a infinite loop that's designed to break when there are no remaining values to be rolled, in this loop it makes a new random value within N's range, and checks if the value doesn't exist in the list, and if so adds it and reduces the amount of remaining values. Onces all values have been found the function returns the amount of attempts that have been made.   

After running the code 1.000 times the expected value and the actual value with the use of N defined as 1.000 comes out as this.   
![](https://i.gyazo.com/90b8c61dea65aa50c07fe010e94ea968.png)   

## 2.1.13 Deck Sort
Code looks as follows   
![](https://i.gyazo.com/74f93056f22d72ecd36ee84decac65f2.png)   
A rather crude and quick solution but since the assignment is on time pressure this is what I had to settle with.   
instead of rolling with fancy values that made it clear what card was what, I used 56 individual integers in replacement, the code generates 1-56 and randomizes them and then sorts them correctly which will be explained below.   
before   
![](https://i.gyazo.com/24098a9de81a849aec45a3a1c8dcab8c.png)   
after   
![](https://i.gyazo.com/7d6b898de781bfd661ed2f952a1bd109.png)   

To explain the logic, since you can at any given time know 2 cards values, you can start at the first card, flip it, and then proceed through all other cards one by one, comparing them with the first card, if a card with lower value is found, you swap them so the new lowest card is at the first position, you then continue through the pile until the lowest correct value is found, once this is done you move to the next card in the row and repeat the pattern, for sorting the cards Spades,Hearts,Clubs,Diamonds you simply proclaim that ace of spades is a lower "value" than Ace of Clubs as a example.
