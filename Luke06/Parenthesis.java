public class Parenthesis {

   static int _counter =0;

    public static void main(String[] args) {
        parenthesis(13,0,0,"");

        System.out.println(_counter);
    }

    public static void parenthesis(int pairs, int open, int close, String result){

      if ( pairs==open && pairs==close){
         _counter++;
      }
      else{

         if (open<pairs) {
            parenthesis(pairs, open+1, close, result + "(");
         }
         if(close<open){
            parenthesis(pairs, open, close+1, result + ")");
         }

       }
    }

}
