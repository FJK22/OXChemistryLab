using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Looxid.Link;

public class ExperimentManager : MonoBehaviour
{
    public static ExperimentManager instance;

    [SerializeField] GameObject BeforeStartExp_Obj;

    [Space]
    [SerializeField] TextMeshProUGUI Txt_Instruction;


    [Header("All Experiments")]
    [SerializeField] ExperimentBase[] AllExperiments;

    [Header("Current Experiment")]
    [SerializeField] ExperimentBase CurrentExperiment;

    public GameObject Exam1VR;

   


    private void Awake()
    {
        Exam1VR.active = false;
        instance = this;
    }

    public void StartExperiment()
    {
        BeforeStartExp_Obj.SetActive(false);
        Txt_Instruction.transform.parent.gameObject.SetActive(true);

        CurrentExperiment = AllExperiments[0];
        CurrentExperiment.StartExperiment();
    }
    public void UpdateInstruction(string msg)
    {
        Txt_Instruction.text = msg;


        if (CurrentExperiment.tag == "Exp1")
        {
            Exam1VR.active = true;
        }
    }
}
