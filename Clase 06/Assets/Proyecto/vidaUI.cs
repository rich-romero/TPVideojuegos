using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaUI : MonoBehaviour
{
    public jugador player;
    public Text vidaTexto;
    public Image barra;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vidaTexto.text = player.vida.ToString();
        barra.fillAmount = player.vida*(float)0.01;
    }
}
