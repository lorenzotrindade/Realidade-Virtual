using UnityEngine;
public class tutorialTorno: MonoBehaviour

[Header("Ordem das animações")]
// só para deixar as coisas em negrito 

public Animator[] seqAnimators;

public string[] nomeTriggers;

private int passoAtual=0;
private bool tutoralAtivo = false;

private void OnTriggerEnter(Collider other)
{
    //para não reiniciar
    if (other.CompareTag("player")&& !tutorialAtivo && passoAtual==0)
    {
        iniciartutorial();
    }
}

void iniciartutorial()
{
    tutorialTorno = true;
    passoAtual=1;
    executarPasso(passoAtual);
}

void Update()
{
    if(tutorialAtivo && Input.GetKeyDown("KeyCode.Space"))
    {
        avancarPasso();
    }
}

void avancarPasso()
{
    if (passsoAtual < seqAnimators.Length)
    {
        passoAtual++;
        executarPasso(passoAtual);
    }
    else
    {
        tutorialAtivo = false;
        Debug.Log("Tutorial do torno concluído");
    }
}
void executarPasso(int passo)
{
    int i = passo - 1;

    if(i < seqAnimators.Length && i < nomeTriggers.Length)
    {
        Animator animatorAtual = seqAnimators[i];
        string triggerAtual = nomeTriggers[i];

        if (animatorAtual != null && !string.IsNullOrEmpty(triggerAtual))
        {
            animatorAtual.SetTrigger(triggerAtual);
            Debug.Log($"Executando passo {passo} : iniciando {animatorAtual.name} controle com {triggerAtual}");
        }
        else
        {
            Debug.LogWarning($"Passo {passo} chegou ao fim.");
        }
    }
}