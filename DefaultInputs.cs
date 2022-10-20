using SpaceShip.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInputs 
{
    private DefaultActions inputs;
    public bool IsForceUp { get; private set; }
    public float LeftRight { get; private set; }
    public DefaultInputs()
    {
        inputs = new DefaultActions();
        inputs.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
        inputs.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>();
        inputs.Enable();
    }
}
