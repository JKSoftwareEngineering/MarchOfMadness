using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject PauseMaster;
    [SerializeField] private GameObject PrimaryDisplay;
    [SerializeField] private GameObject CollectablesDisplay;
    [SerializeField] private GameObject Col1;
    [SerializeField] private GameObject Col2;
    [SerializeField] private GameObject Col3;
    [SerializeField] private GameObject Col4;
    [SerializeField] private GameObject Col5;
    [SerializeField] private GameObject Col6;
    [SerializeField] private GameObject Col7;
    [SerializeField] private GameObject Col8;
    [SerializeField] private GameObject ControlerDisplay;
    [SerializeField] private GameObject MouseDisplay;
    [SerializeField] private GameObject GamepadDisplay;
    [SerializeField] private GameObject CollectableFinderDisplay;
    [SerializeField] private GameObject CollectableLocked1;
    [SerializeField] private GameObject CollectableLocked2;
    [SerializeField] private GameObject CollectableLocked3;
    [SerializeField] private GameObject CollectableLocked4;
    [SerializeField] private GameObject CollectableLocked5;
    [SerializeField] private GameObject CollectableLocked6;
    [SerializeField] private GameObject CollectableLocked7;
    [SerializeField] private GameObject CollectableLocked8;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(PauseMaster.activeInHierarchy)
            {
                PauseReset();
                PauseMaster.SetActive(false);
            }
            else
            {
                PauseReset();
                PauseMaster.SetActive(true);
                PrimaryDisplay.SetActive(true);
            }
        }
        CollectableLocked1.SetActive(CollectableControler.collectable1);
        CollectableLocked2.SetActive(CollectableControler.collectable2);
        CollectableLocked3.SetActive(CollectableControler.collectable3);
        CollectableLocked4.SetActive(CollectableControler.collectable4);
        CollectableLocked5.SetActive(CollectableControler.collectable5);
        CollectableLocked6.SetActive(CollectableControler.collectable6);
        CollectableLocked7.SetActive(CollectableControler.collectable7);
        CollectableLocked8.SetActive(CollectableControler.collectable8);
    }
    public void PauseReset()
    {
        PrimaryDisplay.SetActive(false);
        CollectablesDisplay.SetActive(false);
        Col1.SetActive(false);
        Col2.SetActive(false);
        Col3.SetActive(false);
        Col4.SetActive(false);
        Col5.SetActive(false);
        Col6.SetActive(false);
        Col7.SetActive(false);
        Col8.SetActive(false);
        ControlerDisplay.SetActive(false);
        MouseDisplay.SetActive(false);
        GamepadDisplay.SetActive(false);
        CollectableFinderDisplay.SetActive(false);
    }
    public void PauseExit()
    {
        PauseMaster.SetActive(false);
        PrimaryDisplay.SetActive(false);
        CollectablesDisplay.SetActive(false);
        Col1.SetActive(false);
        Col2.SetActive(false);
        Col3.SetActive(false);
        Col4.SetActive(false);
        Col5.SetActive(false);
        Col6.SetActive(false);
        Col7.SetActive(false);
        Col8.SetActive(false);
        ControlerDisplay.SetActive(false);
        MouseDisplay.SetActive(false);
        GamepadDisplay.SetActive(false);
        CollectableFinderDisplay.SetActive(false);
    }
    public void PauseBackToPrimary()
    {
        PauseReset();
        PrimaryDisplay.SetActive(true);
    }
    #region Collectables
    public void PauseBackToCollectables()
    {
        PauseReset();
        CollectablesDisplay.SetActive(true);
    }
    public void PauseCol1()
    {
        PauseReset();
        Col1.SetActive(true);
    }
    public void PauseCol2()
    {
        PauseReset();
        Col2.SetActive(true);
    }
    public void PauseCol3()
    {
        PauseReset();
        Col3.SetActive(true);
    }
    public void PauseCol4()
    {
        PauseReset();
        Col4.SetActive(true);
    }
    public void PauseCol5()
    {
        PauseReset();
        Col5.SetActive(true);
    }
    public void PauseCol6()
    {
        PauseReset();
        Col6.SetActive(true);
    }
    public void PauseCol7()
    {
        PauseReset();
        Col7.SetActive(true);
    }
    public void PauseCol8()
    {
        PauseReset();
        Col8.SetActive(true);
    }
    #endregion
    #region Controls
    public void PauseBackToControl()
    {
        PauseReset();
        ControlerDisplay.SetActive(true);
    }
    public void PauseMouseControl()
    {
        PauseReset();
        MouseDisplay.SetActive(true);
    }
    public void PauseGamepadControl()
    {
        PauseReset();
        GamepadDisplay.SetActive(true);
    }
    #endregion
    public void PauseCollectablesFinder()
    {
        PauseReset();
        CollectableFinderDisplay.SetActive(true);
    }
}
