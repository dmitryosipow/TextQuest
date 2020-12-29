using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text content;
    public Text titleText;
    public Text location;

    public Image picture;

    public Steps currentStep;
    // Start is called before the first frame update
    void Start()
    {
        titleText.text = "Post-apocaleptic Minsk";
        UpdateStep(currentStep);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            UpdateStep(currentStep.nextSteps1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            UpdateStep(currentStep.nextSteps2);
        }
    }

    void UpdateStep(Steps step)
    {
        currentStep = step;
        content.text = step.content;
        picture.sprite = step.background;
        location.text = step.locate;
    }
}
