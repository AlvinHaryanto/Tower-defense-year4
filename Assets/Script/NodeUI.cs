using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{

    public GameObject ui;

    private Node target;

    public Button upgradeButton;

    public Text sellAmount;
    public Text upgradeCost;
   
    public TurretBlueprint turretBluePrint;

    public void SetTarget(Node Target)
    {
        target = Target;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "MAX";
            upgradeButton.interactable = false;
        }

        sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();
          
        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectedNode();
    }


    public void Sell()
    {
       target.SellTurret();
       BuildManager.instance.DeselectedNode();
    }
}
