package com.sudofolks.pal;

public class Palendrom {

    public static boolean isPal(String palString) {
        String palRevered = "";
        char[] carry = palString.toCharArray();
        for (int i = carry.length - 1; i >= 0; i--) {
            char value = carry[i];
            System.out.println("revered char: " + value);
            palRevered = palRevered + value;
        }
        return palRevered.equals(palString);
    }

    public static boolean isPalUsingSBuffer(String palString) {
        StringBuffer palReverse = new StringBuffer(palString);
        palReverse = palReverse.reverse();
        return palReverse.toString().equals(palString);
    }

}
