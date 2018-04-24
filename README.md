Example big "O" notations C#
-------------------------

In this respository, I'm doing these tasks:

1. Translate from JAVA to C# the big O notation examples that are in  

   https://github.com/UNMSM-UPG-FISI/big-o-notation-java-18-1/tree/master/src/main/java/pe/edu/unmsm/fisi/upg/ads/big_o_notation_java

2. Code the "binary search" algorithm.

   -Why is a big O logarithm notation? 
   
	As you know for a sorted array, if we want to have the position of one element, we have to split the array in 2 parts each iteration
	until we get final position of the value.
	
	Considering the worst case ,the total of iterations will be the maximum number of times the array can be split in half until you have one element of the array that contains the value that you are looking for.
	
	So:
	
	n/(2^x) = 1
	
	where:
	
	"x" is the number of times you can split an array of size "n" in half before it has the size 1.
	
	Finally, the goal is to have a function that receives as input the "n" and returns "x". That's why we use logarithm:
	
	2^x = n
	
	log(2^x) = log(n)
	
	xlog(2) = log(n)
	
	x = log(n)/log(2)
	
	x = log2(n)
	
	log2(n) = x
	
	In conclusion, the maximum number of iterations "x" you need to search in an array of "n" elements is log2(n).
	
	
3. Code the "fibonacci serie" algorithm. 

   -Why is a big O exponential notation?
   
   	this is a fibonacci serie 0,1,1,2,3,5,8,13,...

	As you can see, you can get the nth term by adding together the previous two terms.

	the formula will be:

	f(n) = f(n-1) + f(n-2)

	example: 8 = 3+5

	In the code:

	int t(int n)
	{
    	  if (n <= 1) return n;
          else return t(n - 1) + t(n - 2);
	}

First of all , you have to know how many recursive calls or levels you are going to have from "n" term to the fist term. Then, per each level you are going to call twice the function "t" and there is no possibility to re-use previously calculated values.

	     		 t(n-1)			+ 		t(n-2)	     	      2^1=2
	      
    	 	t(n-2)	+      t(n-3)		      t(n-3)	+	  t(n-4)      2^2=4
     
	t(n-3)+t(n-4)	    t(n-4)+t(n-5)	t(n-4)+t(n-5)	     t(n-5)+t(n-6)    2^3=8

	t(1) +t(0)	     t(1)+t(0)		 t(1)+t(0)		t(1)+t(0)     2^n

The "t" function will be called =>2+4+8+.....2^n times.Thus, the complexity  is O(2^n)
   
4. Improve the "fibonacci serie" algorithm from O(2^N) to O(N).
