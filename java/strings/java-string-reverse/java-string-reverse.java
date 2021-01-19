import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
       Scanner scanner = new Scanner(System.in);
        
        String original = scanner.next();

        StringBuilder sb = new StringBuilder();
        sb.append(original);

        String reverse = sb.reverse().toString();
        if (original.equals(reverse)) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
        
        
        scanner.close();
        
    }
}
