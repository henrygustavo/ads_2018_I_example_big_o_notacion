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
	
	then:
	
	2^x = n
	log(2^x) = log(n)
	xlog(2) = log(n)
	x = log(n)/log(2)
	x = log2(n)
	
	In conclusion, the maximum number of iterations "x" you need to search in an array of "n" elements is log2(n).
	
	
  
3. Code the "fibonacci serie" algorithm. 

   -Why is a big O exponential notation?
   
4. Improve the "fibonacci serie" algorithm from O(2^N) to O(N).
