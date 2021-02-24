using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ToggleSwitch();
        }
    }
    public void ToggleSwitch()
    {
        if (this.name == "GreenSwitch")
        {
            TileSwitchLM.instance.greenSwitchOff = !TileSwitchLM.instance.greenSwitchOff;
        }
        if (this.name == "RedSwitch")
        {
            TileSwitchLM.instance.redSwitchOn = !TileSwitchLM.instance.redSwitchOn;
        }
    }
}
