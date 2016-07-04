package ASG1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Methods // product, countTwelve, minMaxAvg, gradeCalculator
{
  public static void product() throws IOException
  {
        int input, product = 1;
	
        System.out.println("- - -");
        System.out.println("This program will find the product of all values.");
        System.out.println("Please enter some numbers:");
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in)); // receive input
        String line = br.readLine(); // read input
        StringTokenizer st = new StringTokenizer(line);
        
        while(st.hasMoreTokens()) // loop to check input for number value
        {
            input = Integer.parseInt(st.nextToken()); // value of input in current loop
            product = Math.abs(product * input); // running total of all inputs
        }
        
        if (product == 0)
                System.out.println("There was a zero!"); // catch zero values
         
        else
            System.out.println("The product of these numbers is " + product); // display product
  }
  
  public static void countTwelve() throws IOException
  {
        int input, first, last, count, sum;
        input = first = last = count = sum = 0;
	
        System.out.println("- - -");
        System.out.println("This program will find the first and last positions of the number 12.");
        System.out.println("Please enter some numbers:");
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in)); // receive input
        String line = br.readLine(); // read input
        StringTokenizer st = new StringTokenizer(line);
        
        while(st.hasMoreTokens()) // loop to check input for number value
        {
            input = Integer.parseInt(st.nextToken()); // value of input in current loop
            count++; // number of times loop has run
            
            if (first == 0) // if loop has not run
            {
                if (input == 12) // and the first number is "12"
                {
                    first = last = count; // set to first and last position
                    sum++; // number of times "12" was found
                }
            }
            
            else if (input == 12) // if loop has run and a 12 is found
            {
                last = count; // set to last position
                sum++;
            }
        }
        
        System.out.println("The number 12 first appears at " + first);
        System.out.println("The number 12 last appears at " + last);
        System.out.println("You entered the number 12 " + sum + " times");
  }
  
  public static void minMaxAvg() throws IOException
  {
        int input, min, max, sum;
        double avg, count;
        
        input = sum = 0;
        avg = count = 0;
        
        min = Integer.MAX_VALUE;
        max = Integer.MIN_VALUE;
	
        System.out.println("- - -");
        System.out.println("This program will find the minimum, maximum, and average of all values.");
        System.out.println("Please enter some numbers:");
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in)); // receive input
        String line = br.readLine(); // read input
        StringTokenizer st = new StringTokenizer(line);
        
        while(st.hasMoreTokens()) // loop to check input for number value
        {
            input = Integer.parseInt(st.nextToken()); // value of input in current loop
                        
            sum += input; // running total of all inputs
            count++; // total number of loops
            avg = sum / count; // divide sum by count to find average
                
            if (input < min) // if input is less than previous minimum
                min = input; // input set to minimum
            if (input > max) // if input is greater than previous maximum
                max = input; // input set to maximum
        }
        
        System.out.println("The minimum value is " + min);
        System.out.println("The maximum value is " + max);
        System.out.println("The average value is " + avg);
  }
  
  public static void gradeCalculator() throws IOException
  {
	int  sumA, sumB, sumC, sumD, sumF, input;
	sumA = sumB = sumC = sumD = sumF = 0;
	
        System.out.println("- - -:");
        System.out.println("This program will find the letter grade of all values entered.");
        System.out.println("It will also total your grades.");
        System.out.println("Please enter your numberic grades:");
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in)); // receive input
        String line = br.readLine(); // read input
        StringTokenizer st = new StringTokenizer(line);
        
        while(st.hasMoreTokens()) // loop to check input for number value
        {
            input = Integer.parseInt(st.nextToken()); // value of input in current loop

            if(input >= 90) // 90 - 100 A
            {
                sumA++;
                System.out.println(input + "      A");
	    }
            
            else if(input >= 80) // 80 - 89 B
            {
                sumB++;
                System.out.println(input + "      B");
            }
            
            else if(input >= 70) // 70 - 79 C
            {
                sumC++;
                System.out.println(input + "      C");
            }
            
            else if(input >= 60) // 60 - 69 D
            {
                sumD++;
                System.out.println(input + "      D");
            }
            
            else // 59 and below F
            {
                sumF++;
                System.out.println(input + "      F");
            }
        }
        
        System.out.println("The total number of A's is " + sumA);
        System.out.println("The total number of B's is " + sumB);
        System.out.println("The total number of C's is " + sumC);
        System.out.println("The total number of D's is " + sumD);
        System.out.println("The total number of F's is " + sumF);
   }
}