package ASG1;

/* Programmed by:
   Morgan McCollum @mmdk4
   David Rutsch @dmr5zb */

import java.io.IOException;
import java.util.Scanner;

public class RunAsg1
{
    public static void main (String[] args) throws IOException
    {
        RunAsg1 ra1 = new RunAsg1();
        RunAsg1.menu();
    }
    
    public static void menu() throws IOException
    {
        int input;
        char repeat = 'y';
             
        while (repeat == 'y' || repeat == 'Y')
        {
            System.out.println("Welcome to the great list of programs for ASG1:");
            System.out.println("1 - Product");
            System.out.println("2 - CountTwelve");
            System.out.println("3 - MinMaxAvg");
            System.out.println("4 - GradeCalculator");
            System.out.println("");
            System.out.println("Please enter a number to run the program (0 to exit):");

            Scanner scan = new Scanner(System.in);
            input = scan.nextInt();

            switch (input)
            {
                case 1: Methods.product();
                        break;
                case 2: Methods.countTwelve();
                        break;
                case 3: Methods.minMaxAvg();
                        break;
                case 4: Methods.gradeCalculator();
                        break;
                case 0: System.exit(0);
                        break;
                default: System.out.println("Please enter a valid input!");
                        break;
            }
            
            System.out.println("");
            System.out.println("Would you like to run again? (y/n)");
            repeat = scan.next().charAt(0);
            System.out.println("- - -");
        }
    }
}