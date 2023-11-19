using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateButton : MonoBehaviour
{
    public Button button;

    private void OnMouseUp()
    {
        if (button != null)
        {
            button.gameObject.SetActive(true);
        }
    }
}
