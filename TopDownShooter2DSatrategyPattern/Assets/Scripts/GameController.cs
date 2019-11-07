using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instancia = null;
    [SerializeField] private Transform player;

    private void Awake()
    {
        if (Instancia == null) Instancia = this;
        else if (Instancia != this)
            Destroy(this);

    }
    public Vector3 GetPlayerPosition()
    {
        return player.position;
    }
}
