using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C0904PLayerLife : MonoBehaviour
{
    public Player player;
    public Text vidaTexto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaTexto.text = player.vida.ToString();
    }
}
