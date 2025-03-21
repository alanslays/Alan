﻿using System;

public class Worker
{
    public string CurrentJob { get; set; }
    public int ShiftsLeft { get; set; }

    public Worker()
    {
        CurrentJob = string.Empty;
        ShiftsLeft = 0;
    }
    public bool DoThisJob(string job, int numberOfShifts)
    {
        if (string.IsNullOrEmpty(CurrentJob)) 
        {
            CurrentJob = job;
            ShiftsLeft = numberOfShifts;
            return true;
        }
        return false;
    }
    public bool DidYouFinish()
    {
        return ShiftsLeft == 0;
    }
}

public class Queen
{
    public Queen(Worker[] workers)
    {
        this.workers = workers;
    }

    private Worker[] workers;
    private int shiftNumber = 0;

    
    public bool AssignWork(string job, int numberOfShifts)
    {
        for (int i = 0; i < workers.Length; i++)
            if (workers[i].DoThisJob(job, numberOfShifts))
                return true;
        return false;
    }

    
    public string WorkTheNextShift()
    {
        shiftNumber++;
        string report = "Raport zmiany numer " + shiftNumber + "\r\n";
        for (int i = 0; i < workers.Length; i++)
        {
            if (workers[i].DidYouFinish())
                report += "Robotnica numer " + (i + 1) + " zakończyła swoje zadanie\r\n";
            if (String.IsNullOrEmpty(workers[i].CurrentJob))
                report += "Robotnica numer " + (i + 1) + " nie pracuje \r\n";
            else if (workers[i].ShiftsLeft > 0)
                report += "Robotnica numer " + (i + 1) + " robi '" + workers[i].CurrentJob + "' jeszcze przez " + workers[i].ShiftsLeft + " zmiany\r\n";
        }
        return report;
    }
}
