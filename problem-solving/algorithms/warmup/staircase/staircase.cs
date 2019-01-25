using System;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int count = 1; count <= n ; count++) {
            for (int i = n - count; i > 0 ; i--) {
                Console.Write(" ");
            }
            
            for (int j = 0; j < count; j++) {
                Console.Write("#");    
            }
            Console.WriteLine();
        }
    }
}
