package com.sudofolks;

import com.sudofolks.pal.Palendrom;

import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("enter the palandrom input string ");
        String palIn = scan.next();
        boolean isPal =  Palendrom.isPal(palIn);
        System.out.println("KiK is Palandrom :" + isPal);
    }
}