import java.io.*;
import java.math.*;
import java.text.*;
import java.util.*;
import java.util.regex.*;

public class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static String timeConversion(String s) {
        /*
         * Write your code here.
         */if(s.contains("AM")){
            if(s.indexOf("12") == 0){
                s = s.replaceFirst("12", "00");
                s = s.replaceFirst("AM", "");
                return s;
            }
            else{
                s = s.replaceFirst("AM", "");
                return s;
            }
        }
        else if(s.contains("PM")){
            int hour = Integer.parseInt(s.substring(0, 2));
            if(hour >= 1 && hour <=11)  hour += 12;
            s = s.replaceFirst(s.substring(0, 2), Integer.toString(hour));
            s = s.replaceFirst("PM", "");
            return s;
        }
        else return "";
    }

    private static final Scanner scan = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bw = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scan.nextLine();

        String result = timeConversion(s);

        bw.write(result);
        bw.newLine();

        bw.close();
    }
}
