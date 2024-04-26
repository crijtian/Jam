using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrancisionEscena : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private AnimationClip animacionFinal;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(CambiarEscena());
        }
    }

    IEnumerator CambiarEscena(){
        animator.SetTrigger("Iniciar");

        yield return new WaitForSeconds(animacionFinal.length);

        SceneManager.LoadScene(1);


    }

}



