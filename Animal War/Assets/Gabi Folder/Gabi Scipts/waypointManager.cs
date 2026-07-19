using UnityEngine;

public class waypointManager : MonoBehaviour
{


    public static waypointManager Instance;

    public Transform[] waypoints;

    private void Awake()
    {
        Instance = this;
    }
}
