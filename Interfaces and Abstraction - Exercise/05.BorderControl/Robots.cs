﻿using System;
using System.Collections.Generic;
using System.Text;

public class Robots : SocietyMembersId
{
    public string Id { get; }
    private string model;

    public Robots(string model, string id)
        : base(id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }
}