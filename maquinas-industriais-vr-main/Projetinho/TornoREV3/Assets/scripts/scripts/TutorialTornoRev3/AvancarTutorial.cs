using UnityEngine;

public class AvancarTutorial : StateMachineBehaviour
{
    // override significa reescreve a classe pai.. 
    override public void SaidaObjeto(AnimatorStateInfo stateInfo)
    {
        
        // bsuca o objeto para carregar o tutorialtornoRev3,  mas deve ter outra forma de fazer isso, indica o local do tutorial para não procurar
        TutorialTornoRev3 maestro = FindFirstObjectByType<TutorialTornoRev3>();

        // esse nome maestro só usamos para receber o tuturialtornorev3 né?
        // por o tutorialtornorev3 tem a mesma com que o  <TutorialTornoRev3> e o animatorstateinfo.. se não sãoa s mesmas coisas
        if (maestro != null)
        {
            
            // to achando isso muito massivo, acho que podemos usar o for no lugar para rodar.. pois se nbçao terei que ir de else if em else isso.. não existe um contador para ir de se acabou o passo sobe mais ? tiṕo ++?
            if (stateInfo.IsName("Nome_Do_Estado_Passo1")) 
            {
                maestro.Passo2();
            }
            
            else if (stateInfo.IsName("Nome_Do_Estado_Passo2"))
            {
                maestro.Passo3();
            }
           
        }
    }
}