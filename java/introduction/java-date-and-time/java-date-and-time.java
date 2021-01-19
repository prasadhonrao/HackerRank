import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.time.*;


public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String month = in.next();
        String day = in.next();
        String year = in.next();
        LocalDate dt = LocalDate.of(Integer.valueOf(year), Integer.valueOf(month), Integer.valueOf(day));
        System.out.println(dt.getDayOfWeek());
    }
}
