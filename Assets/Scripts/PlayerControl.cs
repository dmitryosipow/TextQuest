using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    [Header("Stats")]
    public int health;
    [Header("Images")]
    public Image avatar;
    public Sprite veryLow;
    public Sprite low;
    public Sprite high;


    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(health > 70)
        {
            avatar.sprite = high;
        }
        else if(health > 40)
        {
            avatar.sprite = low;
        }
        else
        {
            avatar.sprite = veryLow;
        }
    }

    public void UpdateHealth(int delta)
    {
        health += delta;
    }

    public void Reset()
    {
        Start();
    }
}
