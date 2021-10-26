using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentBase : MonoBehaviour
{
    [SerializeField] string[] Instructions;
    int currentInstIndex;
    

    public virtual void StartExperiment()
    {
        UpdateInstruction();
    }
    public void UpdateInstruction()
    {
        ExperimentManager.instance.UpdateInstruction(Instructions[currentInstIndex]);
       
        
    }
}
