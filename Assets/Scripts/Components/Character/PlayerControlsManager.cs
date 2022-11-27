using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsManager : MonoBehaviour
{
    public PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
