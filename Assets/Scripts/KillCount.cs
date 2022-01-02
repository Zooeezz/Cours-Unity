using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillCount : MonoBehaviour
{
    public float killCount = 0;
    public int killCountConverted;
    UnityEngine.UI.Text killCountText;

    // Start is called before the first frame update
    void Start()
    {
        killCountText = GameObject.Find("KillCount").GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        killCountConverted = (int)killCount;
        killCountText.text = killCountConverted.ToString();
    }
}
