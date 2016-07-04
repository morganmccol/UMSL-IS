package ASG2;

import java.io.*;
import java.text.*;
import java.util.*;
import java.io.File;

/* ASG2 --- 
    Programmed by: David Rutsch and Morgan McCollum */

public class Account
{    
    /* readFile Attributes*/
    private final String userprofile = System.getProperty("user.home");
    private Double fileBalance;
    private Double fileInt;
    private Integer fileANum;
    private int count;
    
    /* User Input*/
    static Scanner sc = new Scanner(System.in);
    private int memNum;
    private int[] actNum;
    static Integer aNum = 0;
    
    /* Bank Core Attributes*/
    private final int i = 0;
    private double deposAmt;
    private double withdAmt;
    static double interest = 0.05;
    static double balance = 100;
    ATM menu = new ATM();
    
    /*Dates*/
    static double daysInt = 0;
    static double totalInt = 0;
    static int dateChk = 0;
    static int date1 = 0;
    private int date2 = 0;
    static String inDate = "";
    private String outDate = "";
    
    /*getDate Attributes*/
    private int firstdate;
    private int seconddate;
    private final Calendar cal1 = new GregorianCalendar();
    private final Calendar cal2 = new GregorianCalendar();
    
    /* LOGIN-----*/
    public void login(int mn) throws IOException
    {
        System.out.println("Please enter your account number:");
        this.memNum = mn;
        memNum = sc.nextInt();
        readFile();
        
        if (memNum == fileANum)
        {
            System.out.println("Welcome back account holder: " + (fileANum)+"!");
            aNum = fileANum;
            balance = fileBalance;
            totalInt = fileInt;
            System.out.println("Logging in...");
            mReturn();
        } 
            
        else 
        {
            System.out.println("Sorry, that account number does not exist");
            System.out.println("Returning to login menu...");
            callMenu();
        }
        
        writeFile();
    }
    /*END LOGIN-----*/
   
    /* BANK CORE ----- */     
    public String formatBal(double balance)
    {
        NumberFormat fmt = NumberFormat.getCurrencyInstance(Locale.US);
        String currencyOut = fmt.format(balance);
        return currencyOut;
    }
    
    public void balCheck() throws IOException
    {
        readFile();
        getDate();
        
        System.out.println("Your balance on this date is: " + formatBal(balance));
        System.out.println("Your total interest earned is: " + formatBal(totalInt));
        
        mReturn();
    }
     
    public void deposit() throws IOException
    {
        readFile();
        getDate();
   
        System.out.println("How much would you like to deposit?");
        deposAmt = sc.nextDouble();
        balance += deposAmt;
        fileBalance = balance;
        System.out.println("Your balance is now: " + formatBal(balance));
        if (daysInt > 0)
            System.out.println("Wow! You earned " + formatBal(daysInt) + " in interest.");
        
        mReturn();
    }
 
    public void withdraw() throws IOException
    {
        readFile();
        getDate();
        
        System.out.println("How much would you like to withdraw?");
        withdAmt = sc.nextDouble();
        
        if (withdAmt > balance)
            System.out.println ("ERROR: You cannot withdraw more than " + formatBal(balance));
        
        else
        {
            balance += - withdAmt; 
            fileBalance = balance;
            System.out.println("Your balance is now: " + formatBal(balance));
            if (daysInt > 0)
                System.out.println("Wow! You earned " + formatBal(daysInt) + " in interest.");
        }
        
        mReturn();
    }
    
    public void calcInt() throws IOException
    {
        double dailyInt = interest / 365;
        int daysCalc = date2 - date1;
        daysInt = (daysCalc * dailyInt) * balance;
        totalInt += daysInt;
        fileInt = totalInt;
        balance += daysInt;
        writeFile();
    }
    /* BANK CORE END ----- */
    
    /* ACCOUNT CREATION -----*/
    public void cAct() throws IOException
    { 
        File f = new File("accounts/account"+(aNum)+".txt");
        
        for( int count = 0; count < 3; count++)
        {
            if(f.exists())
            {
                aNum++;
                f = new File("accounts/account"+(aNum)+".txt");
            }                
        }
                
        if(aNum > 2)
        {
            System.out.println("Sorry. We're at full capacity and cannot currently support any additional accounts!");
            System.out.println("Please use accounts 0, 1, or 2.");
            System.out.println("Enter any key to continue...");
            sc.nextLine();
            callMenu();      
        }
                 
        if(!f.exists())
        {
            System.out.println("Your account number is: " + (aNum));
            System.out.println("Please write down your account number in a safe place!");
            balance = 100;
            daysInt = 0;
            totalInt = 0;
            writeFile();
            System.out.println("Enter any key to continue...");
            sc.nextLine();
            clear();
            menu.acctMenu();
        }             
    }
    /* ACCOUNT CREATION END -----*/
    
    /* MENU CLEAR -----*/
    public void waitSec() throws IOException
    {
        try
        {
            Thread.sleep(3000);
        }
           
        catch(InterruptedException ex)
        {
            Thread.currentThread().interrupt();
        }   
    }
      
    public void clear() throws IOException
    {
        char c = '\n';
        int length = 25;
        char[] chars = new char[length];
        Arrays.fill(chars, c);
        System.out.print(String.valueOf(chars));
    }
    /* MENU CLEAR END -----*/

    /* CALL AND RETURN -----*/   
    public void callMenu() throws IOException
    {
        waitSec();
        clear();
        menu.loginMenu();
    }
     
    public void mReturn() throws IOException
    {   
        writeFile();
        waitSec();
        clear();
        menu.acctMenu();
    }
    /* END CALL AND RETURN -----*/
    
    public void logout() throws IOException
    {   
        fileANum = null;
        fileBalance = null;
        fileInt = null;
        dateChk = 0;
        callMenu();  
    }
    
    /* DATE METHODS -----*/
    public void getDate() throws IOException
    {       
        if (dateChk < 1)
        {
            dateChk++;
            date1();
        }
        
        else
        {
            date2();
            calcInt();
            date1 = date2;
        }
    }
    
    public void date1() throws IOException
    {
        System.out.println("What is today's date? (mm/dd/yyyy)");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        inDate = br.readLine();
        SimpleDateFormat dateFormat = new SimpleDateFormat("MM/dd/yyyy");
        ParsePosition ps1 = new ParsePosition(0);
        Date date = dateFormat.parse(inDate, ps1);
        cal1.setTime(date);
        date1 = cal1.get(cal1.DAY_OF_YEAR);
    }
    
    public void date2() throws IOException
    {
        System.out.println("What is the transaction date? (mm/dd/yyyy)");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        outDate = br.readLine();
        SimpleDateFormat dateFormat = new SimpleDateFormat("MM/dd/yyyy");
        ParsePosition ps2 = new ParsePosition(0);
        Date date = dateFormat.parse(outDate, ps2);
        cal2.setTime(date);
        date2 = cal2.get(cal2.DAY_OF_YEAR);

        if (date2 < date1)
        {
            System.out.println("ERROR: Please enter a future date!");
            getDate();
        }
    } 
    /* DATE METHODS END -----*/

    /* READ AND WRITE -----*/
    public void writeFile() throws IOException
    {
        File file = new File("accounts/account"+(aNum)+".txt");
        PrintWriter printWriter = null;

        try
        {
            printWriter = new PrintWriter(file);
            printWriter.println((aNum) + "," + (balance) + "," + (totalInt));
        }
        
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
        
        finally
        {
            if (printWriter != null)
                printWriter.close();
        }
    }

    public void readFile() throws IOException
    {
        try
        {
            BufferedReader in = new BufferedReader(new FileReader("accounts/account"+(memNum)+".txt"));
            String line;
            
            while ((line = in.readLine()) != null)
            {
                String[] element = line.split(",");
                fileANum = (int) Double.parseDouble(element[0]);
                fileBalance = Double.parseDouble(element[1]);
                fileInt = Double.parseDouble(element[2]);
            }
            in.close();
        } 
        
        catch (IOException e)   
        {
            System.out.println("Sorry, that account number does not exist!");
            System.out.println("Returning to login menu...");
            callMenu();
        }
    }
    /* READ AND WRITE END ----- */
}    