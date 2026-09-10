Using UnityEngine;

public class ControladorTutorial : MonoBehaviour 
{
    
    [SerializeField] private string[] instrucoes;   // frases de orientação
    [SerializeField] private GameObject[] pecasDestaque; //arrastar trigger 
    private int etapaAtual = 0; 

    void Start()
    {
        MostrarEtapa(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //
            if (etapaAtual < instrucoes.Length - 1) 
            {
                etapaAtual++; 
                MostrarEtapa();
            }
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (etapaAtual > 0)
            {
                etapaAtual--;
                MostrarEtapa();
            }
        }
    }
    void MostrarEtapa()
    {
      
        Debug.Log($"[PASSO {etapaAtual + 1}/20]: {instrucoes[etapaAtual]}");

        for (int i = 0; i < pecasDestaque.Length; i++)
        {
            
            pecasDestaque[i].SetActive(i == etapaAtual); 
        }
    }
}