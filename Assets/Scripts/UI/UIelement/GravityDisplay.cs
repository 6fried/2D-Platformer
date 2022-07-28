using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class handles displayig the score
/// </summary>
public class GravityDisplay : UIelement
{
    [Header("References")]
    [Tooltip("The text to use when displaying the gravity state")]
    public Text displayText = null;
    [Tooltip("The Gravity State")]
    public GravityState gravityState = null;
    private string state;
    /// <summary>
    /// Description:
    /// Displays the gravity onto the display text
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    public void DisplayGravity()
    {
        if (displayText != null)
        {
            if (gravityState.isGravityInverted)
            {
                state = "Inverted";
            }
            else
            {
                state = "Normal";
            }
            displayText.text = "Gravity: " + state;
        }
    }

    /// <summary>
    /// Description:
    /// Updates this UI based on this class
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayGravity();
    }
}
