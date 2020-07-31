//Anagrams
import java.util.Scanner;

public class Solution {

    static boolean isAnagram(String a, String b) {
        // Complete the function
        a=a.toLowerCase();b=b.toLowerCase();
        if(a.length()!=b.length()){
            return false;
        }else if (a.equals(b)){
            return true;
        }
        for (int i = 0; i < a.length(); i++) {
        char ch = a.charAt(i);

        if (b.indexOf(ch) == -1) 
            return false;
        else
            b = b.replaceFirst(String.valueOf(ch), " ");
    }

    return true;
    }
  public static void main(String[] args) {
    
        Scanner scan = new Scanner(System.in);
        String a = scan.next();
        String b = scan.next();
        scan.close();
        boolean ret = isAnagram(a, b);
        System.out.println( (ret) ? "Anagrams" : "Not Anagrams" );
    }
}
