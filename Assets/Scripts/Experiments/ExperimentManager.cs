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
    public GameObject Visualiser2D;

    public GameObject Exam2VR;


    public bool CurrentExperiment1;
    public bool CurrentExperiment2;



    private void Awake()
    {
        Exam1VR.SetActive(false);
        Exam2VR.SetActive(false);
        instance = this;
    }

    public void StartExperiment()
    {
        CurrentExperiment1 = true;
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
            Exam1VR.SetActive(true);
        }

      

      
    }

   

    public void StartExperiment2()
    {
        CurrentExperiment1 = false;
        CurrentExperiment2 = true;

       
        Txt_Instruction.transform.parent.gameObject.SetActive(true);

        CurrentExperiment = AllExperiments[1];
        CurrentExperiment.StartExperiment2();
    }

    public void UpdateInstruction2(string msg)
    {
        Txt_Instruction.text = msg;

      
        if (CurrentExperiment.tag == "Exp2")
        {
            Exam1VR.SetActive(false);
            Exam2VR.SetActive(true);


        }
    }
}
