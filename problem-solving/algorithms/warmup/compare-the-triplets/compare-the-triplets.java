import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

public class Solution {

    static List<Integer> compareTriplets(List<Integer> a, List<Integer> b) {
        int pointsAlice = 0;
        int pointsBob = 0;

        pointsAlice = (a.get(0)>b.get(0)?1:0) + (a.get(1)>b.get(1)?1:0) + (a.get(2)>b.get(2)?1:0) ;
        pointsBob = (a.get(0)<b.get(0)?1:0) + (a.get(1)<b.get(1)?1:0) + (a.get(2)<b.get(2)?1:0) ;

        List<Integer> returnValues = new ArrayList<Integer>();
        returnValues.add(pointsAlice);
        returnValues.add(pointsBob);
        return returnValues;
    }

    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        List<Integer> a = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        List<Integer> b = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        List<Integer> result = compareTriplets(a, b);

        bufferedWriter.write(
            result.stream()
                .map(Object::toString)
                .collect(joining(" "))
            + "\n"
        );

        bufferedReader.close();
        bufferedWriter.close();
    }
}
