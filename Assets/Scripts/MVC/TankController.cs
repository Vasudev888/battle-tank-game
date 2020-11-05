using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
/*    private TankView tankView;*/

    public TankController(TankModel tankModel, TankView tankPrefab)
    {
        TankModel = tankModel;

    //    GameObject go = GameObject.Instantiate(tankPrefab);
    //    TankView = go.GetComponent<TankView>();

        TankView = GameObject.Instantiate<TankView>(tankPrefab);
        Debug.Log("Tank view controller created", TankView);
    }

    public TankModel TankModel { get; }
    public TankView TankView { get; }
}
