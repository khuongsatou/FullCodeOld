/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package printcalendar;

/**
 *
 * @author SV
 */
public class PrintCalendar {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int thang = 3, nam = 2019;
        printMonth(thang, nam);
    }
    
    public static boolean isLeapYear(int year) {
        return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
    }
    
    public static int getNumberOfDaysInMonth(int month, int year) {
        
        switch(month) {
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                if(isLeapYear(year))
                    return 29;
                return 28;
        }
        
        return 31;
    }
    
    public static int getTotalNumOfDays(int month, int year) {
        int totalDays = 0;
        
        // Tính số ngày từ 1/1/2000 -> 1/1/year
        for(int i=2000; i<year; i++) {
            /*
            if(isLeapYear(i))
                totalDays += 366;
            else
                totalDays += 365;
            */
            totalDays += (isLeapYear(i) ? 366 : 365);
        }
        
        // Tính số ngày từ 1/1/year -> 1/month/year
        for(int i=1; i<month; i++) {
            totalDays += getNumberOfDaysInMonth(i, year);
        }
        
        return totalDays;
    }
    
    public static int getStartDay(int month, int year) {
		// Cộng 6 vì ngày 1/1/2000 là thứ 7 (6)
        return (getTotalNumOfDays(month, year) + 6) % 7; 
    }
    
    public static void printMonthBody(int month, int year) {
        int numOfDays = getNumberOfDaysInMonth(month, year);
        int startDay = getStartDay(month, year);
        //System.out.println("Start day = " + startDay);
        for(int i=0; i<startDay; i++) {
            System.out.print("\t");
        }
        
        for(int i=1; i<=numOfDays; i++) {
            System.out.print(i + "\t");
            
            if((i + startDay) % 7 == 0) {
                System.out.println();
            }
        }
        
        System.out.println();
    }
    
    public static String getMonthName(int month) {
        
        switch(month) {
            case 1: return "January";
            case 2: return "February";
            case 3: return "March";
            case 4: return "April";
            case 5: return "May";
            case 6: return "June";
            case 7: return "July";
            case 8: return "August";
            case 9: return "September";
            case 10: return "October";
            case 11: return "November";
        }
        
        return "December";
    }
    
    public static void printMonthTitle(int month, int year) {
        System.err.println("\t\t    " + getMonthName(month) + " " + year);
        System.out.println("---------------------------------------------------");
        System.out.println("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
    }
    
    public static void printMonth(int month, int year) {
        printMonthTitle(month, year);
        printMonthBody(month, year);
    }
}