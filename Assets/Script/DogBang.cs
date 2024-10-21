using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBang : MonoBehaviour
{
    public GameObject WarningPrefab;
    public Transform WarningPivot;
    public GameObject CurrentWarning;

    public int DogCondition = 99;
    public bool DogSick = false;

    public DogHealAndFadeOutController DestoryDog;

    // Update is called once per frame
    void Start()
    {
        UpdateCondition();
    }

    public void OnWarning()
    {
        

        if (DogCondition < 60)
        {
            CurrentWarning = Instantiate(WarningPrefab, WarningPivot);
            CurrentWarning.transform.localPosition = Vector3.zero;
            DogSick = true;
        }

        if (DogCondition == 100)
        {
            Destroy(CurrentWarning);
            DogSick = false;
        }
    }

    public void UpdateCondition()
    {
        if (DogCondition < 60)
        {
            OnWarning();
            DogSick = true;
        }

        if (DogCondition == 100)
        {
            OnWarning();
            DestoryDog.HealAndFadeOut();
            DogSick = false;
        }
    }
}
