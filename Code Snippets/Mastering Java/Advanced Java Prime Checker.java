//Advanced Java Prime Checker
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.lang.reflect.*;
import static java.lang.System.in;
class Prime { 
    public void checkPrime(int... integers){
        int k = 0;
        boolean prime = false;
        StringBuilder result = new StringBuilder();
        for(int x : integers){
            if (k > 0 && integers.length > 1 && prime == true) {
                // System.out.println(">"+x+"<");
                result.append(" ");
                prime = false;
            }
            if(isPrime(x)){
                prime = true;
                result.append(x);
            }
            k++;
        }
        String output = result.toString();
        System.out.println(output.trim());
    }
    public static boolean isPrime(int val) {
    if (val < 2)
        return false;

    for (int i = 2, max = (int)Math.sqrt(val); i <= max; i++)
        if (val % i == 0)
            return false;

    return true;
}
}


public class Solution {

	public static void main(String[] args) {
		try{
		BufferedReader br=new BufferedReader(new InputStreamReader(in));
		int n1=Integer.parseInt(br.readLine());
		int n2=Integer.parseInt(br.readLine());
		int n3=Integer.parseInt(br.readLine());
		int n4=Integer.parseInt(br.readLine());
		int n5=Integer.parseInt(br.readLine());
		Prime ob=new Prime();
		ob.checkPrime(n1);
		ob.checkPrime(n1,n2);
		ob.checkPrime(n1,n2,n3);
		ob.checkPrime(n1,n2,n3,n4,n5);	
		Method[] methods=Prime.class.getDeclaredMethods();
		Set<String> set=new HashSet<>();
		boolean overload=false;
		for(int i=0;i<methods.length;i++)
		{
			if(set.contains(methods[i].getName()))
			{
				overload=true;
				break;
			}
			set.add(methods[i].getName());
			
		}
		if(overload)
		{
			throw new Exception("Overloading not allowed");
		}
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
	
}

