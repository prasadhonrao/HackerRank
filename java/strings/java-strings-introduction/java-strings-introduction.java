import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        String B=sc.next();
        sc.close();
       
        System.out.println(A.length() + B.length());
        
        char aChar = A.charAt(0);
        char bChar = B.charAt(0);
        if (aChar > bChar) {
        	System.out.println("Yes");
        } else {
        	System.out.println("No");
        }
        
        String capitalizedOutput = A.substring(0,1).toUpperCase()+ A.substring(1) + " " + B.substring(0,1).toUpperCase()+ B.substring(1);
        
        System.out.println(capitalizedOutput);
        
    }
}
