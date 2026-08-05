using UnityEngine;

public class TutorialTorno : MonoBehaviour
{
    public Animator Nurbspath;
    public Animator animCylinder011;

    private int passoAtual = 0;
    private void OnTriggerEnter(Collider other);
    {
        
        if (other.CompareTag("Player") && passoAtual == 0) 
        {
            ExecutarTutorial();
        }
    }

    void ExecutarTutorial()
    {
       
        animNurbspath.SetTrigger("IniciarNurbs"); 
        passoAtual = 1;

        
        Invoke("RodarCylinder", 3.0f); 
    }

}

