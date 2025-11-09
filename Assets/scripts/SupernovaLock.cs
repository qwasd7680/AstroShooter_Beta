using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupernovaLock : MonoBehaviour
{
    [SerializeField] private string preLevel_1;
    [SerializeField] private string preLevel_2;
    [SerializeField] private GameObject GlobalLib;
    [SerializeField] private GameObject Button_Supernova;
    [SerializeField] private GameObject canvasToOpen;

    public void FinalCheck()
    {
        LevelControl lc = GlobalLib.GetComponent<LevelControl>();
        LoadRoom lr = Button_Supernova.GetComponent<LoadRoom>();

        if (lc.IsLevelCompleted(preLevel_1) || lc.IsLevelCompleted(preLevel_2))
        {
            //进入超新星关卡
            lr.GetLoading();
        }
        else
        {
            //显示信息
            canvasToOpen.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
