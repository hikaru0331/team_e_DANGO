using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDangoInfo
{
    string Name { get; }
    Sprite Sprite { get; set; }
    string Color { get; }
    string Attribute { get; }


    int Point { get; set; }
    //float Probability { get; set; }
}
