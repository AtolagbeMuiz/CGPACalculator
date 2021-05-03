using System;
using CGPACalculator;

   public class Menu
   {
       private int _currentStage;

     
        //Sets the stage
       public void setCurrentStage(int stage)
       {
           this._currentStage = stage;
       }

       public int getCurrentStage()
       {
           return _currentStage;
       }

    //public int setCurrentStage { get; set; }


       public static void promptUser(string propmtMessage)
       {
           System.Console.WriteLine(propmtMessage);

       }
      
   }