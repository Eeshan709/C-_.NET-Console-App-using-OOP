using System;

public class Youtuber : Creator {

    public override void Create()
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

    private void BrainstormVideoIdeas(){

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