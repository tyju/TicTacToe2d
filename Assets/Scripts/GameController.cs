using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
  //----- Definition Variable -----//
  public  GameObject  gameOverPanel;
  public  Text        gameOverText;
  public  Text[]      buttonList;
  private string      playerSide;

  //----- State Function      -----//
  private void Awake() {
    gameOverPanel.SetActive(false);
    playerSide = "X";

    SetGameControllerReferenceOnButtons();
  }
  
  //----- Private Function    -----//
  private void SetGameControllerReferenceOnButtons() {
    foreach(Text bt in buttonList) {
      bt.GetComponentInParent<GridSpace>().SetGameControllerReference(this);
    }
  }

  //----- Public Function     -----//
  public string GetPlaySide() {
    return playerSide;
  }

  public void ChangeSide() {
    playerSide = playerSide == "X" ? "0" : "X";
  }

  public void EndTurn () {
    if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide) {
      GameOver();
    }
    if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide) {
      GameOver();
    }
    if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide) {
      GameOver();
    }
    if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide) {
      GameOver();
    }
    if (buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide) {
      GameOver();
    }
    if (buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide) {
      GameOver();
    }
    if (buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide) {
      GameOver();
    }
    if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide) {
      GameOver();
    }

    ChangeSide();
  }

  private void GameOver() {
    foreach(Text bt in buttonList) {
      bt.GetComponentInParent<Button>().interactable = false;
    }
    gameOverPanel.SetActive(true);
    gameOverText.text = playerSide + " Wins!";
  }
}
