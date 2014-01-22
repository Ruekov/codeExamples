
package stacktest;
import java.util.Stack;

public class StackTest {
    
    public static boolean isBalanced(String s) {
        
        Stack<Character> stack = new Stack<Character>();
        
        for (int i = 0; i < s.length(); i++) {

            
            if      (s.charAt(i) == '(') stack.push(s.charAt(i));
            else if (s.charAt(i) == '[') stack.push(s.charAt(i));
            else if (s.charAt(i) == '{') stack.push(s.charAt(i));
            
            else if (s.charAt(i) == '}') {
                if (stack.isEmpty()) return false;
                if (stack.pop() != '{') return false;
                
            }
            else if (s.charAt(i) == ')') {
                if (stack.isEmpty()) return false;
                if (stack.pop() != '(' ) return false;
            }
            else if (s.charAt(i) == ']') {
                if (stack.isEmpty()) return false;
                if (stack.pop() != '[') return false;
            }

            // ignore all other characters

        }
        return stack.isEmpty();
    
    
    }
    
    public static void main(String[] args) {
        
        
        System.out.println("Testing function");
     
        boolean[] expected = {true, false, true,false,false,false,false,false,false, false,true} ;
        String[] test = {"{()[]}", "{(["," ", "(", "{", "[", "}", "]", "}",")}]","{(a*a)+[b+b]/[z+z]}"};
        

        for(int i=0;test.length>i;i++){

            if (isBalanced(test[i])!=expected[i]){
                System.out.println("... ERROR");
                break;
            }  
            System.out.println("Pass test: "+i+" "+test[i]+" Is balanced? "+expected[i]);
            
        }
        
        
    }
}
