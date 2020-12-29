using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Steps : MonoBehaviour
{
    [TextArea(10,50)]
    public string content;
    public string locate;

    public Sprite background; 

    public Steps nextSteps1;
    public Steps nextSteps2;

}
