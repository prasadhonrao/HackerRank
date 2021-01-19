import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int N = in.nextInt();
        
        if (N >= 2 && N <= 20) {
            int number = 1;
            for (number = 1; number <= 10; number++) {
                System.out.println(N + " x " + number + " = " + N * number);
            }
        }
    }
}
