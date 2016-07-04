package ASG3;

import java.io.Serializable;

/* ASG1 --- 
    Programmed by: David Rutsch and Morgan McCollum */

public class Checking extends Account implements Serializable
{
    @Override
    public void getInterest()
    {
        int id = getID();
        int datediff = seconddate - firstdate;
        rate = 0.1 / 365;
        double ratetime = Math.pow(1 + rate, datediff);
        balance *= ratetime;
        firstdate = seconddate;
    } 
    
    @Override
    public String setType()
    {
        String type = "Checking";
        return type;
    }
}