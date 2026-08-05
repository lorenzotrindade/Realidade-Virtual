using UnityEngine;

public class TutorialTornoRev3 : MonoBehaviour
{
    
    public Animator NurbsPath;
    public Animator botaoBaseAmarelo;
    public Animator botaoBaseEmergencia;
    public Animator botaoBaseVerde;
    public Animator botaoBaseGizmo;
    public Animator botaoBaseDentado02;
    public Animator botaoBaseDentado01;
    public Animator botaoBaseDentado00;
    public Animator botaoAlavanca03;
    public Animator botaoAlavanca01;
    public Animator botaoAlavanca02;
    

    void Start()
    {
        Passo1();
  
    }

    
    void Update()
    {
    public void Passo1() => NurbsPath.SetTrigger("NubsPath");
    public void Passo2() => botaoBaseAmarelo.SetTrigger("CylinderIniciar");
    public void Passo3() => botaoBaseEmergencia.SetTrigger("Cylinder_emergencia_start");

    }
    
    
}
