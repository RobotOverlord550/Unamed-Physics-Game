using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsManager : MonoBehaviour
{
    public PlayerControls playerControls;

    public bool noClip = false;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Universal.Enable();
        playerControls.Walking.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Update()
    {
        if (playerControls.Universal.ToggleNoClip.triggered)
        {
            noClip = !noClip;

            if (noClip)
            {
                playerControls.Walking.Disable();
                playerControls.NoClip.Enable();
            }
            else
            {
                playerControls.Walking.Enable();
                playerControls.NoClip.Disable();
            }
        }
    }
}
