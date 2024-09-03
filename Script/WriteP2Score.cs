using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WriteP2Score : MonoBehaviour
{
    private void Update()
    {
        GetComponent<TextMeshProUGUI>().text = GlobalVariables.player2Score.ToString();
    }
}
