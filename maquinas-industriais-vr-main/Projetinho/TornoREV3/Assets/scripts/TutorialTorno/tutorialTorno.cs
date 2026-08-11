using UnityEngine;

public class tutorialTorno : MonoBehaviour
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
    public Animator carroprincipal;
    public Animator cabecote_movel;
    
    private int passoAtual = 0;

// ideia no momento está a cada vez que o usuario colidir, ocorre algo..
    private void OnTriggerEnter(Collider other) {

        // Só inicia se quem colidir for o Player e estivermos no passo zero
        if (other.CompareTag("Player") && passoAtual == 0); 
        {
            ExecutarTutorial();
        }
    }

    // invoke funciona como dizer, guarde o nome desse trigger e aguarda x segundos e depois execute
    void ExecutarTutorial()
    {
        passoAtual = 1;
        Passo1(); //dispara o passo 1 imediatamente
    }
       public void Passo1()
    {
        NurbsPath.SetTrigger("NubsPath"); 
        Invoke("Passo2", 5.0f); 
    }

        public void Passo2()
    {
        passoAtual = 2;
        botaoBaseAmarelo.SetTrigger("CylinderIniciar"); 
        Invoke("Passo3", 5.0f);  
    }

  
    public void Passo3()
    {
        passoAtual = 3;
        botaoBaseEmergencia.SetTrigger("Cylinder_emergencia_start"); 
        invoke("Passo4", 5.0f)
      
    }

    public void Passo4()
    {
        passoAtual = 4;
        botaoBaseVerde.SetTrigger("Cylinder_010Start");
        invoke("passo5",5.0f);
    }

    public void Passo5()
    {
        passoAtual = 5;
        botaoBaseGizmo.SetTrigger("Cylinder_09start");
        invoke("passo6",5.0f);
    }
    public void passo6()
    {
        passoAtual = 6;
        botaoBaseDentado02.SetTrigger("BotaoDent02Star");
        invoke("passo7",5.0f);
    }
    public void passo7()
    {
        passoAtual = 7;
        botaoBaseDentado01.SetTrigger("Botao01DentStart");
        invoke("passo8", 5.0f);
    }
    public void passo8()
    {
        passoAtual = 8;
        botaoAlavanca03.SetTrigger("botaoalavanca03Start");
        invoke("passo9", 5.0f);
    }

    public void passo9()
    {
        passoAtual= 9;
        botaoAlavanca01.SetTrigger("Botaoalavanca01Start");
        invoke("passo10",5.0f);
    }
    public void passo10()
    {
        passoAtual=10;
        botaoAlavanca02.SetTrigger("botaoalavanca02start");
        invoke("passo10",5.0f);

    }
    public void passo11()
    {
        passoAtual=11;
        botaoBaseDentado00.SetTrigger("botaodentado0start");
        invoke("passo12",5.0f);
    }
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
    
