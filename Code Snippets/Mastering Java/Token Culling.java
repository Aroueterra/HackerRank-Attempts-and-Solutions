//Token Culling
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String s = scan.nextLine();
        s = s.replaceAll("[^a-zA-Z0-9\\s]", " ");
        List<String> exploded = new ArrayList<String>(Arrays.asList(s.split(" ")));
        exploded.removeAll(Collections.singleton(null));
        exploded.removeAll(Collections.singleton(""));
        System.out.println(exploded.size());
        for(String x : exploded){
            if(!(x.isEmpty() || x.trim().equals("") || x.trim().equals("\n"))) {
                System.out.println(x);   
            }
        }
        scan.close();
    }
}

