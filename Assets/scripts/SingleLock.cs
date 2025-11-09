using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleLock : MonoBehaviour
{
    [SerializeField] private string preLevel;
    [SerializeField] private GameObject GlobalLib;
    [SerializeField] private GameObject ButtonToBeLocked;

    private void Awake()
    {
        LevelControl lc = GlobalLib.GetComponent<LevelControl>();
        bool interactable = false;
        if (lc.IsLevelCompleted(preLevel))
        {
            interactable = true;
        }
        ButtonToBeLocked.GetComponent<Button>().interactable = interactable;
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
