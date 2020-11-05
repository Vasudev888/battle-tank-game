using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleTonDemo <T>: MonoBehaviour where T : MonoBehaviour
{
    static T instance;
    
    static object m_lock = new Object();

    public static T GetInstance()
    {
        lock(m_lock)
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();

                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).ToString();
                    instance = obj.AddComponent<T>();
                    DontDestroyOnLoad(obj);
                }
            }
        }
        return instance;
    }
}
