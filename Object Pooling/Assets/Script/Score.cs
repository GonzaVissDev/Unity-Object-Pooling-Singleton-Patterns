using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    /*--------------[ Text Visual in Game]--------------*/

    public Text Ob_Pool;
    public Text Coin_Text;

    /*--------------[Pooling Object Count]--------------*/

    [HideInInspector]
    public int ObjectPool = 0;

    [HideInInspector]
    public int TotalCoin = 0;

    /*--------------[ Singleton Patron ]--------------*/

    public static Score Instance_Score;


    private void Awake()
    {
        Instance_Score = this;
    }

  
    void Update()
    {
        Ob_Pool.text = ("Objects on scene:" + ObjectPool);
        Coin_Text.text = (":" + TotalCoin);      
    }

}
