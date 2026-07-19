using UnityEngine;

public class waypointManager : MonoBehaviour
{


    public static waypointManager Instance;

    public int gold = 0;
    public game_Manager gameManager;

    public void addGold(int money)
    {
        gold += money;
        gameManager.getMoney(gold);
        gold = 0;
    }
    public Transform[] waypoints;

    private void Awake()
    {
        Instance = this;
    }
}
