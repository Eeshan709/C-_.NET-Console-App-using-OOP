using System;

public class Programmer : Creator { //Programmer class inheriting Creator class

    public override void Create(){ //overriding abstract method and specifying it to current class

        if(base.CreativityLevel >=70 && base.Energy >= 75)
        {
            this.BrainstormSolutions();
            this.PickMostOptimalSolution();
            this.WriteCode();
            this.TestCode();
        }
        else
        {
            throw new Exception("Not enough creativity.");
        }

        

    }

    private void BrainstormSolutions(){ //making methos private to achieve encapsulation

        base.CreativityLevel = base.CreativityLevel - 15;
        base.Energy = base.Energy - 10;
        Console.WriteLine("Brainstorming solutions...");

    }

    private void PickMostOptimalSolution(){

        base.CreativityLevel = base.CreativityLevel - 5;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Picking most optimal solution.");

    }

    private void WriteCode(){

        base.CreativityLevel = base.CreativityLevel - 7;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Writing code...");

    }

    private void TestCode(){

        base.CreativityLevel = base.CreativityLevel - 3;
        base.Energy = base.Energy - 2;
        Console.WriteLine("Testing code...");

    }

}