using UnityEngine;

public class tutorialTorno : MonoBehaviour
{
    //base
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
    public Animator protecaoMotor;

    // carrinho movel
    public Animator carroprincipal;
    public Animator carrinho_botaoAlavanca00;
    public Animator carrinho_botaoAlavanca05;
    public Animator carrinho_botao_alavanca04;
    public Animator carrinho_cylinder01;
    public Animator carrinho_alavancaDesliga;
    public Animator carrinho_manivela;
    public Animator carrinho_baseRetangular;
    public Animator carrinho_basecarrolongitudinal;
    public Animator carrinho_torreferramenta;
    public Animator carrinho_pecaArredondada;
    public Animator carrinho_cylinder08;
    public Animator carrinho_protecaoFacial;

// cabeçote movel
    public Animator cabecote_cabecotemovel03;
    public Animator cabecote_manivela;
    public Animator cabecote_cylinder06;
    public Animator cabecote_pivot_pescoco;
    public Animator cabecote_movel;
    
    private int passoAtual = 0;

    
    private void OnTriggerEnter(Collider other) 
    {
        
        if (other.CompareTag("Player") && passoAtual == 0) 
        {
            ExecutarTutorial();
        }
    }

    void ExecutarTutorial()
    {
        passoAtual = 1;
        Passo1(); 
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
        Invoke("Passo4", 5.0f);
      
    }

    public void Passo4()
    {
        passoAtual = 4;
        botaoBaseVerde.SetTrigger("Cylinder_010Start");
        Invoke("passo5",5.0f);
    }

    public void Passo5()
    {
        passoAtual = 5;
        botaoBaseGizmo.SetTrigger("Cylinder_09start");
        Invoke("passo6",5.0f);
    }
    public void passo6()
    {
        passoAtual = 6;
        botaoBaseDentado02.SetTrigger("BotaoDent02Star");
        Invoke("passo7",5.0f);
    }
    public void passo7()
    {
        passoAtual = 7;
        botaoBaseDentado01.SetTrigger("Botao01DentStart");
        Invoke("passo8", 5.0f);
    }
    public void passo8()
    {
        passoAtual = 8;
        botaoAlavanca03.SetTrigger("botaoalavanca03Start");
        Invoke("passo9", 5.0f);
    }

    public void passo9()
    {
        passoAtual= 9;
        botaoAlavanca01.SetTrigger("Botaoalavanca01Start");
        Invoke("passo10",5.0f);
    }
    public void passo10()
    {
        passoAtual=10;
        botaoAlavanca02.SetTrigger("botaoalavanca02start");
        Invoke("passo10",5.0f);

    }
    public void passo11()
    {
        passoAtual=11;
        botaoBaseDentado00.SetTrigger("botaodentado0start");
        Invoke("passo12",5.0f);
    }

//carrinho longitudinal

    public void passo12() 
    {
        passoAtual=12;
        carrinho_botaoAlavanca00.setTrigger("BOTAO_ALAVANCA");
        Invoke("passo13",5.0f);
    }
    public void passo13()
    {
        passoAtual=13;
        carrinho_botao_alavanca04.setTrigger("botaoalavanca04start");
        Invoke("passo14",5.0f);
    }
    public void passo14()
    {
        passoAtual =14;
        carrinho_botaoAlavanca05.setTrigger("botaoalavanca05start");
        Invoke("passo15", 5.0f);
    }
    public void passo15() 
    {
        passoAtual=15;
        carrinho_cylinder01.SetTrigger("Cylinder01start");
        Invoke("passo16",5.0f);
    }
    public void passo16()
    {
        passoAtual=16;
        carrinho_baseRetangular.SetTrigger("bloco_retangular_parado");
        Invoke("passo17", 5.0f);
    }
    public void passo17()
    {
        passoAtual=17;
        carrinho_basecarrolongitudinal.SetTrigger("base_carro_longitudinal_start");
        Invoke("passo18",5.0f);
    }
    public void passo18()
    {
        passoAtual=18;
        carrinho_torreferramenta.SetTrigger("torre_ferramenta_start");
        Invoke("passo19",5.0f);
    }
    public void passo19()
    {
        passoAtual=19;
        carrinho_cylinder08.setTrigger("cylinder08start");
        Invoke("passo20",5.0f);
    }

    public void passo20() 
    {
        passoAtual=20;
        carroprincipal.SetTrigger("Carro_longitudel_start");
        Invoke("passo21", 5.0f);
    }   
    public void passo21() 
    {
        passoAtual=21;
        carrinho_protecaoFacial.SetTrigger("protecao_facial_start");
        Invoke("passo22", 5.0f);
    }
    public void passo22() 
    {
        passoAtual=22;
        carrinho_manivela.SetTrigger("manivelacarrostart");
        Invoke("passo23", 5.0f);
    }

    //cabecote movel
    public void passo23 () 
    {
        passoAtual=23;
        cabecote.SetTrigger("base_cabecote_movel_start");
        Invoke("passo24", 5.0f);
    }
    public void passo24 () 
    {
        passoAtual=24;
        cabecote_manivela.SetTrigger("manivela_cabecote_start");
        Invoke("passo25", 5.0f);
    }
    public void passo25 () 
    {
        passoAtual=25;
        cabecote_cylinder06.SetTrigger("Cylinder06_start");
        Invoke("passo26", 5.0f);
    }
    public void passo27 () 
    {
        passoAtual=27;
        cabecote_cabecotemovel03.SetTrigger("cabecote_movelparado");
        Invoke("passo28", 5.0f);
    }
    public void passo28 () 
    {
        passoAtual=28;
        cabecote_pivot_pescoco.SetTrigger("pivot_pescoco_movel");
        Invoke("passo29", 5.0f);
    }


    void Start()
    {
        Passo1();
  
    }

    
    void Update()
    {
   
    }
}
    
