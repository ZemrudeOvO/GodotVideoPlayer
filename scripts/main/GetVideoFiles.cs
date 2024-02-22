using Godot;
using System;

public partial class GetVideoFiles : Node
{
    public override void _Ready()
    {
        DirContents("res://videos");
    }

    public void DirContents(string path)
    {
        using var dir = DirAccess.Open(path);
        if (dir != null)
        {
            dir.ListDirBegin();
            string fileName = dir.GetNext();
            while (fileName != "")
            {
                if (dir.CurrentIsDir())
                {
                    GD.Print($"find dir: {fileName}");
                }
                else
                {
                    GD.Print($"find file: {fileName}");
                    GD.Print($"file extension: {fileName.GetExtension()}");
                }
                fileName = dir.GetNext();
            }
        }
        else
        {
            GD.Print("access wrong");
        }
    }
}
/*
find file: output - 副本 (2).ogv
find file: output - 副本 (3).ogv
find file: output - 副本 (4).ogv
find file: output - 副本.ogv
*/
