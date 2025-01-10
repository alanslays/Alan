using System;

public class Worker
{
    public Worker(string[] jobsICanDo)
    {
        _ = this.jobsICanDo;
    }

    public int ShiftsLeft
    {
        get
        {
            return shiftsToWork - shiftsWorked;
        }
    }

    private string currentJob = "";
    public string CurrentJob
    {
        get
        {
            return currentJob;
        }
    }

    private string[] jobsICanDo;
    private int shiftsToWork;
    private int shiftsWorked;

    public bool DoThisJob(string job, int numberOfShifts)
    {
        if (!string.IsNullOrEmpty(currentJob))
        {
           // return false
                    for (int i = 0; i < jobsICanDo.Length; i++)
                        if (jobsICanDo[i] == job)
                            currentJob = job;
                            this.shiftsToWork = numberOfShifts;
                            shiftsWorked = 0;
                            return true;
        }
            return false;      
    }    
    
    public bool DidYouFinish()
    {
        if (string.IsNullOrEmpty(currentJob))
            return false;
        shiftsWorked++;
        if (shiftsWorked > shiftsToWork)
        {
            shiftsWorked = 0;
            shiftsToWork = 0;
            currentJob = "";
            return true;
        }
        else
            return false;
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
                report += "Robotnica numer " + (i + 1) + " zakończyła swoje zadanie \r\n";
            if (string.IsNullOrEmpty(workers[i].CurrentJob))
                report += "Robotnica numer " + (i + 1) + " nie pracuje \r\n";
            else
                if (workers[i].ShiftsLeft > 0)
                report += "Robotnica numer " + (i + 1) + " robi '" + workers[i].CurrentJob + "' jeszcze przez " + workers[i].ShiftsLeft + " zmiany \r\n";
            else
                report += "Robotnica numer " + (i + 1) + " zakończy '" + workers[i].CurrentJob + "' po tej zmianie \r\n";
        }
        return report;
    }
}