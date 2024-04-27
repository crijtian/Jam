using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlDeMenu : MonoBehaviour
{
    // Nombre de la escena del menú principal
    public string nombreDeLaEscenaDelMenuPrincipal = "MenuPrincipal";

    void Update()
    {
        // Si se presiona la tecla "Escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Cargar la escena del menú principal
            SceneManager.LoadScene(0);
        }
    }
}   