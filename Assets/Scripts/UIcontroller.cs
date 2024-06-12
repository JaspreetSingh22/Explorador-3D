using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public Text CoinText;
    
   
    public List<GameObject> Lives;

    int currentLiveIndex = 2;

    // Update is called once per frame
    void Update()
    {
        CoinText.text = GameStateManager.Instance.GetCurrentCoins().ToString("D3");
        int currlives = GameStateManager.Instance.GetLives();
        
        //check if we need to update our lives graphics
        if (currlives -1 != currentLiveIndex)
        {
            Lives[currentLiveIndex].SetActive(false);
            if(currentLiveIndex> 0)
            {
                currentLiveIndex -= 1;
            }
        }
    }
    //public void UIupdateKey(int KeyCollectedNo ,int  KeysNeeded)
    //{
    //    KeyText.text = KeyCollectedNo.ToString() + "/ " + KeysNeeded.ToString();
    //}
}
