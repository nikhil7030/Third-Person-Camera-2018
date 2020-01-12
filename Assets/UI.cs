using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Button WeaponIcon;
    public void WeaponUI(bool input)
    {
        if (input)
        {
            WeaponIcon.GetComponent<Button>().enabled = false;
        }
        else
        {
            WeaponIcon.GetComponent<Button>().enabled = true;
        }
    }
}
