using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSwitchLM : MonoBehaviour
{
    public static TileSwitchLM instance;

    public GameObject greenWallMap;
    public GameObject redWallMap;
    public bool greenSwitchOff;
    public bool redSwitchOff;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        greenSwitchOff = true;
        redSwitchOff = true;
    }

    void Update()
    {
        greenWallMap.SetActive(greenSwitchOff);
        redWallMap.SetActive(redSwitchOff);
    }

}
