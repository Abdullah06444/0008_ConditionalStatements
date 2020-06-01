package Beginner;

import java.util.Scanner;

public class Java0008_ConditionalStatements {

    public static void main(String[] args) {

        System.out.print("The monthly income is ");
        Scanner scan = new Scanner(System.in);
        int monthly_income = scan.nextInt();
        float monthly_tax;

        if (monthly_income < 1000) {

            monthly_tax = (float) (0.0 * monthly_income);
            System.out.println("S/He will not pay any tax.");
            System.out.printf("%.2f TL.",monthly_tax);
        }
        else if (monthly_income >= 1000 && monthly_income < 3000) {

            monthly_tax = (float) (0.1 * monthly_income);
            System.out.print("S/He should pay ");
            System.out.printf("%.2f TL.", monthly_tax);
        }
        else {

            monthly_tax = (float) (0.15 * monthly_income);
            System.out.print("S/He should pay ");
            System.out.printf("%.2f TL.", monthly_tax);
        }

        System.out.println("\nYou have to do it for living free in this country. :D");
    }
}
