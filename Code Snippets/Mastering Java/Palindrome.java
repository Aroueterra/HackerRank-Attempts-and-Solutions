//Palindrome
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        Boolean flag = true;
        int i = 0, j = A.length()-1;
        while(i<j){
            if(A.charAt(i) != A.charAt(j)){
                flag = false;
                break;
            }
            i++; j--;
        }
        if(flag){
            System.out.println("Yes");
        }else{
            System.out.println("No");
        }
    }
}



