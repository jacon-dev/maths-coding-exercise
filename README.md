# Maths Coding Challenge
This challenge is designed to test both your basic programming skills as well as some maths fundamentals in a fun environment.

In this challenge you are given four functions that you need to implement code for. Addition, Subtraction, Multiplication and Division.

The catch? You're prohbited from using multiplication and division operators within the code. You need to think outside the box about how you would solve those two functions in particular.

There are some tests provided for you for each function to help you along, but you are encouraged to write additional tests where needed.

# Extra Steps
Once you have completed the initial challenge, here are some additional things for you to look to implement:

## Step 1
Some users of reported that when doing division they kept seeing zero being returned. Our business analysts have looked at this and it turns out users are sending in numbers in the wrong order.

We want to ensure that within the division function, we are always dividing the largest number by the smallest number. This should stop us seeing zeroes when users transpose the numbers.

## Step 2
Having delivered the feature to order the numbers, it turns out that our users now want the functionality to divide small numbers by large numbers. 

There is a catch though! They dont want to see decimals returned, instead they want hole numbers only and a remainder from the division where it applies.
