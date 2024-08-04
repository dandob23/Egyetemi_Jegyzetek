public class Palindrom {
    public static boolean isPalindrome(String s) {
        String str = s.toLowerCase();
        String reverse = "";
        for (int i = str.length() - 1; i >= 0; i--) {
            reverse = reverse + str.charAt(i);
        }
        return str.equals(reverse);
    }

    public static boolean isPalindrome2(int n) {
        int number = n;
        int reverse = 0;

        while (number != 0) {
            int remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number = number / 10;
        }
        return n == reverse;
    }
}