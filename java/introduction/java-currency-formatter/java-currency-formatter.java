import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double payment = scanner.nextDouble();
        scanner.close();

        NumberFormat usd = NumberFormat.getCurrencyInstance(Locale.US);
        String us = usd.format(payment);
        
        NumberFormat inr = NumberFormat.getCurrencyInstance(new Locale("en", "in"));
        String india = inr.format(payment);
        
        NumberFormat cny = NumberFormat.getCurrencyInstance(Locale.CHINA);
        String china = cny.format(payment);
        
        NumberFormat fr = NumberFormat.getCurrencyInstance(Locale.FRANCE);
        String france = fr.format(payment);
        
        System.out.println("US: " + us);
        System.out.println("India: " + india);
        System.out.println("China: " + china);
        System.out.println("France: " + france);
    }
}
