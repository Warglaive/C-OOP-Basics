﻿using System;

public class StartUp
{
    public static void Main()
    {
        var studentSystem = new StudentSystem();
        string command;
        while ((command = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(command);
            
        }
    }
}