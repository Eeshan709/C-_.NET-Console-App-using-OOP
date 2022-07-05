using System;

public class Youtuber : Creator { //Programmer class inheriting Creator class

    public override void Create() //overriding abstract method and specifying it to current class
    {

        if (base.CreativityLevel >= 60 && base.Energy >= 55)
        {
            this.BrainstormVideoIdeas();
            this.CreateScript();
            this.VideotapeScript();
            this.EditingVideo();
            this.RenderingVideo();
        }
        else
        {
            throw new Exception("Not enough creativity and energy.");
        }

    }

    private void BrainstormVideoIdeas(){ //making methos private to achieve encapsulation

        base.CreativityLevel = base.CreativityLevel - 5;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Brainstorming video ideas...");

    }

    private void CreateScript(){

        base.CreativityLevel = base.CreativityLevel - 5;
        base.Energy = base.Energy - 5;
        Console.WriteLine("Creating Video Script.");

    }

    private void VideotapeScript(){

        base.CreativityLevel = base.CreativityLevel - 1;
        base.Energy = base.Energy - 6;
        Console.WriteLine("Videotaping myself executing the script.");

    }

    private void EditingVideo(){

        base.CreativityLevel = base.CreativityLevel - 6;
        base.Energy = base.Energy - 6;
        Console.WriteLine("Editing the video.");

    }

    private void RenderingVideo(){

        base.CreativityLevel = base.CreativityLevel - 1;
        base.Energy = base.Energy - 1;
        Console.WriteLine("Rendering the video.");

    }

}