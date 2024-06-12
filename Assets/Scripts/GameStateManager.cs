using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
  
    [Tooltip("How many attemps the player have")]
    [SerializeField]
    int Lives;
    
    

    [Tooltip("Our current coins")]
    [SerializeField]
    int CurrentCoins;

    [Tooltip("Reference to the playyer controller")]
    [SerializeField]
    PlayerController player;
    
    bool CanShoot = false;
    bool CanKill = false;

    //this is a stastic instance , that means that only one instance of 
    //this variable will exist, and you need to refernece it via the
    //ClassName, not an instance of the class
    private static GameStateManager instance;
    

    public static GameStateManager Instance
    {
        get { return instance; }
    }

    public int GetLives()
    {
        return Lives;
    }
    public int GetCurrentCoins()
    {
        return CurrentCoins;
    }
    public bool GetCanShoot()
    {
        return CanShoot;
    }
    public bool GetCanKill()
    {
        return CanKill;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(instance != null)
        {
            //destroy the duplicate.
            GameObject.Destroy(this.gameObject);
        }
        else
        {
            
            instance = this;
            //make sire we ersist between levels
            DontDestroyOnLoad(this.gameObject);
        }
        //check if there is a player
        if(player == null)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("Player");
            if(temp != null)
            {
                //if we have an object tagged player get that reference!
                player = temp.GetComponent<PlayerController>();
                if (player == null)
                {
                    Debug.LogWarning("Player is missing playerController");
                }
            }
            else
            {
                Debug.LogWarning("Player is missing!!");
            }
        }
    }
    /// <summary>
    /// Cakked when a player loses or gains lives
    /// </summary>
    /// <param name="deltaChange">change in lives Value</param>
    public void ChangeLives(int deltaChange)
    {
        Lives += deltaChange;
        
    }
    public void OnDeath()
    {
        ChangeLives(-1);
       
        if (Lives < 0)
        {
            //Game Over!
            Debug.Log("No more lives'");
            Lives = 3;
            CurrentCoins = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
    public void OnUpgradeShoot()
    {
        CanShoot = true;
    }
    public void OnUpgradeShootKill()
    {
        CanKill = true;
    }
    public void OnGameReset()
    {
        CurrentCoins = 0;
        CanShoot = false;
        CanKill = false;
    }
   
       
       
    

    internal void ChangeCoins(int coinsValue)
    {
        CurrentCoins += coinsValue;
    }
    /// <summary>
    /// When new level object is callided with
    /// </summary>
    /// <param name="nextScene"></param>
    internal void onGoal(string nextScene)
    {
        if (nextScene =="default")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            SceneManager.LoadScene(nextScene);
        }
        
    }
}
