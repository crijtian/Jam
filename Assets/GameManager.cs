using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public HUD hud;
    public bool bandera = true;
    private int vidas = 3;

    public static GameManager Instance { get; internal set; }

    void Start()
    {

    }


    void Update()
    {

    }

    public void PerderVida()
    {
        if (bandera)
        {
        vidas -= 1;

        if (vidas == 0)
        {
            //Se acaba la partida del juego
            SceneManager.LoadScene(0);
        }

        hud.DesactivarVida(vidas);
       }
    }

    public bool RecuperarVida()
    {
        if (vidas == 3)
        {
            return false;
        }

        hud.ActivarVida(vidas);
        vidas += 1;
        return true;

    }
}