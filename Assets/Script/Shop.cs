using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint MeleeTurret;
    public TurretBlueprint ArrowTurret;
    public TurretBlueprint SlowTurret;


    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(MeleeTurret);
    }

    public void SelectArrowTurret()
    {
        Debug.Log("ArrowTurret Selected");
        buildManager.SelectTurretToBuild(ArrowTurret);
    }


    public void SelectSlowTurret()
    {
        Debug.Log("SlowTurret Selected");
        buildManager.SelectTurretToBuild(SlowTurret);
    }

}
