package ASG2;

import java.util.*;
import java.io.*;

/* ASG2 --- 
    Programmed by: David Rutsch and Morgan McCollum */

public class ATM 
{
    static Scanner sc = new Scanner(System.in);
    static String userprofile = System.getProperty("user.home");
    
    public static void main(String[] args) throws IOException
    {
        File dir = new File("accounts/");
        dir.mkdir();
        ATM log = new ATM();
        log.loginMenu();
    }
    
    public void loginMenu() throws IOException 
    {
        File file = new File(("accounts/"));
        file.mkdir();
    
        System.out.println("   _________________________________");
        System.out.println(" /|                                 |");
        System.out.println("| |     WELCOME TO THE REAL BANK    |");
        System.out.println("| |            ~*~*~*~*~            |");
        System.out.println("| |       NEW CUSTOMER OFFER:       |");
        System.out.println("| |  Sign up for an account today   |");
        System.out.println("| |   and receive a FREE GRILL !!!  |");
        System.out.println("| |      (while supplies last)      |");
        System.out.println("| |_________________________________|");
        System.out.println("|/_________________________________/");
        System.out.println("");
        System.out.println("          1. Create Account");
        System.out.println("          2. Login");
        System.out.println("");
        System.out.println("Please enter your choice (0 to exit): ");
        
        int input3 = sc.nextInt();
        
        Account acct = new Account();
        
        switch (input3)
        {
            case 1: acct.cAct();
                    break;         
            case 2: acct.login(3);
                    break;
            case 0: System.exit(0);
                    break;  
            default: System.out.println("Please enter a valid input!");
                     break;
        }   
    }
   
    public void acctMenu() throws IOException
    {
        int input;
        Account acct = new Account();
                 
        System.out.println("      You are now in Account #" + acct.aNum);
        System.out.println("           Balance: " + acct.formatBal(acct.balance));
        System.out.println("        Interest Earned: " + acct.formatBal(acct.totalInt));
        System.out.println("            1 - Deposit");
        System.out.println("            2 - Withdraw");
        System.out.println("            3 - Check Balance"); 
        System.out.println("            0 - Logout");
        System.out.println("");
        System.out.println("Please enter your choice: ");

        Scanner scan = new Scanner(System.in);
        input = scan.nextInt();
        
        switch (input)
        {
            case 1: acct.deposit();
                    break;
            case 2: acct.withdraw();
                    break;
            case 3: acct.balCheck();
                    break;
            case 0: acct.logout();
                    break;
            default: System.out.println("Please enter a valid input!");
                    break;
        }
    }
}