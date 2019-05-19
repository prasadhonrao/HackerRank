import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static void plusMinus(int[] arr) {
        int n = arr.length;
        int positives = (int) Arrays.stream(arr).filter(x -> x > 0).count();
        int negatives = (int) Arrays.stream(arr).filter(x -> x < 0).count();
        int zeroes = (int) Arrays.stream(arr).filter(x -> x == 0).count();
        
        float positiveFraction = (float)positives / (float)n;
        float negativeFraction = (float)negatives / (float)n;
        float zeroFraction = (float)zeroes / (float)n;
        
        System.out.println(positiveFraction);
        System.out.println(negativeFraction);
        System.out.println(zeroFraction);
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] arr = new int[n];

        String[] arrItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int arrItem = Integer.parseInt(arrItems[i]);
            arr[i] = arrItem;
        }

        plusMinus(arr);

        scanner.close();
    }
}
