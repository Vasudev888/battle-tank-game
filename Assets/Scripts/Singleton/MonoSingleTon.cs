using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleTon : MonoBehaviour
{
    private static MonoSingleTon instance;
    public MonoSingleTon Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void PlayGame()
    {

    }
}

public class GameWorld : MonoSingleTon
{
   
}

public class World : MonoBehaviour
{
    private void Awake()
    {
    /*    GameWorld.Instance.PlayGame();*/
    }
}
