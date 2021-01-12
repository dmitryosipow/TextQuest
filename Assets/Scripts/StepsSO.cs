using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StepsSO : ScriptableObject
{
    [TextArea(10, 50)]
    public string content;
    public string locate;

    public Sprite background;

    public int deltaHealth = 0;
    public bool startStep = false;

    public StepsSO nextSteps1;
    public StepsSO nextSteps2;
}
