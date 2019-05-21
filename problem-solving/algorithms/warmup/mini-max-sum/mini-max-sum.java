import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Solution {

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] a) {
        List<Integer> arr = Arrays.stream(a)        // IntStream
                                    .boxed()          // Stream<Integer>
                                    .collect(Collectors.toList());

        long min = arr.stream().mapToLong(f -> f).min().getAsLong();
        long max = arr.stream().mapToLong(f -> f).max().getAsLong();
        long sum = arr.stream().mapToLong(f -> f).sum();
        System.out.println((sum - max) + " " + (sum - min));
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int[] arr = new int[5];

        String[] arrItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < 5; i++) {
            int arrItem = Integer.parseInt(arrItems[i]);
            arr[i] = arrItem;
        }

        miniMaxSum(arr);

        scanner.close();
    }
}
