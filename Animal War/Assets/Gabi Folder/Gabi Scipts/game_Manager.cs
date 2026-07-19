using System.Data.SqlTypes;
using UnityEngine;

public class game_Manager : MonoBehaviour
{


    public int health = 20;
    public int gold = 0;





    public void getMoney(int money)
    {
        gold += money;
        Debug.Log("money money");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
