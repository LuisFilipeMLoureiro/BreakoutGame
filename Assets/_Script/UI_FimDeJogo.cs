using UnityEngine;
using UnityEngine.UI;


public class UI_FimDeJogo:MonoBehaviour
{
  public Text mensagem;
  GameManager gm;
  private void OnEnable ()
  {
    gm = GameManager.GetInstance ();
    if (gm.vidas > 0)
      {
	mensagem.text = "Você Ganhou!!!";
      }
    else
      {
	mensagem.text = "Você Perdeu!!!";
      }
  }

public void Voltar()
{
  Debug.Log("Clique");
  gm.ChangeState(GameManager.GameState.GAME);
}





}
