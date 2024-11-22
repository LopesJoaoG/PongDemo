using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    public TextMeshProUGUI uWinner;
    // Start is called before the first frame update
    void Start()
    {
        SaveController.Instance.Reset();

        string lastWinner = SaveController.Instance.GetLastWinner();

        if (lastWinner != "")
        {
            uWinner.text = "Último Vencedor: " + lastWinner;
        }
        else
        {
            uWinner.text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
