using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestSO : MonoBehaviour
{
    public Text content;
    public Text titleText;
    public Text location;

    public Image picture;

    public StepsSO currentStep;
    public PlayerControl player;
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

    private void Reset()
    {
        player.Reset();
    }

    void UpdateStep(StepsSO step)
    {
        currentStep = step;
        content.text = step.content;
        picture.sprite = step.background;
        location.text = step.locate;
        player.UpdateHealth(step.deltaHealth);
        if (step.startStep)
        {
            Reset();
        }
    }
}
