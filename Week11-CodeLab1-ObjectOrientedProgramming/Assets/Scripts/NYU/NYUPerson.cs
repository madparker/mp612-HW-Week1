﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is the base class for anyone associated w/ NYU
public class NYUPerson
{
    public string name;
    public string netId;
    public string type;

    //this is the base constructor
    public NYUPerson(string name, string netId)
    {
        this.name = name;
        this.netId = netId;
        type = "NYU Person";
    }

    //this is a virtual function, that can be overridden
    public virtual string showRecord()
    {
        return
            "Name: " + name + "\n" +
            "Type: " + type + "\n" +
            "NetId: " + netId + "\n";
    }
}
